using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TMPro
{
	[Serializable]
	public class KerningTable
	{
		[CompilerGenerated]
		private sealed class _003CAddKerningPair_003Ec__AnonStorey0
		{
			internal uint first;

			internal uint second;

			internal bool _003C_003Em__0(KerningPair item)
			{
				return item.firstGlyph == first && item.secondGlyph == second;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey1
		{
			internal uint first;

			internal uint second;

			internal bool _003C_003Em__0(KerningPair item)
			{
				return item.firstGlyph == first && item.secondGlyph == second;
			}
		}

		[CompilerGenerated]
		private sealed class _003CRemoveKerningPair_003Ec__AnonStorey2
		{
			internal int left;

			internal int right;

			internal bool _003C_003Em__0(KerningPair item)
			{
				return item.firstGlyph == left && item.secondGlyph == right;
			}
		}

		public List<KerningPair> kerningPairs;

		[CompilerGenerated]
		private static Func<KerningPair, uint> _003C_003Ef__am_0024cache0;

		[CompilerGenerated]
		private static Func<KerningPair, uint> _003C_003Ef__am_0024cache1;

		public KerningTable()
		{
			kerningPairs = new List<KerningPair>();
		}

		public void AddKerningPair()
		{
			if (kerningPairs.Count == 0)
			{
				kerningPairs.Add(new KerningPair(0u, 0u, 0f));
				return;
			}
			uint firstGlyph = kerningPairs.Last().firstGlyph;
			uint secondGlyph = kerningPairs.Last().secondGlyph;
			float xOffset = kerningPairs.Last().xOffset;
			kerningPairs.Add(new KerningPair(firstGlyph, secondGlyph, xOffset));
		}

		public int AddKerningPair(uint first, uint second, float offset)
		{
			_003CAddKerningPair_003Ec__AnonStorey0 _003CAddKerningPair_003Ec__AnonStorey = new _003CAddKerningPair_003Ec__AnonStorey0();
			_003CAddKerningPair_003Ec__AnonStorey.first = first;
			_003CAddKerningPair_003Ec__AnonStorey.second = second;
			int num = kerningPairs.FindIndex(_003CAddKerningPair_003Ec__AnonStorey._003C_003Em__0);
			if (num == -1)
			{
				kerningPairs.Add(new KerningPair(_003CAddKerningPair_003Ec__AnonStorey.first, _003CAddKerningPair_003Ec__AnonStorey.second, offset));
				return 0;
			}
			return -1;
		}

		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord firstAdjustments, uint second, GlyphValueRecord secondAdjustments)
		{
			_003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey1 _003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey = new _003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey1();
			_003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey.first = first;
			_003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey.second = second;
			int num = kerningPairs.FindIndex(_003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey._003C_003Em__0);
			if (num == -1)
			{
				kerningPairs.Add(new KerningPair(_003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey.first, firstAdjustments, _003CAddGlyphPairAdjustmentRecord_003Ec__AnonStorey.second, secondAdjustments));
				return 0;
			}
			return -1;
		}

		public void RemoveKerningPair(int left, int right)
		{
			_003CRemoveKerningPair_003Ec__AnonStorey2 _003CRemoveKerningPair_003Ec__AnonStorey = new _003CRemoveKerningPair_003Ec__AnonStorey2();
			_003CRemoveKerningPair_003Ec__AnonStorey.left = left;
			_003CRemoveKerningPair_003Ec__AnonStorey.right = right;
			int num = kerningPairs.FindIndex(_003CRemoveKerningPair_003Ec__AnonStorey._003C_003Em__0);
			if (num != -1)
			{
				kerningPairs.RemoveAt(num);
			}
		}

		public void RemoveKerningPair(int index)
		{
			kerningPairs.RemoveAt(index);
		}

		public void SortKerningPairs()
		{
			if (kerningPairs.Count > 0)
			{
				List<KerningPair> source = kerningPairs;
				if (_003C_003Ef__am_0024cache0 == null)
				{
					_003C_003Ef__am_0024cache0 = _003CSortKerningPairs_003Em__0;
				}
				IOrderedEnumerable<KerningPair> source2 = source.OrderBy(_003C_003Ef__am_0024cache0);
				if (_003C_003Ef__am_0024cache1 == null)
				{
					_003C_003Ef__am_0024cache1 = _003CSortKerningPairs_003Em__1;
				}
				kerningPairs = source2.ThenBy(_003C_003Ef__am_0024cache1).ToList();
			}
		}

		[CompilerGenerated]
		private static uint _003CSortKerningPairs_003Em__0(KerningPair s)
		{
			return s.firstGlyph;
		}

		[CompilerGenerated]
		private static uint _003CSortKerningPairs_003Em__1(KerningPair s)
		{
			return s.secondGlyph;
		}
	}
}
