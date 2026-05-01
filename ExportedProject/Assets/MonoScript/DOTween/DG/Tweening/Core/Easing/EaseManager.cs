using System;
using System.Runtime.CompilerServices;

namespace DG.Tweening.Core.Easing
{
	public static class EaseManager
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static EaseFunction _003C_003E9__4_0;

			public static EaseFunction _003C_003E9__4_1;

			public static EaseFunction _003C_003E9__4_2;

			public static EaseFunction _003C_003E9__4_3;

			public static EaseFunction _003C_003E9__4_4;

			public static EaseFunction _003C_003E9__4_5;

			public static EaseFunction _003C_003E9__4_6;

			public static EaseFunction _003C_003E9__4_7;

			public static EaseFunction _003C_003E9__4_8;

			public static EaseFunction _003C_003E9__4_9;

			public static EaseFunction _003C_003E9__4_10;

			public static EaseFunction _003C_003E9__4_11;

			public static EaseFunction _003C_003E9__4_12;

			public static EaseFunction _003C_003E9__4_13;

			public static EaseFunction _003C_003E9__4_14;

			public static EaseFunction _003C_003E9__4_15;

			public static EaseFunction _003C_003E9__4_16;

			public static EaseFunction _003C_003E9__4_17;

			public static EaseFunction _003C_003E9__4_18;

			public static EaseFunction _003C_003E9__4_19;

			public static EaseFunction _003C_003E9__4_20;

			public static EaseFunction _003C_003E9__4_21;

			public static EaseFunction _003C_003E9__4_22;

			public static EaseFunction _003C_003E9__4_23;

			public static EaseFunction _003C_003E9__4_24;

			public static EaseFunction _003C_003E9__4_25;

			public static EaseFunction _003C_003E9__4_26;

			public static EaseFunction _003C_003E9__4_27;

			public static EaseFunction _003C_003E9__4_28;

			public static EaseFunction _003C_003E9__4_29;

			public static EaseFunction _003C_003E9__4_30;

			public static EaseFunction _003C_003E9__4_31;

			public static EaseFunction _003C_003E9__4_32;

			public static EaseFunction _003C_003E9__4_33;

			public static EaseFunction _003C_003E9__4_34;

			public static EaseFunction _003C_003E9__4_35;

			internal float _003CToEaseFunction_003Eb__4_0(float time, float duration, float overshootOrAmplitude, float period)
			{
				return time / duration;
			}

			internal float _003CToEaseFunction_003Eb__4_1(float time, float duration, float overshootOrAmplitude, float period)
			{
				return 0f - (float)Math.Cos(time / duration * ((float)Math.PI / 2f)) + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_2(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (float)Math.Sin(time / duration * ((float)Math.PI / 2f));
			}

			internal float _003CToEaseFunction_003Eb__4_3(float time, float duration, float overshootOrAmplitude, float period)
			{
				return -0.5f * ((float)Math.Cos((float)Math.PI * time / duration) - 1f);
			}

			internal float _003CToEaseFunction_003Eb__4_4(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time /= duration) * time;
			}

			internal float _003CToEaseFunction_003Eb__4_5(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (0f - (time /= duration)) * (time - 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_6(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time;
				}
				return -0.5f * ((time -= 1f) * (time - 2f) - 1f);
			}

			internal float _003CToEaseFunction_003Eb__4_7(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time /= duration) * time * time;
			}

			internal float _003CToEaseFunction_003Eb__4_8(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time = time / duration - 1f) * time * time + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_9(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time;
				}
				return 0.5f * ((time -= 2f) * time * time + 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_10(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time /= duration) * time * time * time;
			}

			internal float _003CToEaseFunction_003Eb__4_11(float time, float duration, float overshootOrAmplitude, float period)
			{
				return 0f - ((time = time / duration - 1f) * time * time * time - 1f);
			}

			internal float _003CToEaseFunction_003Eb__4_12(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time * time;
				}
				return -0.5f * ((time -= 2f) * time * time * time - 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_13(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time /= duration) * time * time * time * time;
			}

