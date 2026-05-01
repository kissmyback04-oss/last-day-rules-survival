using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.CustomPlugins;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public static class ShortcutExtensions
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public AudioSource target;

			internal float _003CDOFade_003Eb__0()
			{
				return target.volume;
			}

			internal void _003CDOFade_003Eb__1(float x)
			{
				target.volume = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public AudioSource target;

			internal float _003CDOPitch_003Eb__0()
			{
				return target.pitch;
			}

			internal void _003CDOPitch_003Eb__1(float x)
			{
				target.pitch = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Camera target;

			internal float _003CDOAspect_003Eb__0()
			{
				return target.aspect;
			}

			internal void _003CDOAspect_003Eb__1(float x)
			{
				target.aspect = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Camera target;

			internal Color _003CDOColor_003Eb__0()
			{
				return target.backgroundColor;
			}

			internal void _003CDOColor_003Eb__1(Color x)
			{
				target.backgroundColor = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Camera target;

			internal float _003CDOFarClipPlane_003Eb__0()
			{
				return target.farClipPlane;
			}

			internal void _003CDOFarClipPlane_003Eb__1(float x)
			{
				target.farClipPlane = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Camera target;

			internal float _003CDOFieldOfView_003Eb__0()
			{
				return target.fieldOfView;
			}

			internal void _003CDOFieldOfView_003Eb__1(float x)
			{
				target.fieldOfView = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Camera target;

			internal float _003CDONearClipPlane_003Eb__0()
			{
				return target.nearClipPlane;
			}

			internal void _003CDONearClipPlane_003Eb__1(float x)
			{
				target.nearClipPlane = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public Camera target;

			internal float _003CDOOrthoSize_003Eb__0()
			{
				return target.orthographicSize;
			}

			internal void _003CDOOrthoSize_003Eb__1(float x)
			{
				target.orthographicSize = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Camera target;

			internal Rect _003CDOPixelRect_003Eb__0()
			{
				return target.pixelRect;
			}

			internal void _003CDOPixelRect_003Eb__1(Rect x)
			{
				target.pixelRect = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Camera target;

			internal Rect _003CDORect_003Eb__0()
			{
				return target.rect;
			}

			internal void _003CDORect_003Eb__1(Rect x)
			{
				target.rect = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Camera target;

			internal Vector3 _003CDOShakePosition_003Eb__0()
			{
				return target.transform.localPosition;
			}

			internal void _003CDOShakePosition_003Eb__1(Vector3 x)
			{
				target.transform.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public Camera target;

			internal Vector3 _003CDOShakePosition_003Eb__0()
			{
				return target.transform.localPosition;
			}

			internal void _003CDOShakePosition_003Eb__1(Vector3 x)
			{
				target.transform.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public Camera target;

			internal Vector3 _003CDOShakeRotation_003Eb__0()
			{
				return target.transform.localEulerAngles;
			}

			internal void _003CDOShakeRotation_003Eb__1(Vector3 x)
			{
				target.transform.localRotation = Quaternion.Euler(x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public Camera target;

			internal Vector3 _003CDOShakeRotation_003Eb__0()
			{
				return target.transform.localEulerAngles;
			}

			internal void _003CDOShakeRotation_003Eb__1(Vector3 x)
			{
				target.transform.localRotation = Quaternion.Euler(x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public Light target;

			internal Color _003CDOColor_003Eb__0()
			{
				return target.color;
			}

			internal void _003CDOColor_003Eb__1(Color x)
			{
				target.color = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			public Light target;

			internal float _003CDOIntensity_003Eb__0()
			{
				return target.intensity;
			}

			internal void _003CDOIntensity_003Eb__1(float x)
			{
				target.intensity = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public Light target;

			internal float _003CDOShadowStrength_003Eb__0()
			{
				return target.shadowStrength;
			}

			internal void _003CDOShadowStrength_003Eb__1(float x)
			{
				target.shadowStrength = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public Color2 startValue;

			public LineRenderer target;

			internal Color2 _003CDOColor_003Eb__0()
			{
				return startValue;
			}

			internal void _003CDOColor_003Eb__1(Color2 x)
			{
				target.SetColors(x.ca, x.cb);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public Material target;

			internal Color _003CDOColor_003Eb__0()
			{
				return target.color;
			}

			internal void _003CDOColor_003Eb__1(Color x)
			{
				target.color = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			public Material target;

			public string property;

			internal Color _003CDOColor_003Eb__0()
			{
				return target.GetColor(property);
			}

			internal void _003CDOColor_003Eb__1(Color x)
			{
				target.SetColor(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public Material target;

			internal Color _003CDOFade_003Eb__0()
			{
				return target.color;
			}

			internal void _003CDOFade_003Eb__1(Color x)
			{
				target.color = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public Material target;

			public string property;

			internal Color _003CDOFade_003Eb__0()
			{
				return target.GetColor(property);
			}

			internal void _003CDOFade_003Eb__1(Color x)
			{
				target.SetColor(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public Material target;

			public string property;

			internal float _003CDOFloat_003Eb__0()
			{
				return target.GetFloat(property);
			}

			internal void _003CDOFloat_003Eb__1(float x)
			{
				target.SetFloat(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public Material target;

			internal Vector2 _003CDOOffset_003Eb__0()
			{
				return target.mainTextureOffset;
			}

			internal void _003CDOOffset_003Eb__1(Vector2 x)
			{
				target.mainTextureOffset = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public Material target;

			public string property;

			internal Vector2 _003CDOOffset_003Eb__0()
			{
				return target.GetTextureOffset(property);
			}

			internal void _003CDOOffset_003Eb__1(Vector2 x)
			{
				target.SetTextureOffset(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public Material target;

			internal Vector2 _003CDOTiling_003Eb__0()
			{
				return target.mainTextureScale;
			}

			internal void _003CDOTiling_003Eb__1(Vector2 x)
			{
				target.mainTextureScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public Material target;

			public string property;

			internal Vector2 _003CDOTiling_003Eb__0()
			{
				return target.GetTextureScale(property);
			}

			internal void _003CDOTiling_003Eb__1(Vector2 x)
			{
				target.SetTextureScale(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public Material target;

			public string property;

			internal Vector4 _003CDOVector_003Eb__0()
			{
				return target.GetVector(property);
			}

			internal void _003CDOVector_003Eb__1(Vector4 x)
			{
				target.SetVector(property, x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMove_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveX_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveY_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveZ_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			public Rigidbody target;

			internal Quaternion _003CDORotate_003Eb__0()
			{
				return target.rotation;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public Rigidbody target;

			internal Quaternion _003CDOLookAt_003Eb__0()
			{
				return target.rotation;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public Rigidbody target;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector3 endValue;

			public float startPosY;

			internal Vector3 _003CDOJump_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__1()
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 position = target.position;
				position.y += DOVirtual.EasedValue(0f, offsetY, s.ElapsedDirectionalPercentage(), Ease.OutQuad);
				target.MovePosition(position);
			}

			internal Vector3 _003CDOJump_003Eb__2()
			{
				return target.position;
			}

			internal Vector3 _003CDOJump_003Eb__3()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			public Transform trans;

			public Rigidbody target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return trans.localPosition;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			public Transform trans;

			public Rigidbody target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return trans.localPosition;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
				target.MovePosition((trans.parent == null) ? x : trans.parent.TransformPoint(x));
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_0
		{
			public TrailRenderer target;

			internal Vector2 _003CDOResize_003Eb__0()
			{
				return new Vector2(target.startWidth, target.endWidth);
			}

			internal void _003CDOResize_003Eb__1(Vector2 x)
			{
				target.startWidth = x.x;
				target.endWidth = x.y;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public TrailRenderer target;

			internal float _003CDOTime_003Eb__0()
			{
				return target.time;
			}

			internal void _003CDOTime_003Eb__1(float x)
			{
				target.time = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public Transform target;

			internal Vector3 _003CDOMove_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOMove_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			public Transform target;

			internal Vector3 _003CDOMoveX_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOMoveX_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			public Transform target;

			internal Vector3 _003CDOMoveY_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOMoveY_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass44_0
		{
			public Transform target;

			internal Vector3 _003CDOMoveZ_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOMoveZ_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass45_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalMove_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalMove_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass46_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalMoveX_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalMoveX_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalMoveY_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalMoveY_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalMoveZ_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalMoveZ_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass49_0
		{
			public Transform target;

			internal Quaternion _003CDORotate_003Eb__0()
			{
				return target.rotation;
			}

			internal void _003CDORotate_003Eb__1(Quaternion x)
			{
				target.rotation = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass50_0
		{
			public Transform target;

			internal Quaternion _003CDORotateQuaternion_003Eb__0()
			{
				return target.rotation;
			}

			internal void _003CDORotateQuaternion_003Eb__1(Quaternion x)
			{
				target.rotation = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass51_0
		{
			public Transform target;

			internal Quaternion _003CDOLocalRotate_003Eb__0()
			{
				return target.localRotation;
			}

			internal void _003CDOLocalRotate_003Eb__1(Quaternion x)
			{
				target.localRotation = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			public Transform target;

			internal Quaternion _003CDOLocalRotateQuaternion_003Eb__0()
			{
				return target.localRotation;
			}

			internal void _003CDOLocalRotateQuaternion_003Eb__1(Quaternion x)
			{
				target.localRotation = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass53_0
		{
			public Transform target;

			internal Vector3 _003CDOScale_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOScale_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass54_0
		{
			public Transform target;

			internal Vector3 _003CDOScale_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOScale_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			public Transform target;

			internal Vector3 _003CDOScaleX_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOScaleX_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass56_0
		{
			public Transform target;

			internal Vector3 _003CDOScaleY_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOScaleY_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public Transform target;

			internal Vector3 _003CDOScaleZ_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOScaleZ_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass58_0
		{
			public Transform target;

			internal Quaternion _003CDOLookAt_003Eb__0()
			{
				return target.rotation;
			}

			internal void _003CDOLookAt_003Eb__1(Quaternion x)
			{
				target.rotation = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass59_0
		{
			public Transform target;

			internal Vector3 _003CDOPunchPosition_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOPunchPosition_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			public Transform target;

			internal Vector3 _003CDOPunchScale_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOPunchScale_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass61_0
		{
			public Transform target;

			internal Vector3 _003CDOPunchRotation_003Eb__0()
			{
				return target.localEulerAngles;
			}

			internal void _003CDOPunchRotation_003Eb__1(Vector3 x)
			{
				target.localRotation = Quaternion.Euler(x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass62_0
		{
			public Transform target;

			internal Vector3 _003CDOShakePosition_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOShakePosition_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass63_0
		{
			public Transform target;

			internal Vector3 _003CDOShakePosition_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOShakePosition_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			public Transform target;

			internal Vector3 _003CDOShakeRotation_003Eb__0()
			{
				return target.localEulerAngles;
			}

			internal void _003CDOShakeRotation_003Eb__1(Vector3 x)
			{
				target.localRotation = Quaternion.Euler(x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass65_0
		{
			public Transform target;

			internal Vector3 _003CDOShakeRotation_003Eb__0()
			{
				return target.localEulerAngles;
			}

			internal void _003CDOShakeRotation_003Eb__1(Vector3 x)
			{
				target.localRotation = Quaternion.Euler(x);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass66_0
		{
			public Transform target;

			internal Vector3 _003CDOShakeScale_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOShakeScale_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass67_0
		{
			public Transform target;

			internal Vector3 _003CDOShakeScale_003Eb__0()
			{
				return target.localScale;
			}

			internal void _003CDOShakeScale_003Eb__1(Vector3 x)
			{
				target.localScale = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass68_0
		{
			public Transform target;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector3 endValue;

			public float startPosY;

			internal Vector3 _003CDOJump_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__1(Vector3 x)
			{
				target.position = x;
			}

			internal void _003CDOJump_003Eb__2()
			{
				if (!offsetYSet)
				{
					offsetYSet = true;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 position = target.position;
				position.y += DOVirtual.EasedValue(0f, offsetY, s.ElapsedDirectionalPercentage(), Ease.OutQuad);
				target.position = position;
			}

			internal Vector3 _003CDOJump_003Eb__3()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__4(Vector3 x)
			{
				target.position = x;
			}

			internal Vector3 _003CDOJump_003Eb__5()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__6(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass69_0
		{
			public Transform target;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector3 endValue;

			public float startPosY;

			internal Vector3 _003CDOLocalJump_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalJump_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}

			internal void _003CDOLocalJump_003Eb__2()
			{
				if (!offsetYSet)
				{
					offsetYSet = false;
					offsetY = (s.isRelative ? endValue.y : (endValue.y - startPosY));
				}
				Vector3 localPosition = target.localPosition;
				localPosition.y += DOVirtual.EasedValue(0f, offsetY, s.ElapsedDirectionalPercentage(), Ease.OutQuad);
				target.localPosition = localPosition;
			}

			internal Vector3 _003CDOLocalJump_003Eb__3()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalJump_003Eb__4(Vector3 x)
			{
				target.localPosition = x;
			}

			internal Vector3 _003CDOLocalJump_003Eb__5()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalJump_003Eb__6(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass70_0
		{
			public Transform target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOPath_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass71_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass72_0
		{
			public Transform target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOPath_003Eb__1(Vector3 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass73_0
		{
			public Transform target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return target.localPosition;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
				target.localPosition = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass74_0
		{
			public Color to;

			public Light target;

			internal Color _003CDOBlendableColor_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableColor_003Eb__1(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass75_0
		{
			public Color to;

			public Material target;

			internal Color _003CDOBlendableColor_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableColor_003Eb__1(Color x)
			{
				Color color = x - to;
				to = x;
				target.color += color;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass76_0
		{
			public Color to;

			public Material target;

			public string property;

			internal Color _003CDOBlendableColor_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableColor_003Eb__1(Color x)
			{
				Color color = x - to;
				to = x;
				target.SetColor(property, target.GetColor(property) + color);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass77_0
		{
			public Vector3 to;

			public Transform target;

			internal Vector3 _003CDOBlendableMoveBy_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableMoveBy_003Eb__1(Vector3 x)
			{
				Vector3 vector = x - to;
				to = x;
				target.position += vector;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass78_0
		{
			public Vector3 to;

			public Transform target;

			internal Vector3 _003CDOBlendableLocalMoveBy_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableLocalMoveBy_003Eb__1(Vector3 x)
			{
				Vector3 vector = x - to;
				to = x;
				target.localPosition += vector;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass79_0
		{
			public Quaternion to;

			public Transform target;

			internal Quaternion _003CDOBlendableRotateBy_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableRotateBy_003Eb__1(Quaternion x)
			{
				Quaternion quaternion = x * Quaternion.Inverse(to);
				to = x;
				target.rotation = target.rotation * Quaternion.Inverse(target.rotation) * quaternion * target.rotation;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass80_0
		{
			public Quaternion to;

			public Transform target;

			internal Quaternion _003CDOBlendableLocalRotateBy_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableLocalRotateBy_003Eb__1(Quaternion x)
			{
				Quaternion quaternion = x * Quaternion.Inverse(to);
				to = x;
				target.localRotation = target.localRotation * Quaternion.Inverse(target.localRotation) * quaternion * target.localRotation;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass81_0
		{
			public Vector3 to;

			public Transform target;

			internal Vector3 _003CDOBlendableScaleBy_003Eb__0()
			{
				return to;
			}

			internal void _003CDOBlendableScaleBy_003Eb__1(Vector3 x)
			{
				Vector3 vector = x - to;
				to = x;
				target.localScale += vector;
			}
		}

		public static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			_003C_003Ec__DisplayClass0_.target = target;
			if (endValue < 0f)
			{
				endValue = 0f;
			}
			else if (endValue > 1f)
			{
				endValue = 1f;
			}
			return DOTween.To(_003C_003Ec__DisplayClass0_._003CDOFade_003Eb__0, _003C_003Ec__DisplayClass0_._003CDOFade_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass0_.target);
		}

		public static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
			_003C_003Ec__DisplayClass1_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass1_._003CDOPitch_003Eb__0, _003C_003Ec__DisplayClass1_._003CDOPitch_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass1_.target);
		}

		public static Tweener DOAspect(this Camera target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass2_._003CDOAspect_003Eb__0, _003C_003Ec__DisplayClass2_._003CDOAspect_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass2_.target);
		}

		public static Tweener DOColor(this Camera target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass3_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass3_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass3_.target);
		}

		public static Tweener DOFarClipPlane(this Camera target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
			_003C_003Ec__DisplayClass4_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass4_._003CDOFarClipPlane_003Eb__0, _003C_003Ec__DisplayClass4_._003CDOFarClipPlane_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass4_.target);
		}

		public static Tweener DOFieldOfView(this Camera target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass5_._003CDOFieldOfView_003Eb__0, _003C_003Ec__DisplayClass5_._003CDOFieldOfView_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass5_.target);
		}

		public static Tweener DONearClipPlane(this Camera target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass6_._003CDONearClipPlane_003Eb__0, _003C_003Ec__DisplayClass6_._003CDONearClipPlane_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass6_.target);
		}

		public static Tweener DOOrthoSize(this Camera target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
			_003C_003Ec__DisplayClass7_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass7_._003CDOOrthoSize_003Eb__0, _003C_003Ec__DisplayClass7_._003CDOOrthoSize_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass7_.target);
		}

		public static Tweener DOPixelRect(this Camera target, Rect endValue, float duration)
		{
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
			_003C_003Ec__DisplayClass8_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass8_._003CDOPixelRect_003Eb__0, _003C_003Ec__DisplayClass8_._003CDOPixelRect_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass8_.target);
		}

		public static Tweener DORect(this Camera target, Rect endValue, float duration)
		{
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
			_003C_003Ec__DisplayClass9_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass9_._003CDORect_003Eb__0, _003C_003Ec__DisplayClass9_._003CDORect_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass9_.target);
		}

		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
			_003C_003Ec__DisplayClass10_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass10_._003CDOShakePosition_003Eb__0, _003C_003Ec__DisplayClass10_._003CDOShakePosition_003Eb__1, duration, strength, vibrato, randomness, true, fadeOut).SetTarget(_003C_003Ec__DisplayClass10_.target).SetSpecialStartupMode(SpecialStartupMode.SetCameraShakePosition);
		}

		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
			_003C_003Ec__DisplayClass11_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass11_._003CDOShakePosition_003Eb__0, _003C_003Ec__DisplayClass11_._003CDOShakePosition_003Eb__1, duration, strength, vibrato, randomness, fadeOut).SetTarget(_003C_003Ec__DisplayClass11_.target).SetSpecialStartupMode(SpecialStartupMode.SetCameraShakePosition);
		}

		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			_003C_003Ec__DisplayClass12_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass12_._003CDOShakeRotation_003Eb__0, _003C_003Ec__DisplayClass12_._003CDOShakeRotation_003Eb__1, duration, strength, vibrato, randomness, false, fadeOut).SetTarget(_003C_003Ec__DisplayClass12_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
			_003C_003Ec__DisplayClass13_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass13_._003CDOShakeRotation_003Eb__0, _003C_003Ec__DisplayClass13_._003CDOShakeRotation_003Eb__1, duration, strength, vibrato, randomness, fadeOut).SetTarget(_003C_003Ec__DisplayClass13_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Tweener DOColor(this Light target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
			_003C_003Ec__DisplayClass14_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass14_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass14_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass14_.target);
		}

		public static Tweener DOIntensity(this Light target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
			_003C_003Ec__DisplayClass15_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass15_._003CDOIntensity_003Eb__0, _003C_003Ec__DisplayClass15_._003CDOIntensity_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass15_.target);
		}

		public static Tweener DOShadowStrength(this Light target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
			_003C_003Ec__DisplayClass16_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass16_._003CDOShadowStrength_003Eb__0, _003C_003Ec__DisplayClass16_._003CDOShadowStrength_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass16_.target);
		}

		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
			_003C_003Ec__DisplayClass17_.startValue = startValue;
			_003C_003Ec__DisplayClass17_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass17_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass17_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass17_.target);
		}

		public static Tweener DOColor(this Material target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
			_003C_003Ec__DisplayClass18_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass18_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass18_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass18_.target);
		}

		public static Tweener DOColor(this Material target, Color endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
			_003C_003Ec__DisplayClass19_.target = target;
			_003C_003Ec__DisplayClass19_.property = property;
			if (!_003C_003Ec__DisplayClass19_.target.HasProperty(_003C_003Ec__DisplayClass19_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass19_.property);
				}
				return null;
			}
			return DOTween.To(_003C_003Ec__DisplayClass19_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass19_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass19_.target);
		}

		public static Tweener DOFade(this Material target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
			_003C_003Ec__DisplayClass20_.target = target;
			return DOTween.ToAlpha(_003C_003Ec__DisplayClass20_._003CDOFade_003Eb__0, _003C_003Ec__DisplayClass20_._003CDOFade_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass20_.target);
		}

		public static Tweener DOFade(this Material target, float endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
			_003C_003Ec__DisplayClass21_.target = target;
			_003C_003Ec__DisplayClass21_.property = property;
			if (!_003C_003Ec__DisplayClass21_.target.HasProperty(_003C_003Ec__DisplayClass21_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass21_.property);
				}
				return null;
			}
			return DOTween.ToAlpha(_003C_003Ec__DisplayClass21_._003CDOFade_003Eb__0, _003C_003Ec__DisplayClass21_._003CDOFade_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass21_.target);
		}

		public static Tweener DOFloat(this Material target, float endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
			_003C_003Ec__DisplayClass22_.target = target;
			_003C_003Ec__DisplayClass22_.property = property;
			if (!_003C_003Ec__DisplayClass22_.target.HasProperty(_003C_003Ec__DisplayClass22_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass22_.property);
				}
				return null;
			}
			return DOTween.To(_003C_003Ec__DisplayClass22_._003CDOFloat_003Eb__0, _003C_003Ec__DisplayClass22_._003CDOFloat_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass22_.target);
		}

		public static Tweener DOOffset(this Material target, Vector2 endValue, float duration)
		{
			_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
			_003C_003Ec__DisplayClass23_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass23_._003CDOOffset_003Eb__0, _003C_003Ec__DisplayClass23_._003CDOOffset_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass23_.target);
		}

		public static Tweener DOOffset(this Material target, Vector2 endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
			_003C_003Ec__DisplayClass24_.target = target;
			_003C_003Ec__DisplayClass24_.property = property;
			if (!_003C_003Ec__DisplayClass24_.target.HasProperty(_003C_003Ec__DisplayClass24_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass24_.property);
				}
				return null;
			}
			return DOTween.To(_003C_003Ec__DisplayClass24_._003CDOOffset_003Eb__0, _003C_003Ec__DisplayClass24_._003CDOOffset_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass24_.target);
		}

		public static Tweener DOTiling(this Material target, Vector2 endValue, float duration)
		{
			_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
			_003C_003Ec__DisplayClass25_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass25_._003CDOTiling_003Eb__0, _003C_003Ec__DisplayClass25_._003CDOTiling_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass25_.target);
		}

		public static Tweener DOTiling(this Material target, Vector2 endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
			_003C_003Ec__DisplayClass26_.target = target;
			_003C_003Ec__DisplayClass26_.property = property;
			if (!_003C_003Ec__DisplayClass26_.target.HasProperty(_003C_003Ec__DisplayClass26_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass26_.property);
				}
				return null;
			}
			return DOTween.To(_003C_003Ec__DisplayClass26_._003CDOTiling_003Eb__0, _003C_003Ec__DisplayClass26_._003CDOTiling_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass26_.target);
		}

		public static Tweener DOVector(this Material target, Vector4 endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
			_003C_003Ec__DisplayClass27_.target = target;
			_003C_003Ec__DisplayClass27_.property = property;
			if (!_003C_003Ec__DisplayClass27_.target.HasProperty(_003C_003Ec__DisplayClass27_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass27_.property);
				}
				return null;
			}
			return DOTween.To(_003C_003Ec__DisplayClass27_._003CDOVector_003Eb__0, _003C_003Ec__DisplayClass27_._003CDOVector_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass27_.target);
		}

		public static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
			_003C_003Ec__DisplayClass28_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass28_._003CDOMove_003Eb__0, _003C_003Ec__DisplayClass28_.target.MovePosition, endValue, duration).SetOptions(snapping).SetTarget(_003C_003Ec__DisplayClass28_.target);
		}

		public static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
			_003C_003Ec__DisplayClass29_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass29_._003CDOMoveX_003Eb__0, _003C_003Ec__DisplayClass29_.target.MovePosition, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(_003C_003Ec__DisplayClass29_.target);
		}

		public static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
			_003C_003Ec__DisplayClass30_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass30_._003CDOMoveY_003Eb__0, _003C_003Ec__DisplayClass30_.target.MovePosition, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(_003C_003Ec__DisplayClass30_.target);
		}

		public static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
			_003C_003Ec__DisplayClass31_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass31_._003CDOMoveZ_003Eb__0, _003C_003Ec__DisplayClass31_.target.MovePosition, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z, snapping).SetTarget(_003C_003Ec__DisplayClass31_.target);
		}

		public static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
			_003C_003Ec__DisplayClass32_.target = target;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass32_._003CDORotate_003Eb__0, _003C_003Ec__DisplayClass32_.target.MoveRotation, endValue, duration);
			tweenerCore.SetTarget(_003C_003Ec__DisplayClass32_.target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
			_003C_003Ec__DisplayClass33_.target = target;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass33_._003CDOLookAt_003Eb__0, _003C_003Ec__DisplayClass33_.target.MoveRotation, towards, duration).SetTarget(_003C_003Ec__DisplayClass33_.target).SetSpecialStartupMode(SpecialStartupMode.SetLookAt);
			tweenerCore.plugOptions.axisConstraint = axisConstraint;
			tweenerCore.plugOptions.up = ((!up.HasValue) ? Vector3.up : up.Value);
			return tweenerCore;
		}

		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
			_003C_003Ec__DisplayClass34_.target = target;
			_003C_003Ec__DisplayClass34_.endValue = endValue;
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			_003C_003Ec__DisplayClass34_.startPosY = _003C_003Ec__DisplayClass34_.target.position.y;
			_003C_003Ec__DisplayClass34_.offsetY = -1f;
			_003C_003Ec__DisplayClass34_.offsetYSet = false;
			_003C_003Ec__DisplayClass34_.s = DOTween.Sequence();
			_003C_003Ec__DisplayClass34_.s.Append(DOTween.To(_003C_003Ec__DisplayClass34_._003CDOJump_003Eb__0, _003C_003Ec__DisplayClass34_.target.MovePosition, new Vector3(_003C_003Ec__DisplayClass34_.endValue.x, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)
				.OnUpdate(_003C_003Ec__DisplayClass34_._003CDOJump_003Eb__1)).Join(DOTween.To(_003C_003Ec__DisplayClass34_._003CDOJump_003Eb__2, _003C_003Ec__DisplayClass34_.target.MovePosition, new Vector3(0f, 0f, _003C_003Ec__DisplayClass34_.endValue.z), duration).SetOptions(AxisConstraint.Z, snapping).SetEase(Ease.Linear)).Join(DOTween.To(_003C_003Ec__DisplayClass34_._003CDOJump_003Eb__3, _003C_003Ec__DisplayClass34_.target.MovePosition, new Vector3(0f, jumpPower, 0f), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.SetRelative())
				.SetTarget(_003C_003Ec__DisplayClass34_.target)
				.SetEase(DOTween.defaultEaseType);
			return _003C_003Ec__DisplayClass34_.s;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
			_003C_003Ec__DisplayClass35_.target = target;
			if (resolution < 1)
			{
				resolution = 1;
			}
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass35_._003CDOPath_003Eb__0, _003C_003Ec__DisplayClass35_.target.MovePosition, new Path(pathType, path, resolution, gizmoColor), duration).SetTarget(_003C_003Ec__DisplayClass35_.target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
			_003C_003Ec__DisplayClass36_.target = target;
			if (resolution < 1)
			{
				resolution = 1;
			}
			_003C_003Ec__DisplayClass36_.trans = _003C_003Ec__DisplayClass36_.target.transform;
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass36_._003CDOLocalPath_003Eb__0, _003C_003Ec__DisplayClass36_._003CDOLocalPath_003Eb__1, new Path(pathType, path, resolution, gizmoColor), duration).SetTarget(_003C_003Ec__DisplayClass36_.target).SetUpdate(UpdateType.Fixed);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
			_003C_003Ec__DisplayClass37_.target = target;
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass37_._003CDOPath_003Eb__0, _003C_003Ec__DisplayClass37_.target.MovePosition, path, duration).SetTarget(_003C_003Ec__DisplayClass37_.target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
			_003C_003Ec__DisplayClass38_.target = target;
			_003C_003Ec__DisplayClass38_.trans = _003C_003Ec__DisplayClass38_.target.transform;
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass38_._003CDOLocalPath_003Eb__0, _003C_003Ec__DisplayClass38_._003CDOLocalPath_003Eb__1, path, duration).SetTarget(_003C_003Ec__DisplayClass38_.target);
			tweenerCore.plugOptions.isRigidbody = true;
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
			_003C_003Ec__DisplayClass39_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass39_._003CDOResize_003Eb__0, _003C_003Ec__DisplayClass39_._003CDOResize_003Eb__1, new Vector2(toStartWidth, toEndWidth), duration).SetTarget(_003C_003Ec__DisplayClass39_.target);
		}

		public static Tweener DOTime(this TrailRenderer target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
			_003C_003Ec__DisplayClass40_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass40_._003CDOTime_003Eb__0, _003C_003Ec__DisplayClass40_._003CDOTime_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass40_.target);
		}

		public static Tweener DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
			_003C_003Ec__DisplayClass41_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass41_._003CDOMove_003Eb__0, _003C_003Ec__DisplayClass41_._003CDOMove_003Eb__1, endValue, duration).SetOptions(snapping).SetTarget(_003C_003Ec__DisplayClass41_.target);
		}

		public static Tweener DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
			_003C_003Ec__DisplayClass42_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass42_._003CDOMoveX_003Eb__0, _003C_003Ec__DisplayClass42_._003CDOMoveX_003Eb__1, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(_003C_003Ec__DisplayClass42_.target);
		}

		public static Tweener DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
			_003C_003Ec__DisplayClass43_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass43_._003CDOMoveY_003Eb__0, _003C_003Ec__DisplayClass43_._003CDOMoveY_003Eb__1, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(_003C_003Ec__DisplayClass43_.target);
		}

		public static Tweener DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
			_003C_003Ec__DisplayClass44_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass44_._003CDOMoveZ_003Eb__0, _003C_003Ec__DisplayClass44_._003CDOMoveZ_003Eb__1, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z, snapping).SetTarget(_003C_003Ec__DisplayClass44_.target);
		}

		public static Tweener DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
			_003C_003Ec__DisplayClass45_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass45_._003CDOLocalMove_003Eb__0, _003C_003Ec__DisplayClass45_._003CDOLocalMove_003Eb__1, endValue, duration).SetOptions(snapping).SetTarget(_003C_003Ec__DisplayClass45_.target);
		}

		public static Tweener DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
			_003C_003Ec__DisplayClass46_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass46_._003CDOLocalMoveX_003Eb__0, _003C_003Ec__DisplayClass46_._003CDOLocalMoveX_003Eb__1, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(_003C_003Ec__DisplayClass46_.target);
		}

		public static Tweener DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
			_003C_003Ec__DisplayClass47_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass47_._003CDOLocalMoveY_003Eb__0, _003C_003Ec__DisplayClass47_._003CDOLocalMoveY_003Eb__1, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(_003C_003Ec__DisplayClass47_.target);
		}

		public static Tweener DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
			_003C_003Ec__DisplayClass48_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass48_._003CDOLocalMoveZ_003Eb__0, _003C_003Ec__DisplayClass48_._003CDOLocalMoveZ_003Eb__1, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z, snapping).SetTarget(_003C_003Ec__DisplayClass48_.target);
		}

		public static Tweener DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
			_003C_003Ec__DisplayClass49_.target = target;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass49_._003CDORotate_003Eb__0, _003C_003Ec__DisplayClass49_._003CDORotate_003Eb__1, endValue, duration);
			tweenerCore.SetTarget(_003C_003Ec__DisplayClass49_.target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DORotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
			_003C_003Ec__DisplayClass50_.target = target;
			TweenerCore<Quaternion, Quaternion, NoOptions> tweenerCore = DOTween.To(PureQuaternionPlugin.Plug(), _003C_003Ec__DisplayClass50_._003CDORotateQuaternion_003Eb__0, _003C_003Ec__DisplayClass50_._003CDORotateQuaternion_003Eb__1, endValue, duration);
			tweenerCore.SetTarget(_003C_003Ec__DisplayClass50_.target);
			return tweenerCore;
		}

		public static Tweener DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
			_003C_003Ec__DisplayClass51_.target = target;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass51_._003CDOLocalRotate_003Eb__0, _003C_003Ec__DisplayClass51_._003CDOLocalRotate_003Eb__1, endValue, duration);
			tweenerCore.SetTarget(_003C_003Ec__DisplayClass51_.target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
			_003C_003Ec__DisplayClass52_.target = target;
			TweenerCore<Quaternion, Quaternion, NoOptions> tweenerCore = DOTween.To(PureQuaternionPlugin.Plug(), _003C_003Ec__DisplayClass52_._003CDOLocalRotateQuaternion_003Eb__0, _003C_003Ec__DisplayClass52_._003CDOLocalRotateQuaternion_003Eb__1, endValue, duration);
			tweenerCore.SetTarget(_003C_003Ec__DisplayClass52_.target);
			return tweenerCore;
		}

		public static Tweener DOScale(this Transform target, Vector3 endValue, float duration)
		{
			_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
			_003C_003Ec__DisplayClass53_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass53_._003CDOScale_003Eb__0, _003C_003Ec__DisplayClass53_._003CDOScale_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass53_.target);
		}

		public static Tweener DOScale(this Transform target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
			_003C_003Ec__DisplayClass54_.target = target;
			return DOTween.To(endValue: new Vector3(endValue, endValue, endValue), getter: _003C_003Ec__DisplayClass54_._003CDOScale_003Eb__0, setter: _003C_003Ec__DisplayClass54_._003CDOScale_003Eb__1, duration: duration).SetTarget(_003C_003Ec__DisplayClass54_.target);
		}

		public static Tweener DOScaleX(this Transform target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
			_003C_003Ec__DisplayClass55_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass55_._003CDOScaleX_003Eb__0, _003C_003Ec__DisplayClass55_._003CDOScaleX_003Eb__1, new Vector3(endValue, 0f, 0f), duration).SetOptions(AxisConstraint.X).SetTarget(_003C_003Ec__DisplayClass55_.target);
		}

		public static Tweener DOScaleY(this Transform target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
			_003C_003Ec__DisplayClass56_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass56_._003CDOScaleY_003Eb__0, _003C_003Ec__DisplayClass56_._003CDOScaleY_003Eb__1, new Vector3(0f, endValue, 0f), duration).SetOptions(AxisConstraint.Y).SetTarget(_003C_003Ec__DisplayClass56_.target);
		}

		public static Tweener DOScaleZ(this Transform target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_0();
			_003C_003Ec__DisplayClass57_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass57_._003CDOScaleZ_003Eb__0, _003C_003Ec__DisplayClass57_._003CDOScaleZ_003Eb__1, new Vector3(0f, 0f, endValue), duration).SetOptions(AxisConstraint.Z).SetTarget(_003C_003Ec__DisplayClass57_.target);
		}

		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
			_003C_003Ec__DisplayClass58_.target = target;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass58_._003CDOLookAt_003Eb__0, _003C_003Ec__DisplayClass58_._003CDOLookAt_003Eb__1, towards, duration).SetTarget(_003C_003Ec__DisplayClass58_.target).SetSpecialStartupMode(SpecialStartupMode.SetLookAt);
			tweenerCore.plugOptions.axisConstraint = axisConstraint;
			tweenerCore.plugOptions.up = ((!up.HasValue) ? Vector3.up : up.Value);
			return tweenerCore;
		}

		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
			_003C_003Ec__DisplayClass59_.target = target;
			return DOTween.Punch(_003C_003Ec__DisplayClass59_._003CDOPunchPosition_003Eb__0, _003C_003Ec__DisplayClass59_._003CDOPunchPosition_003Eb__1, punch, duration, vibrato, elasticity).SetTarget(_003C_003Ec__DisplayClass59_.target).SetOptions(snapping);
		}

		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
			_003C_003Ec__DisplayClass60_.target = target;
			return DOTween.Punch(_003C_003Ec__DisplayClass60_._003CDOPunchScale_003Eb__0, _003C_003Ec__DisplayClass60_._003CDOPunchScale_003Eb__1, punch, duration, vibrato, elasticity).SetTarget(_003C_003Ec__DisplayClass60_.target);
		}

		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
			_003C_003Ec__DisplayClass61_.target = target;
			return DOTween.Punch(_003C_003Ec__DisplayClass61_._003CDOPunchRotation_003Eb__0, _003C_003Ec__DisplayClass61_._003CDOPunchRotation_003Eb__1, punch, duration, vibrato, elasticity).SetTarget(_003C_003Ec__DisplayClass61_.target);
		}

		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
			_003C_003Ec__DisplayClass62_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass62_._003CDOShakePosition_003Eb__0, _003C_003Ec__DisplayClass62_._003CDOShakePosition_003Eb__1, duration, strength, vibrato, randomness, false, fadeOut).SetTarget(_003C_003Ec__DisplayClass62_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake)
				.SetOptions(snapping);
		}

		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
			_003C_003Ec__DisplayClass63_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass63_._003CDOShakePosition_003Eb__0, _003C_003Ec__DisplayClass63_._003CDOShakePosition_003Eb__1, duration, strength, vibrato, randomness, fadeOut).SetTarget(_003C_003Ec__DisplayClass63_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake)
				.SetOptions(snapping);
		}

		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass64_0 _003C_003Ec__DisplayClass64_ = new _003C_003Ec__DisplayClass64_0();
			_003C_003Ec__DisplayClass64_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass64_._003CDOShakeRotation_003Eb__0, _003C_003Ec__DisplayClass64_._003CDOShakeRotation_003Eb__1, duration, strength, vibrato, randomness, false, fadeOut).SetTarget(_003C_003Ec__DisplayClass64_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass65_0 _003C_003Ec__DisplayClass65_ = new _003C_003Ec__DisplayClass65_0();
			_003C_003Ec__DisplayClass65_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass65_._003CDOShakeRotation_003Eb__0, _003C_003Ec__DisplayClass65_._003CDOShakeRotation_003Eb__1, duration, strength, vibrato, randomness, fadeOut).SetTarget(_003C_003Ec__DisplayClass65_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass66_0 _003C_003Ec__DisplayClass66_ = new _003C_003Ec__DisplayClass66_0();
			_003C_003Ec__DisplayClass66_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass66_._003CDOShakeScale_003Eb__0, _003C_003Ec__DisplayClass66_._003CDOShakeScale_003Eb__1, duration, strength, vibrato, randomness, false, fadeOut).SetTarget(_003C_003Ec__DisplayClass66_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
			_003C_003Ec__DisplayClass67_.target = target;
			return DOTween.Shake(_003C_003Ec__DisplayClass67_._003CDOShakeScale_003Eb__0, _003C_003Ec__DisplayClass67_._003CDOShakeScale_003Eb__1, duration, strength, vibrato, randomness, fadeOut).SetTarget(_003C_003Ec__DisplayClass67_.target).SetSpecialStartupMode(SpecialStartupMode.SetShake);
		}

		public static Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
			_003C_003Ec__DisplayClass68_.target = target;
			_003C_003Ec__DisplayClass68_.endValue = endValue;
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			_003C_003Ec__DisplayClass68_.startPosY = _003C_003Ec__DisplayClass68_.target.position.y;
			_003C_003Ec__DisplayClass68_.offsetY = -1f;
			_003C_003Ec__DisplayClass68_.offsetYSet = false;
			_003C_003Ec__DisplayClass68_.s = DOTween.Sequence();
			_003C_003Ec__DisplayClass68_.s.Append(DOTween.To(_003C_003Ec__DisplayClass68_._003CDOJump_003Eb__0, _003C_003Ec__DisplayClass68_._003CDOJump_003Eb__1, new Vector3(_003C_003Ec__DisplayClass68_.endValue.x, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)
				.OnUpdate(_003C_003Ec__DisplayClass68_._003CDOJump_003Eb__2)).Join(DOTween.To(_003C_003Ec__DisplayClass68_._003CDOJump_003Eb__3, _003C_003Ec__DisplayClass68_._003CDOJump_003Eb__4, new Vector3(0f, 0f, _003C_003Ec__DisplayClass68_.endValue.z), duration).SetOptions(AxisConstraint.Z, snapping).SetEase(Ease.Linear)).Join(DOTween.To(_003C_003Ec__DisplayClass68_._003CDOJump_003Eb__5, _003C_003Ec__DisplayClass68_._003CDOJump_003Eb__6, new Vector3(0f, jumpPower, 0f), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo))
				.SetTarget(_003C_003Ec__DisplayClass68_.target)
				.SetEase(DOTween.defaultEaseType);
			return _003C_003Ec__DisplayClass68_.s;
		}

		public static Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
			_003C_003Ec__DisplayClass69_.target = target;
			_003C_003Ec__DisplayClass69_.endValue = endValue;
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			_003C_003Ec__DisplayClass69_.startPosY = _003C_003Ec__DisplayClass69_.target.localPosition.y;
			_003C_003Ec__DisplayClass69_.offsetY = -1f;
			_003C_003Ec__DisplayClass69_.offsetYSet = false;
			_003C_003Ec__DisplayClass69_.s = DOTween.Sequence();
			_003C_003Ec__DisplayClass69_.s.Append(DOTween.To(_003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__0, _003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__1, new Vector3(_003C_003Ec__DisplayClass69_.endValue.x, 0f, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)
				.OnUpdate(_003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__2)).Join(DOTween.To(_003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__3, _003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__4, new Vector3(0f, 0f, _003C_003Ec__DisplayClass69_.endValue.z), duration).SetOptions(AxisConstraint.Z, snapping).SetEase(Ease.Linear)).Join(DOTween.To(_003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__5, _003C_003Ec__DisplayClass69_._003CDOLocalJump_003Eb__6, new Vector3(0f, jumpPower, 0f), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetRelative()
				.SetLoops(numJumps * 2, LoopType.Yoyo))
				.SetTarget(_003C_003Ec__DisplayClass69_.target)
				.SetEase(DOTween.defaultEaseType);
			return _003C_003Ec__DisplayClass69_.s;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			_003C_003Ec__DisplayClass70_0 _003C_003Ec__DisplayClass70_ = new _003C_003Ec__DisplayClass70_0();
			_003C_003Ec__DisplayClass70_.target = target;
			if (resolution < 1)
			{
				resolution = 1;
			}
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass70_._003CDOPath_003Eb__0, _003C_003Ec__DisplayClass70_._003CDOPath_003Eb__1, new Path(pathType, path, resolution, gizmoColor), duration).SetTarget(_003C_003Ec__DisplayClass70_.target);
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
			_003C_003Ec__DisplayClass71_.target = target;
			if (resolution < 1)
			{
				resolution = 1;
			}
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass71_._003CDOLocalPath_003Eb__0, _003C_003Ec__DisplayClass71_._003CDOLocalPath_003Eb__1, new Path(pathType, path, resolution, gizmoColor), duration).SetTarget(_003C_003Ec__DisplayClass71_.target);
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			_003C_003Ec__DisplayClass72_0 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_0();
			_003C_003Ec__DisplayClass72_.target = target;
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass72_._003CDOPath_003Eb__0, _003C_003Ec__DisplayClass72_._003CDOPath_003Eb__1, path, duration).SetTarget(_003C_003Ec__DisplayClass72_.target);
			tweenerCore.plugOptions.mode = pathMode;
			return tweenerCore;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			_003C_003Ec__DisplayClass73_0 _003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_0();
			_003C_003Ec__DisplayClass73_.target = target;
			TweenerCore<Vector3, Path, PathOptions> tweenerCore = DOTween.To(PathPlugin.Get(), _003C_003Ec__DisplayClass73_._003CDOLocalPath_003Eb__0, _003C_003Ec__DisplayClass73_._003CDOLocalPath_003Eb__1, path, duration).SetTarget(_003C_003Ec__DisplayClass73_.target);
			tweenerCore.plugOptions.mode = pathMode;
			tweenerCore.plugOptions.useLocalPosition = true;
			return tweenerCore;
		}

		public static Tweener DOBlendableColor(this Light target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
			_003C_003Ec__DisplayClass74_.target = target;
			endValue -= _003C_003Ec__DisplayClass74_.target.color;
			_003C_003Ec__DisplayClass74_.to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(_003C_003Ec__DisplayClass74_._003CDOBlendableColor_003Eb__0, _003C_003Ec__DisplayClass74_._003CDOBlendableColor_003Eb__1, endValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass74_.target);
		}

		public static Tweener DOBlendableColor(this Material target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass75_0 _003C_003Ec__DisplayClass75_ = new _003C_003Ec__DisplayClass75_0();
			_003C_003Ec__DisplayClass75_.target = target;
			endValue -= _003C_003Ec__DisplayClass75_.target.color;
			_003C_003Ec__DisplayClass75_.to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(_003C_003Ec__DisplayClass75_._003CDOBlendableColor_003Eb__0, _003C_003Ec__DisplayClass75_._003CDOBlendableColor_003Eb__1, endValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass75_.target);
		}

		public static Tweener DOBlendableColor(this Material target, Color endValue, string property, float duration)
		{
			_003C_003Ec__DisplayClass76_0 _003C_003Ec__DisplayClass76_ = new _003C_003Ec__DisplayClass76_0();
			_003C_003Ec__DisplayClass76_.target = target;
			_003C_003Ec__DisplayClass76_.property = property;
			if (!_003C_003Ec__DisplayClass76_.target.HasProperty(_003C_003Ec__DisplayClass76_.property))
			{
				if (Debugger.logPriority > 0)
				{
					Debugger.LogMissingMaterialProperty(_003C_003Ec__DisplayClass76_.property);
				}
				return null;
			}
			endValue -= _003C_003Ec__DisplayClass76_.target.GetColor(_003C_003Ec__DisplayClass76_.property);
			_003C_003Ec__DisplayClass76_.to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(_003C_003Ec__DisplayClass76_._003CDOBlendableColor_003Eb__0, _003C_003Ec__DisplayClass76_._003CDOBlendableColor_003Eb__1, endValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass76_.target);
		}

		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass77_0 _003C_003Ec__DisplayClass77_ = new _003C_003Ec__DisplayClass77_0();
			_003C_003Ec__DisplayClass77_.target = target;
			_003C_003Ec__DisplayClass77_.to = Vector3.zero;
			return DOTween.To(_003C_003Ec__DisplayClass77_._003CDOBlendableMoveBy_003Eb__0, _003C_003Ec__DisplayClass77_._003CDOBlendableMoveBy_003Eb__1, byValue, duration).Blendable().SetOptions(snapping)
				.SetTarget(_003C_003Ec__DisplayClass77_.target);
		}

		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
			_003C_003Ec__DisplayClass78_.target = target;
			_003C_003Ec__DisplayClass78_.to = Vector3.zero;
			return DOTween.To(_003C_003Ec__DisplayClass78_._003CDOBlendableLocalMoveBy_003Eb__0, _003C_003Ec__DisplayClass78_._003CDOBlendableLocalMoveBy_003Eb__1, byValue, duration).Blendable().SetOptions(snapping)
				.SetTarget(_003C_003Ec__DisplayClass78_.target);
		}

		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
			_003C_003Ec__DisplayClass79_.target = target;
			_003C_003Ec__DisplayClass79_.to = _003C_003Ec__DisplayClass79_.target.rotation;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass79_._003CDOBlendableRotateBy_003Eb__0, _003C_003Ec__DisplayClass79_._003CDOBlendableRotateBy_003Eb__1, byValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass79_.target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
			_003C_003Ec__DisplayClass80_.target = target;
			_003C_003Ec__DisplayClass80_.to = _003C_003Ec__DisplayClass80_.target.localRotation;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = DOTween.To(_003C_003Ec__DisplayClass80_._003CDOBlendableLocalRotateBy_003Eb__0, _003C_003Ec__DisplayClass80_._003CDOBlendableLocalRotateBy_003Eb__1, byValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass80_.target);
			tweenerCore.plugOptions.rotateMode = mode;
			return tweenerCore;
		}

		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration)
		{
			_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
			_003C_003Ec__DisplayClass81_.target = target;
			_003C_003Ec__DisplayClass81_.to = Vector3.zero;
			return DOTween.To(_003C_003Ec__DisplayClass81_._003CDOBlendableScaleBy_003Eb__0, _003C_003Ec__DisplayClass81_._003CDOBlendableScaleBy_003Eb__1, byValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass81_.target);
		}

		public static int DOComplete(this Component target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		public static int DOComplete(this Material target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		public static int DOKill(this Component target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		public static int DOKill(this Material target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		public static int DOFlip(this Component target)
		{
			return DOTween.Flip(target);
		}

		public static int DOFlip(this Material target)
		{
			return DOTween.Flip(target);
		}

		public static int DOGoto(this Component target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		public static int DOGoto(this Material target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		public static int DOPause(this Component target)
		{
			return DOTween.Pause(target);
		}

		public static int DOPause(this Material target)
		{
			return DOTween.Pause(target);
		}

		public static int DOPlay(this Component target)
		{
			return DOTween.Play(target);
		}

		public static int DOPlay(this Material target)
		{
			return DOTween.Play(target);
		}

		public static int DOPlayBackwards(this Component target)
		{
			return DOTween.PlayBackwards(target);
		}

		public static int DOPlayBackwards(this Material target)
		{
			return DOTween.PlayBackwards(target);
		}

		public static int DOPlayForward(this Component target)
		{
			return DOTween.PlayForward(target);
		}

		public static int DOPlayForward(this Material target)
		{
			return DOTween.PlayForward(target);
		}

		public static int DORestart(this Component target, bool includeDelay = true)
		{
			return DOTween.Restart(target, includeDelay);
		}

		public static int DORestart(this Material target, bool includeDelay = true)
		{
			return DOTween.Restart(target, includeDelay);
		}

		public static int DORewind(this Component target, bool includeDelay = true)
		{
			return DOTween.Rewind(target, includeDelay);
		}

		public static int DORewind(this Material target, bool includeDelay = true)
		{
			return DOTween.Rewind(target, includeDelay);
		}

		public static int DOSmoothRewind(this Component target)
		{
			return DOTween.SmoothRewind(target);
		}

		public static int DOSmoothRewind(this Material target)
		{
			return DOTween.SmoothRewind(target);
		}

		public static int DOTogglePause(this Component target)
		{
			return DOTween.TogglePause(target);
		}

		public static int DOTogglePause(this Material target)
		{
			return DOTween.TogglePause(target);
		}
	}
}
