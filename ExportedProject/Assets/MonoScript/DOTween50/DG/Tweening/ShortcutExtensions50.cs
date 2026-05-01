using System.Runtime.CompilerServices;
using UnityEngine.Audio;

namespace DG.Tweening
{
	public static class ShortcutExtensions50
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public AudioMixer target;

			public string floatName;

			internal float _003CDOSetFloat_003Eb__0()
			{
				float value;
				target.GetFloat(floatName, out value);
				return value;
			}

			internal void _003CDOSetFloat_003Eb__1(float x)
			{
				target.SetFloat(floatName, x);
			}
		}

		public static Tweener DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			_003C_003Ec__DisplayClass0_.target = target;
			_003C_003Ec__DisplayClass0_.floatName = floatName;
			return DOTween.To(_003C_003Ec__DisplayClass0_._003CDOSetFloat_003Eb__0, _003C_003Ec__DisplayClass0_._003CDOSetFloat_003Eb__1, endValue, duration).SetTarget(_003C_003Ec__DisplayClass0_.target);
		}

		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return DOTween.Complete(target, withCallbacks);
		}

		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return DOTween.Kill(target, complete);
		}

		public static int DOFlip(this AudioMixer target)
		{
			return DOTween.Flip(target);
		}

		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return DOTween.Goto(target, to, andPlay);
		}

		public static int DOPause(this AudioMixer target)
		{
			return DOTween.Pause(target);
		}

		public static int DOPlay(this AudioMixer target)
		{
			return DOTween.Play(target);
		}

		public static int DOPlayBackwards(this AudioMixer target)
		{
			return DOTween.PlayBackwards(target);
		}

		public static int DOPlayForward(this AudioMixer target)
		{
			return DOTween.PlayForward(target);
		}

		public static int DORestart(this AudioMixer target)
		{
			return DOTween.Restart(target);
		}

		public static int DORewind(this AudioMixer target)
		{
			return DOTween.Rewind(target);
		}

		public static int DOSmoothRewind(this AudioMixer target)
		{
			return DOTween.SmoothRewind(target);
		}

		public static int DOTogglePause(this AudioMixer target)
		{
			return DOTween.TogglePause(target);
		}
	}
}
