using System.Runtime.CompilerServices;
using DG.Tweening.Core.Easing;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOVirtual
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public float val;

			public TweenCallback<float> onVirtualUpdate;

			internal float _003CFloat_003Eb__0()
			{
				return val;
			}

			internal void _003CFloat_003Eb__1(float x)
			{
				val = x;
			}

			internal void _003CFloat_003Eb__2()
			{
				onVirtualUpdate(val);
			}
		}

		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			_003C_003Ec__DisplayClass0_.onVirtualUpdate = onVirtualUpdate;
			_003C_003Ec__DisplayClass0_.val = from;
			return DOTween.To(_003C_003Ec__DisplayClass0_._003CFloat_003Eb__0, _003C_003Ec__DisplayClass0_._003CFloat_003Eb__1, to, duration).OnUpdate(_003C_003Ec__DisplayClass0_._003CFloat_003Eb__2);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			return from + (to - from) * EaseManager.Evaluate(easeType, null, lifetimePercentage, 1f, DOTween.defaultEaseOvershootOrAmplitude, DOTween.defaultEasePeriod);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			return from + (to - from) * EaseManager.Evaluate(easeType, null, lifetimePercentage, 1f, overshoot, DOTween.defaultEasePeriod);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			return from + (to - from) * EaseManager.Evaluate(easeType, null, lifetimePercentage, 1f, amplitude, period);
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			return from + (to - from) * EaseManager.Evaluate(Ease.INTERNAL_Custom, new EaseCurve(easeCurve).Evaluate, lifetimePercentage, 1f, DOTween.defaultEaseOvershootOrAmplitude, DOTween.defaultEasePeriod);
		}

		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			return DOTween.Sequence().AppendInterval(delay).OnStepComplete(callback)
				.SetUpdate(UpdateType.Normal, ignoreTimeScale)
				.SetAutoKill(true);
		}
	}
}
