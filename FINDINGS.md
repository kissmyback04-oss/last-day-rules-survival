# Linux Editor Compatibility — Test Findings

This document describes what actually breaks (and what *doesn't*) when you open
the AssetRipper-reconstructed `ExportedProject` in a Unity Editor on Linux,
and the two fix scripts in `tools/` that address the real issues.

## TL;DR

| Concern | Reality |
| --- | --- |
| "Editor crashes when loading shaders on Linux" | **Did not reproduce** in Unity 2019.4.40f1 LTS Linux. Editor opens, scenes load, no crash. |
| Original game shaders | **Cannot be recovered** — the build only contains compiled GPU bytecode. AssetRipper writes 49 `DummyShaderTextExporter` stubs. |
| Real blockers | C# compile errors in `MonoScript/DOTween43`/`DOTween46` (decompile artifacts), and an `Unity.TextMeshPro.asmdef` collision with the `com.unity.textmeshpro` Package. |

## Test environment

- Host: Ubuntu 22.04 LTS, Mesa OpenGL 4.5 (GL Core).
- Editor: **Unity 2019.4.40f1 LTS** (official Linux build). Unity 2018.3.8f1
  Linux Editor was *not* used here — its installer is no longer hosted by
  Unity, and 2019.4 LTS auto-upgrades 2018.3 projects.
- Project: full reconstructed project (1.1 GB) with all binary assets restored
  from the AssetRipper output.

Two test trees were created from the same source:

- `test_project_BEFORE/` — pristine, all 49 dummy shaders intact.
- `test_project/` — both fix scripts applied.

## What I tested and what I observed

### BEFORE — pristine reconstructed project

1. `Unity -batchmode -nographics -quit -projectPath …` — completed import,
   exit code 0, 22 C# compile warnings/errors logged but Editor process did
   not abort. Shader compiler launched cleanly.
2. `Unity -projectPath …` (GUI on `:0`) — splash → Asset DB Version Upgrade
   prompt → empty default scene loaded.
3. Console after load: **15 errors, 11 warnings, 1 info**. Errors:
   - `error CS0683` `TMP_InputField.get_transform()` (decompiled TMP)
   - `error CS1061` `Sequence`/`TweenerCore` missing methods (decompiled DOTween43/46)
   - `error: Assembly with name 'Unity.TextMeshPro' already exists` (asmdef
     collision with the `com.unity.textmeshpro` Package)
   - **Zero shader-related errors.**
4. Loaded `Assets/Scene/main.unity` → opened (UI bootstrap, just the
   `UIRootCanvas`).
5. Loaded `Assets/Scene/buildplayer-battle.unity` → opened, default skybox
   visible, grid floor rendered. Hierarchy: `buildplayer-battle > Base`. The
   `Base` GameObject has three scripts (`BuildManager`, `MonsterMgr`,
   `DayNightSystem`) marked as "associated script can not be loaded" because
   the C# compile failures above prevent `Assembly-CSharp.dll` from being
   produced.
6. Editor stayed responsive throughout. No SIGSEGV, no `Aborted`, no
   `core dumped` in the log.

### AFTER — both fix scripts applied

Same hardware, same Editor, same workflow. Differences:

- 49 dummy shaders rewritten to bare `Fallback "<built-in>"` proxies (see
  `tools/fix-dummy-shaders.py`).
- 2 decompiled package copies removed (`MonoScript/Unity.TextMeshPro` and
  `MonoScript/Unity.Analytics.DataPrivacy`) by `tools/fix-decompiled-conflicts.py`.

Console after load: **14 errors, 16 warnings, 1 info**. Errors:

- `error CS0122` `SpecialStartupMode` (DOTween46 decompile artifact)
- `error CS1061` `Sequence.isRelative`, `TweenerCore.Blendable`,
  `SetSpecialStartupMode` (DOTween43/46 decompile artifacts)
- The TMP asmdef collision is **gone**.
- Still zero shader errors, still no crash.

`buildplayer-battle.unity` opens identically; the skybox + grid render the
same as in the BEFORE run.

## Why the shaders look like a problem but aren't (in 2019.4 LTS)

When a Unity build is produced, every shader is compiled to platform-specific
GPU bytecode (GLSL ES for Android, DXBC for Windows, etc.). The original
HLSL/CG source is **discarded** at build time. AssetRipper can recover:

- the shader's `Properties { … }` block (so materials still resolve their
  `_MainTex`, `_Color`, etc.),
- the shader's name (so the GUID lookup from `.mat` files still works),
- a `Fallback "…"` line if one was declared,

but it cannot recover the original vertex/fragment program. It writes a
placeholder `SubShader { … }` annotated with `// DummyShaderTextExporter` and
a generic surface-shader stub that **may or may not compile** depending on
which `#pragma` directives Unity's current shader compiler accepts.

