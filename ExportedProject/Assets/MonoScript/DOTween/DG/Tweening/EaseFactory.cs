using System.Runtime.CompilerServices;
using DG.Tweening.Core.Easing;
using UnityEngine;

namespace DG.Tweening
{
	public class EaseFactory
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public float motionDelay;

			public EaseFunction customEase;

			internal float _003CStopMotion_003Eb__0(float time, float duration, float overshootOrAmplitude, float period)
			{
				float time2 = ((time < duration) ? (time - time % motionDelay) : time);
				return customEase(time2, duration, overshootOrAmplitude, period);
			}
		}

		public static EaseFunction StopMotion(int motionFps, Ease? ease = null)
		{
			EaseFunction customEase = EaseManager.ToEaseFunction((!ease.HasValue) ? DOTween.defaultEaseType : ease.Value);
			return StopMotion(motionFps, customEase);
		}

		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve)
		{
			return StopMotion(motionFps, new EaseCurve(animCurve).Evaluate);
		}

		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase)
		{
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
			_003C_003Ec__DisplayClass2_.customEase = customEase;
			_003C_003Ec__DisplayClass2_.motionDelay = 1f / (float)motionFps;
			return _003C_003Ec__DisplayClass2_._003CStopMotion_003Eb__0;
		}
	}
}
