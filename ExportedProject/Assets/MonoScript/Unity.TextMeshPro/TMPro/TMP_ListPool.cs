using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TMPro
{
	internal static class TMP_ListPool<T>
	{
		private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, _003Cs_ListPool_003Em__0);

		public static List<T> Get()
		{
			return s_ListPool.Get();
		}

		public static void Release(List<T> toRelease)
		{
			s_ListPool.Release(toRelease);
		}

		[CompilerGenerated]
		private static void _003Cs_ListPool_003Em__0(List<T> l)
		{
			l.Clear();
		}
	}
}
