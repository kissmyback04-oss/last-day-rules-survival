# Last Day Rules Survival — Reconstructed Unity Project (1.0 / version_code 8)

Reconstructed from `last-day-rules-survival-1-0.xapk` (build 1.0, version_code 8, dated 2019-03-21 inside the .obb).

- Unity version: **2018.3.8f1** (Mono backend — `.NET` assemblies, not IL2CPP)
- Package: `com.herogame.gplay.lastdayrulessurvival`
- Company: hero / Product: lastdayrulessurvival

## Pipeline used

1. `unzip` xapk → `apk` + `obb`
2. `unzip` apk → `assets/bin/Data/` (Mono managed DLLs + main Unity data: `globalgamemanagers`, `level0`, `sharedassets*.assets`)
3. `unzip` obb → `assets/{scene,effect,ui,...}/*.ab` (Unity AssetBundles)
4. Patch a small subset of `.ab` files whose internal Unity version was `2018.3.7f1` → `2018.3.8f1` (10-byte ASCII swap, identical length)
5. Run **AssetRipper** (`AssetRipperConsole 0.2.1.1`) on the combined Data folder
6. Output: this `ExportedProject/` directory — a real Unity 2018.3.8f1 project that opens in the editor

## Contents

- `Assets/Scene/buildplayer-*.unity` — extracted gameplay scenes (~229 unique scenes)
- `Assets/MonoScript/Assembly-CSharp/` — decompiled main game scripts (1684 `.cs` files, full original namespaces: `SC`, `SC.UI`, `gs.battle.*`, `gs.bag.*`, `cfg`, `Net`, `Share`, `online`, `auth.msg`)
- `Assets/MonoScript/Assembly-CSharp-firstpass/` — Plugins-tier scripts (97 `.cs` files)
- `Assets/MonoScript/{DOTween,DOTween43,DOTween46,DOTween50}/` — DOTween library
- `Assets/MonoScript/Unity.TextMeshPro/` — TextMeshPro
- `Assets/MonoScript/Unity.Analytics.DataPrivacy/` — Analytics privacy module
- `Assets/Material/` — 3034 materials
- `Assets/Mesh/` — 2368 meshes
- `Assets/Texture2D/` — 4238 textures
- `Assets/Sprite/` — 592 sprites
- `Assets/AnimationClip/` — 1448 animation clips
- `Assets/AnimatorController/` — 112 animator controllers
- `Assets/Avatar/` — 84 humanoid avatars
- `Assets/Shader/` — 56 shaders
- `Assets/ComputeShader/` — 4 compute shaders
- `Assets/Cubemap/`, `Assets/PhysicMaterial/`, `Assets/Flare/`, `Assets/LightProbes/`
- `Assets/Asset_Bundles/{effect,sound,ui,scene,texture,part,...}/` — 1901 extracted asset bundles
- `ProjectSettings/` — full project settings (input, physics, quality, tags, layers, audio, graphics, …)

## How to open

1. Install **Unity 2018.3.8f1** via Unity Hub (legacy version, available from Unity download archive)
2. Open this `ExportedProject/` folder in Unity Hub → "Open project"
3. Let Unity import / regenerate Library/ on first open (will take a long while because of asset count)

## Caveats — what will NOT just work

This is a real reconstructed Unity project. Code and assets are real. But:

1. **Shaders** — many built-in / mobile shaders are reconstructed from binary `.shader.meta` references. Some will have broken `#pragma` directives or missing variants. Expect pink materials in scenes; you'll need to re-pick equivalent built-in shaders or fix individual shaders by hand.
2. **Native plugins** (`assets/lib/*.so` from the apk) are NOT bundled here. Anything calling native code via `[DllImport]` (e.g. `libil2cpp` is irrelevant since this is Mono, but Firebase, Google billing, custom networking native libs may be referenced) will throw `DllNotFoundException` at runtime.
3. **Networking** — this is an online game. The game client expects a backend at the company's server endpoints (visible in `Net.*`, `gs.*.scmsg` namespaces). Without the server, you'll get past login screens at most. There is no "offline mode" to restore.
4. **Resource files** — Unity packs some shaders/textures into `globalgamemanagers.assets` and `*.resource` files. AssetRipper extracts most of these, but binary shader variants may not round-trip perfectly.
5. **Scripts compile errors** — decompiled C# is logically correct but may not always type-check. Common issues: anonymous types, unsupported `unsafe` blocks, compiler-generated names. Fix iteratively in Unity's console.

This is the realistic baseline: you have the **logic + content** in editable form. Making it actually playable requires manual finishing work specific to this game.
