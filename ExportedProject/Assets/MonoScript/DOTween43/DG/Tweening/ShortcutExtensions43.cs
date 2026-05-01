using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening
{
	public static class ShortcutExtensions43
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public SpriteRenderer target;

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
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public SpriteRenderer target;

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
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMove_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMoveX_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMoveY_003Eb__0()
			{
				return target.position;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Rigidbody2D target;

			internal float _003CDORotate_003Eb__0()
			{
				return target.rotation;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Rigidbody2D target;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector2 endValue;

			public float startPosY;

			internal Vector2 _003CDOJump_003Eb__0()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__1(Vector2 x)
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
				Vector2 position = target.position;
				position.y += DOVirtual.EasedValue(0f, offsetY, s.ElapsedDirectionalPercentage(), Ease.OutQuad);
				target.position = position;
			}

			internal Vector2 _003CDOJump_003Eb__3()
			{
				return target.position;
			}

			internal void _003CDOJump_003Eb__4(Vector2 x)
			{
				target.position = x;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Color to;

			public SpriteRenderer target;

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

		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, property, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Tweener DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass2_._003CDOColor_003Eb__0, _003C_003Ec__DisplayClass2_._003CDOColor_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass2_.target);
		}

		public static Tweener DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			_003C_003Ec__DisplayClass3_.target = target;
			return DOTween.ToAlpha(_003C_003Ec__DisplayClass3_._003CDOFade_003Eb__0, _003C_003Ec__DisplayClass3_._003CDOFade_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass3_.target);
		}

		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			Sequence sequence = DOTween.Sequence();
			GradientColorKey[] colorKeys = gradient.colorKeys;
			int num = colorKeys.Length;
			for (int i = 0; i < num; i++)
			{
				GradientColorKey gradientColorKey = colorKeys[i];
				if (i == 0 && gradientColorKey.time <= 0f)
				{
					target.color = gradientColorKey.color;
					continue;
				}
				float duration2 = ((i == num - 1) ? (duration - sequence.Duration(false)) : (duration * ((i == 0) ? gradientColorKey.time : (gradientColorKey.time - colorKeys[i - 1].time))));
				sequence.Append(target.DOColor(gradientColorKey.color, duration2).SetEase(Ease.Linear));
			}
			return sequence;
		}

		public static Tweener DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass5_._003CDOMove_003Eb__0, _003C_003Ec__DisplayClass5_.target.MovePosition, endValue, duration).SetOptions(snapping).SetTarget(_003C_003Ec__DisplayClass5_.target);
		}

		public static Tweener DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
			_003C_003Ec__DisplayClass6_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass6_._003CDOMoveX_003Eb__0, _003C_003Ec__DisplayClass6_.target.MovePosition, new Vector2(endValue, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetTarget(_003C_003Ec__DisplayClass6_.target);
		}

		public static Tweener DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
			_003C_003Ec__DisplayClass7_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass7_._003CDOMoveY_003Eb__0, _003C_003Ec__DisplayClass7_.target.MovePosition, new Vector2(0f, endValue), duration).SetOptions(AxisConstraint.Y, snapping).SetTarget(_003C_003Ec__DisplayClass7_.target);
		}

		public static Tweener DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
			_003C_003Ec__DisplayClass8_.target = target;
			return DOTween.To(_003C_003Ec__DisplayClass8_._003CDORotate_003Eb__0, _003C_003Ec__DisplayClass8_.target.MoveRotation, endValue, duration).SetTarget(_003C_003Ec__DisplayClass8_.target);
		}

		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
			_003C_003Ec__DisplayClass9_.target = target;
			_003C_003Ec__DisplayClass9_.endValue = endValue;
			if (numJumps < 1)
			{
				numJumps = 1;
			}
			_003C_003Ec__DisplayClass9_.startPosY = _003C_003Ec__DisplayClass9_.target.position.y;
			_003C_003Ec__DisplayClass9_.offsetY = -1f;
			_003C_003Ec__DisplayClass9_.offsetYSet = false;
			_003C_003Ec__DisplayClass9_.s = DOTween.Sequence();
			_003C_003Ec__DisplayClass9_.s.Append(DOTween.To(_003C_003Ec__DisplayClass9_._003CDOJump_003Eb__0, _003C_003Ec__DisplayClass9_._003CDOJump_003Eb__1, new Vector2(_003C_003Ec__DisplayClass9_.endValue.x, 0f), duration).SetOptions(AxisConstraint.X, snapping).SetEase(Ease.Linear)
				.OnUpdate(_003C_003Ec__DisplayClass9_._003CDOJump_003Eb__2)).Join(DOTween.To(_003C_003Ec__DisplayClass9_._003CDOJump_003Eb__3, _003C_003Ec__DisplayClass9_._003CDOJump_003Eb__4, new Vector2(0f, jumpPower), duration / (float)(numJumps * 2)).SetOptions(AxisConstraint.Y, snapping).SetEase(Ease.OutQuad)
				.SetLoops(numJumps * 2, LoopType.Yoyo)
				.SetRelative()).SetTarget(_003C_003Ec__DisplayClass9_.target)
				.SetEase(DOTween.defaultEaseType);
			return _003C_003Ec__DisplayClass9_.s;
		}

		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
			_003C_003Ec__DisplayClass10_.target = target;
			endValue -= _003C_003Ec__DisplayClass10_.target.color;
			_003C_003Ec__DisplayClass10_.to = new Color(0f, 0f, 0f, 0f);
			return DOTween.To(_003C_003Ec__DisplayClass10_._003CDOBlendableColor_003Eb__0, _003C_003Ec__DisplayClass10_._003CDOBlendableColor_003Eb__1, endValue, duration).Blendable().SetTarget(_003C_003Ec__DisplayClass10_.target);
		}
	}
}