			internal float _003CToEaseFunction_003Eb__4_14(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time = time / duration - 1f) * time * time * time * time + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_15(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time * time * time;
				}
				return 0.5f * ((time -= 2f) * time * time * time * time + 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_16(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time != 0f)
				{
					return (float)Math.Pow(2.0, 10f * (time / duration - 1f));
				}
				return 0f;
			}

			internal float _003CToEaseFunction_003Eb__4_17(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time == duration)
				{
					return 1f;
				}
				return 0f - (float)Math.Pow(2.0, -10f * time / duration) + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_18(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time == 0f)
				{
					return 0f;
				}
				if (time == duration)
				{
					return 1f;
				}
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * (float)Math.Pow(2.0, 10f * (time - 1f));
				}
				return 0.5f * (0f - (float)Math.Pow(2.0, -10f * (time -= 1f)) + 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_19(float time, float duration, float overshootOrAmplitude, float period)
			{
				return 0f - ((float)Math.Sqrt(1f - (time /= duration) * time) - 1f);
			}

			internal float _003CToEaseFunction_003Eb__4_20(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (float)Math.Sqrt(1f - (time = time / duration - 1f) * time);
			}

			internal float _003CToEaseFunction_003Eb__4_21(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return -0.5f * ((float)Math.Sqrt(1f - time * time) - 1f);
				}
				return 0.5f * ((float)Math.Sqrt(1f - (time -= 2f) * time) + 1f);
			}

			internal float _003CToEaseFunction_003Eb__4_22(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration) == 1f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num = period / 4f;
				}
				else
				{
					num = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				return 0f - overshootOrAmplitude * (float)Math.Pow(2.0, 10f * (time -= 1f)) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period);
			}

			internal float _003CToEaseFunction_003Eb__4_23(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration) == 1f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num = period / 4f;
				}
				else
				{
					num = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, -10f * time) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period) + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_24(float time, float duration, float overshootOrAmplitude, float period)
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration * 0.5f) == 2f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.45000002f;
				}
				float num;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num = period / 4f;
				}
				else
				{
					num = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				if (time < 1f)
				{
					return -0.5f * (overshootOrAmplitude * (float)Math.Pow(2.0, 10f * (time -= 1f)) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period));
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, -10f * (time -= 1f)) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period) * 0.5f + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_25(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time /= duration) * time * ((overshootOrAmplitude + 1f) * time - overshootOrAmplitude);
			}

			internal float _003CToEaseFunction_003Eb__4_26(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (time = time / duration - 1f) * time * ((overshootOrAmplitude + 1f) * time + overshootOrAmplitude) + 1f;
			}

			internal float _003CToEaseFunction_003Eb__4_27(float time, float duration, float overshootOrAmplitude, float period)
			{
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * (time * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time - overshootOrAmplitude));
				}
				return 0.5f * ((time -= 2f) * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time + overshootOrAmplitude) + 2f);
			}

			internal float _003CToEaseFunction_003Eb__4_28(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Bounce.EaseIn(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_29(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Bounce.EaseOut(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_30(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Bounce.EaseInOut(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_31(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Flash.Ease(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_32(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Flash.EaseIn(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_33(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Flash.EaseOut(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_34(float time, float duration, float overshootOrAmplitude, float period)
			{
				return Flash.EaseInOut(time, duration, overshootOrAmplitude, period);
			}

			internal float _003CToEaseFunction_003Eb__4_35(float time, float duration, float overshootOrAmplitude, float period)
			{
				return (0f - (time /= duration)) * (time - 2f);
			}
		}

		private const float _PiOver2 = (float)Math.PI / 2f;

		private const float _TwoPi = (float)Math.PI * 2f;

		public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			return Evaluate(t.easeType, t.customEase, time, duration, overshootOrAmplitude, period);
		}

		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			switch (easeType)
			{
			case Ease.Linear:
				return time / duration;
			case Ease.InSine:
				return 0f - (float)Math.Cos(time / duration * ((float)Math.PI / 2f)) + 1f;
			case Ease.OutSine:
				return (float)Math.Sin(time / duration * ((float)Math.PI / 2f));
			case Ease.InOutSine:
				return -0.5f * ((float)Math.Cos((float)Math.PI * time / duration) - 1f);
			case Ease.InQuad:
				return (time /= duration) * time;
			case Ease.OutQuad:
				return (0f - (time /= duration)) * (time - 2f);
			case Ease.InOutQuad:
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time;
				}
				return -0.5f * ((time -= 1f) * (time - 2f) - 1f);
			case Ease.InCubic:
				return (time /= duration) * time * time;
			case Ease.OutCubic:
				return (time = time / duration - 1f) * time * time + 1f;
			case Ease.InOutCubic:
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time;
				}
				return 0.5f * ((time -= 2f) * time * time + 2f);
			case Ease.InQuart:
				return (time /= duration) * time * time * time;
			case Ease.OutQuart:
				return 0f - ((time = time / duration - 1f) * time * time * time - 1f);
			case Ease.InOutQuart:
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time * time;
				}
				return -0.5f * ((time -= 2f) * time * time * time - 2f);
			case Ease.InQuint:
				return (time /= duration) * time * time * time * time;
			case Ease.OutQuint:
				return (time = time / duration - 1f) * time * time * time * time + 1f;
			case Ease.InOutQuint:
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * time * time * time * time * time;
				}
				return 0.5f * ((time -= 2f) * time * time * time * time + 2f);
			case Ease.InExpo:
				if (time != 0f)
				{
					return (float)Math.Pow(2.0, 10f * (time / duration - 1f));
				}
				return 0f;
			case Ease.OutExpo:
				if (time == duration)
				{
					return 1f;
				}
				return 0f - (float)Math.Pow(2.0, -10f * time / duration) + 1f;
			case Ease.InOutExpo:
				if (time == 0f)
				{
					return 0f;
				}
				if (time == duration)
				{
					return 1f;
				}
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * (float)Math.Pow(2.0, 10f * (time - 1f));
				}
				return 0.5f * (0f - (float)Math.Pow(2.0, -10f * (time -= 1f)) + 2f);
			case Ease.InCirc:
				return 0f - ((float)Math.Sqrt(1f - (time /= duration) * time) - 1f);
			case Ease.OutCirc:
				return (float)Math.Sqrt(1f - (time = time / duration - 1f) * time);
			case Ease.InOutCirc:
				if ((time /= duration * 0.5f) < 1f)
				{
					return -0.5f * ((float)Math.Sqrt(1f - time * time) - 1f);
				}
				return 0.5f * ((float)Math.Sqrt(1f - (time -= 2f) * time) + 1f);
			case Ease.InElastic:
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration) == 1f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num3;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num3 = period / 4f;
				}
				else
				{
					num3 = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				return 0f - overshootOrAmplitude * (float)Math.Pow(2.0, 10f * (time -= 1f)) * (float)Math.Sin((time * duration - num3) * ((float)Math.PI * 2f) / period);
			}
			case Ease.OutElastic:
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration) == 1f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.3f;
				}
				float num2;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num2 = period / 4f;
				}
				else
				{
					num2 = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, -10f * time) * (float)Math.Sin((time * duration - num2) * ((float)Math.PI * 2f) / period) + 1f;
			}
			case Ease.InOutElastic:
			{
				if (time == 0f)
				{
					return 0f;
				}
				if ((time /= duration * 0.5f) == 2f)
				{
					return 1f;
				}
				if (period == 0f)
				{
					period = duration * 0.45000002f;
				}
				float num;
				if (overshootOrAmplitude < 1f)
				{
					overshootOrAmplitude = 1f;
					num = period / 4f;
				}
				else
				{
					num = period / ((float)Math.PI * 2f) * (float)Math.Asin(1f / overshootOrAmplitude);
				}
				if (time < 1f)
				{
					return -0.5f * (overshootOrAmplitude * (float)Math.Pow(2.0, 10f * (time -= 1f)) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period));
				}
				return overshootOrAmplitude * (float)Math.Pow(2.0, -10f * (time -= 1f)) * (float)Math.Sin((time * duration - num) * ((float)Math.PI * 2f) / period) * 0.5f + 1f;
			}
			case Ease.InBack:
				return (time /= duration) * time * ((overshootOrAmplitude + 1f) * time - overshootOrAmplitude);
			case Ease.OutBack:
				return (time = time / duration - 1f) * time * ((overshootOrAmplitude + 1f) * time + overshootOrAmplitude) + 1f;
			case Ease.InOutBack:
				if ((time /= duration * 0.5f) < 1f)
				{
					return 0.5f * (time * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time - overshootOrAmplitude));
				}
				return 0.5f * ((time -= 2f) * time * (((overshootOrAmplitude *= 1.525f) + 1f) * time + overshootOrAmplitude) + 2f);
			case Ease.InBounce:
				return Bounce.EaseIn(time, duration, overshootOrAmplitude, period);
			case Ease.OutBounce:
				return Bounce.EaseOut(time, duration, overshootOrAmplitude, period);
			case Ease.InOutBounce:
				return Bounce.EaseInOut(time, duration, overshootOrAmplitude, period);
			case Ease.INTERNAL_Custom:
				return customEase(time, duration, overshootOrAmplitude, period);
			case Ease.INTERNAL_Zero:
				return 1f;
			case Ease.Flash:
				return Flash.Ease(time, duration, overshootOrAmplitude, period);
			case Ease.InFlash:
				return Flash.EaseIn(time, duration, overshootOrAmplitude, period);
			case Ease.OutFlash:
				return Flash.EaseOut(time, duration, overshootOrAmplitude, period);
			case Ease.InOutFlash:
				return Flash.EaseInOut(time, duration, overshootOrAmplitude, period);
			default:
				return (0f - (time /= duration)) * (time - 2f);
			}
		}

		public static EaseFunction ToEaseFunction(Ease ease)
		{
			switch (ease)
			{
			case Ease.Linear:
				return _003C_003Ec._003C_003E9__4_0 ?? (_003C_003Ec._003C_003E9__4_0 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_0);
			case Ease.InSine:
				return _003C_003Ec._003C_003E9__4_1 ?? (_003C_003Ec._003C_003E9__4_1 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_1);
			case Ease.OutSine:
				return _003C_003Ec._003C_003E9__4_2 ?? (_003C_003Ec._003C_003E9__4_2 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_2);
			case Ease.InOutSine:
				return _003C_003Ec._003C_003E9__4_3 ?? (_003C_003Ec._003C_003E9__4_3 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_3);
			case Ease.InQuad:
				return _003C_003Ec._003C_003E9__4_4 ?? (_003C_003Ec._003C_003E9__4_4 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_4);
			case Ease.OutQuad:
				return _003C_003Ec._003C_003E9__4_5 ?? (_003C_003Ec._003C_003E9__4_5 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_5);
			case Ease.InOutQuad:
				return _003C_003Ec._003C_003E9__4_6 ?? (_003C_003Ec._003C_003E9__4_6 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_6);
			case Ease.InCubic:
				return _003C_003Ec._003C_003E9__4_7 ?? (_003C_003Ec._003C_003E9__4_7 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_7);
			case Ease.OutCubic:
				return _003C_003Ec._003C_003E9__4_8 ?? (_003C_003Ec._003C_003E9__4_8 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_8);
			case Ease.InOutCubic:
				return _003C_003Ec._003C_003E9__4_9 ?? (_003C_003Ec._003C_003E9__4_9 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_9);
			case Ease.InQuart:
				return _003C_003Ec._003C_003E9__4_10 ?? (_003C_003Ec._003C_003E9__4_10 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_10);
			case Ease.OutQuart:
				return _003C_003Ec._003C_003E9__4_11 ?? (_003C_003Ec._003C_003E9__4_11 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_11);
			case Ease.InOutQuart:
				return _003C_003Ec._003C_003E9__4_12 ?? (_003C_003Ec._003C_003E9__4_12 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_12);
			case Ease.InQuint:
				return _003C_003Ec._003C_003E9__4_13 ?? (_003C_003Ec._003C_003E9__4_13 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_13);
			case Ease.OutQuint:
				return _003C_003Ec._003C_003E9__4_14 ?? (_003C_003Ec._003C_003E9__4_14 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_14);
			case Ease.InOutQuint:
				return _003C_003Ec._003C_003E9__4_15 ?? (_003C_003Ec._003C_003E9__4_15 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_15);
			case Ease.InExpo:
				return _003C_003Ec._003C_003E9__4_16 ?? (_003C_003Ec._003C_003E9__4_16 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_16);
			case Ease.OutExpo:
				return _003C_003Ec._003C_003E9__4_17 ?? (_003C_003Ec._003C_003E9__4_17 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_17);
			case Ease.InOutExpo:
				return _003C_003Ec._003C_003E9__4_18 ?? (_003C_003Ec._003C_003E9__4_18 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_18);
			case Ease.InCirc:
				return _003C_003Ec._003C_003E9__4_19 ?? (_003C_003Ec._003C_003E9__4_19 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_19);
			case Ease.OutCirc:
				return _003C_003Ec._003C_003E9__4_20 ?? (_003C_003Ec._003C_003E9__4_20 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_20);
			case Ease.InOutCirc:
				return _003C_003Ec._003C_003E9__4_21 ?? (_003C_003Ec._003C_003E9__4_21 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_21);
			case Ease.InElastic:
				return _003C_003Ec._003C_003E9__4_22 ?? (_003C_003Ec._003C_003E9__4_22 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_22);
			case Ease.OutElastic:
				return _003C_003Ec._003C_003E9__4_23 ?? (_003C_003Ec._003C_003E9__4_23 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_23);
			case Ease.InOutElastic:
				return _003C_003Ec._003C_003E9__4_24 ?? (_003C_003Ec._003C_003E9__4_24 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_24);
			case Ease.InBack:
				return _003C_003Ec._003C_003E9__4_25 ?? (_003C_003Ec._003C_003E9__4_25 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_25);
			case Ease.OutBack:
				return _003C_003Ec._003C_003E9__4_26 ?? (_003C_003Ec._003C_003E9__4_26 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_26);
			case Ease.InOutBack:
				return _003C_003Ec._003C_003E9__4_27 ?? (_003C_003Ec._003C_003E9__4_27 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_27);
			case Ease.InBounce:
				return _003C_003Ec._003C_003E9__4_28 ?? (_003C_003Ec._003C_003E9__4_28 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_28);
			case Ease.OutBounce:
				return _003C_003Ec._003C_003E9__4_29 ?? (_003C_003Ec._003C_003E9__4_29 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_29);
			case Ease.InOutBounce:
				return _003C_003Ec._003C_003E9__4_30 ?? (_003C_003Ec._003C_003E9__4_30 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_30);
			case Ease.Flash:
				return _003C_003Ec._003C_003E9__4_31 ?? (_003C_003Ec._003C_003E9__4_31 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_31);
			case Ease.InFlash:
				return _003C_003Ec._003C_003E9__4_32 ?? (_003C_003Ec._003C_003E9__4_32 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_32);
			case Ease.OutFlash:
				return _003C_003Ec._003C_003E9__4_33 ?? (_003C_003Ec._003C_003E9__4_33 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_33);
			case Ease.InOutFlash:
				return _003C_003Ec._003C_003E9__4_34 ?? (_003C_003Ec._003C_003E9__4_34 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_34);
			default:
				return _003C_003Ec._003C_003E9__4_35 ?? (_003C_003Ec._003C_003E9__4_35 = _003C_003Ec._003C_003E9._003CToEaseFunction_003Eb__4_35);
			}
		}

		internal static bool IsFlashEase(Ease ease)
		{
			switch (ease)
			{
			case Ease.Flash:
			case Ease.InFlash:
			case Ease.OutFlash:
			case Ease.InOutFlash:
				return true;
			default:
				return false;
			}
		}
	}
}