Outcomes you might see, in increasing order of severity:

1. Stub compiles → material renders with a generic Standard look (often
   close enough). This was the actual outcome in 2019.4.40f1 Linux.
2. Stub fails to compile → material renders pink, an error appears in the
   Console. (Common on Windows Editor.)
3. Stub fails to compile **and** the Editor's shader-error path is buggy on
   the current platform → Editor aborts. Reportedly happens on the
   experimental Linux Editor of 2018.3.x.

The `tools/fix-dummy-shaders.py` script preempts all three by replacing the
stub body with nothing but a `Fallback` to a known-working built-in shader.
Unity's renderer follows that fallback chain when no `SubShader` compiles, so
you never go down path 2 or 3.

## What the fix scripts do

### `tools/fix-dummy-shaders.py`

Walks `Assets/`, finds every `.shader` containing `// DummyShaderTextExporter`,
and rewrites it to the minimal valid form:

```
Shader "<original/name>" {
    <preserved Properties block>
    Fallback "<chosen built-in>"
}
```

Heuristic for picking the built-in (first match wins):

| Shader name pattern | Fallback |
| --- | --- |
| `…Particles…Additive…` | `Particles/Additive` |
| `…Particles…AlphaBlended…` | `Particles/Alpha Blended` |
| `…Particles…Multiply…` | `Particles/Multiply` |
| `…Particles…` (default) | `Particles/Alpha Blended` |
| `UI/…`, `Sprites/Default` | `UI/Default` |
| `TMP_*`, `TextMeshPro` | `TextMeshPro/Distance Field` |
| `Skybox/…` | `Skybox/Procedural` |
| `*Water*`, `*Reflective*` | `Mobile/Diffuse` |
| `Hidden/…`, `Bloom`, `Blur`, `Outline`, `Glow`, `Distort`, post-process | `Hidden/InternalErrorShader` |
| `Grass`, `Tree`, `Leaves` | `Mobile/Diffuse` |
| `*BumpMap*`, `*Normal*` | `Mobile/Bumped Diffuse` |
| `Shader Forge/…` | `Standard` |
| anything else | `Mobile/Diffuse` |

Run with `--dry-run` to preview without writing.

### `tools/fix-decompiled-conflicts.py`

AssetRipper extracts every assembly the build referenced, including ones that
ship with Unity itself as Packages. The decompiled copies and the Package
copies have the same `.asmdef` name, which Unity rejects with
`Assembly with name 'X' already exists`.

This script removes the decompiled directories that are guaranteed to be
provided by `Packages/manifest.json`:

- `Assets/MonoScript/Unity.TextMeshPro/` — `com.unity.textmeshpro`
- `Assets/MonoScript/Unity.Analytics.DataPrivacy/` — `com.unity.modules.unityanalytics`

DOTween is intentionally **not** removed: Unity ships no built-in DOTween,
the gameplay code (Assembly-CSharp) heavily references it, and the few
remaining decompile errors are in advanced extension methods (Blendable,
SetSpecialStartupMode) that only fail at use-site, not at load.

## Known not-fixed issues

These are not shader related and out of scope for this pass:

1. **DOTween43 / DOTween46 extension methods** — 5–10 errors in
   `ShortcutExtensions{43,46}.cs` referencing internals that ILSpy could not
   decompile. To fully resolve, replace the decompiled DOTween with the
   official DOTween package from the Asset Store (or the free version).
2. **`Component at index 3 could not be loaded when loading game object 'm_camera'`** —
   prefab references a script that is not currently compiling. Will resolve
   once Assembly-CSharp.dll builds cleanly (i.e. after fixing #1).
3. **GUID collisions on `Smoke.png` / `smoke_X.png`** — AssetRipper assigned
   conflicting GUIDs to case-different files. Cosmetic; one wins, the others
   are ignored.
4. **No real network backend** — the game's `gs.*.scmsg` server is not
   recoverable from the client; multiplayer/online features will not work
   regardless of any client-side fix.
5. **Native Android plugins** (`libfirebase`, `libBilling`, etc.) are not
   loadable on a desktop target; Editor logs `DllNotFoundException` for them
   when scripts try to call into them.

## Reproducibility

```sh
# 1. Reconstruct from xapk (uses tools/restore-unity-mono if you don't already
#    have ar_output/ExportedProject).
# 2. Apply fixes:
python3 tools/fix-dummy-shaders.py path/to/ExportedProject
python3 tools/fix-decompiled-conflicts.py path/to/ExportedProject

# 3. Open in Unity 2019.4 LTS or newer.
```

Both scripts are idempotent.
