using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		private const float fpsMeasurePeriod = 0.5f;

		private int m_FpsAccumulator;

		private float m_FpsNextPeriod;

		public int m_CurrentFps;

		private const string display = "FPS:{0}-{1} ";

		private Text m_Text;

		private void Start()
		{
			m_FpsNextPeriod = Time.realtimeSinceStartup + 0.5f;
			m_Text = GetComponent<Text>();
		}

		private void Update()
		{
			m_FpsAccumulator++;
			if (Time.realtimeSinceStartup > m_FpsNextPeriod)
			{
				m_CurrentFps = Mathf.RoundToInt((float)m_FpsAccumulator / 0.5f);
				m_FpsAccumulator = 0;
				m_FpsNextPeriod += 0.5f;
				m_Text.text = string.Format("FPS:{0}-{1} ", Mathf.RoundToInt(1f / Time.deltaTime), m_CurrentFps) + string.Format("总内存：" + ByteToM(Profiler.GetTotalAllocatedMemoryLong()) + "M堆内存：" + ByteToM(Profiler.GetMonoUsedSizeLong()) + "M");
			}
		}

		private float ByteToM(long byteCount)
		{
			return (float)byteCount / 1048576f;
		}
	}
}
