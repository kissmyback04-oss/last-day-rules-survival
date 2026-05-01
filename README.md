# last-day-rules-survival

Reconstructed Unity 2018.3.8f1 project from `last-day-rules-survival 1.0` (xapk, version_code 8, build dated 2019-03-21).

This repo holds two things:
- `tools/` — a reusable toolchain (`restore-unity-mono.sh`) that takes any Mono-backend Unity 2018-era APK/XAPK and reconstructs an editable Unity project from it
- `ExportedProject/` — the reconstructed project itself: scripts, scenes, shaders, project settings (the **code half** of the game)

The heavy binary assets (textures, meshes, animations, materials, sprites, audio) are too large for the git repo. They live in **GitHub Releases** as a separate archive — see Releases tab.

## What you can do with this

- Read the original C# (1684 scripts in `Assembly-CSharp`, 97 in `Assembly-CSharp-firstpass`, plus DOTween, TextMeshPro, EasyBuildSystem, Mesh Baker, UnityStandardAssets) — full namespaces and class names preserved because the build is **Mono backend**, not IL2CPP, and not obfuscated
- Open the project in **Unity 2018.3.8f1** (install from Unity download archive) and inspect / modify scenes, prefabs, monobehaviours
- Reproduce the extraction yourself for any other Mono Unity 2018-era game with `tools/restore-unity-mono.sh`

## What you cannot do

- This is an online game — there is no server side here. Without the original `gs.*.scmsg` backend, the client gets to login screens at most.
- This is **not** a "remove monetization mod" — it's a reconstruction of the existing build. The `RechargeMgr`, `ShoppingPanel`, `ShopEvent` classes are visible and editable, but the game's monetization is fundamentally tied to its server.
- Some shaders will render as pink in the editor. Built-in mobile shaders need to be re-bound by hand.
- Native plugins (`.so` files referenced via `[DllImport]`) are not bundled — anything that depends on them throws `DllNotFoundException` at runtime.

## Repo layout

```
.
├── README.md              # this file
├── LICENSE                # MIT (toolchain only; game content remains property of original authors)
├── .gitignore
├── tools/
│   ├── README.md
│   ├── restore-unity-mono.sh
│   └── setup.sh
└── ExportedProject/
    ├── README.md          # detailed pipeline + caveats
    ├── ProjectSettings/   # Unity 2018.3.8f1 project settings
    └── Assets/
        ├── MonoScript/    # decompiled C# (Assembly-CSharp, Assembly-CSharp-firstpass, DOTween, TMP, etc.)
        ├── Scene/         # ~229 buildplayer-*.unity scenes
        ├── Shader/        # 56 shaders
        └── ComputeShader/ # 4 compute shaders
```

To make the project actually openable in Unity, you also need the binary assets archive (~430 MB compressed) from the latest Release. Extract it on top of `ExportedProject/` so the missing `Material/`, `Mesh/`, `Texture2D/`, `Sprite/`, `AnimationClip/`, `AnimatorController/`, `Avatar/`, `Asset_Bundles/`, etc. directories appear under `ExportedProject/Assets/`.

## How the reconstruction was done

1. `unzip` xapk → apk + obb
2. `unzip` apk → `assets/bin/Data/` (Mono managed DLLs, `globalgamemanagers`, `level0`, `sharedassets*.assets`)
3. `unzip` obb → `assets/{scene,effect,ui,...}/*.ab`
4. Detect Unity version from `globalgamemanagers` header → `2018.3.8f1`
5. Patch the small subset of `.ab` files reporting `2018.3.7f1` → `2018.3.8f1` (same-length ASCII swap; AssetRipper otherwise treats them as a separate, incompatible collection)
6. Run `AssetRipperConsole 0.2.1.1` on the combined Data folder
7. (Optional) Re-decompile via `ilspycmd 8.2.0.7535` for a parallel reference C# dump

Run `./tools/setup.sh && ./tools/restore-unity-mono.sh path/to/some.xapk ./out` to repeat the process for another game.

## License

The toolchain code under `tools/` is MIT.

`ExportedProject/` is **derived from a third-party game**. It is included here for personal study, archival, and modding research only. All game content remains the copyright of HeroGame / 网易 (Net Easy Games). Do not redistribute commercially. If the rights-holder objects, this content will be taken down.
