using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Networking;

namespace UnityEngine.Analytics
{
	public class DataPrivacy
	{
		[Serializable]
		internal struct UserPostData
		{
			public string appid;

			public string userid;

			public long sessionid;

			public string platform;

			public uint platformid;

			public string sdk_ver;

			public bool debug_device;

			public string deviceid;

			public string plugin_ver;
		}

		[Serializable]
		internal struct TokenData
		{
			public string url;

			public string token;
		}

		[CompilerGenerated]
		private sealed class _003CFetchPrivacyUrl_003Ec__AnonStorey0
		{
			internal UnityWebRequest www;

			internal Action<string> failure;

			internal Action<string> success;

			internal void _003C_003Em__0(AsyncOperation async2)
			{
				string text = www.downloadHandler.text;
				if (!string.IsNullOrEmpty(www.error) || string.IsNullOrEmpty(text))
				{
					string errorString = getErrorString(www);
					if (failure != null)
					{
						failure(errorString);
					}
					return;
				}
				TokenData tokenData = default(TokenData);
				tokenData.url = string.Empty;
				try
				{
					tokenData = JsonUtility.FromJson<TokenData>(text);
				}
				catch (Exception ex)
				{
					if (failure != null)
					{
						failure(ex.ToString());
					}
				}
				success(tokenData.url);
			}
		}

		private const string kVersion = "3.0.0";

		private const string kVersionString = "DataPrivacyPackage/3.0.0";

		internal const string kBaseUrl = "https://data-optout-service.uca.cloud.unity3d.com";

		private const string kTokenUrl = "https://data-optout-service.uca.cloud.unity3d.com/token";

		internal static UserPostData GetUserData()
		{
			UserPostData result = default(UserPostData);
			result.appid = Application.cloudProjectId;
			result.userid = AnalyticsSessionInfo.userId;
			result.sessionid = AnalyticsSessionInfo.sessionId;
			result.platform = Application.platform.ToString();
			result.platformid = (uint)Application.platform;
			result.sdk_ver = Application.unityVersion;
			result.debug_device = Debug.isDebugBuild;
			result.deviceid = SystemInfo.deviceUniqueIdentifier;
			result.plugin_ver = "DataPrivacyPackage/3.0.0";
			return result;
		}

		private static string GetUserAgent()
		{
			string format = "UnityPlayer/{0} ({1}/{2}{3} {4})";
			return string.Format(format, Application.unityVersion, Application.platform.ToString(), (uint)Application.platform, (!Debug.isDebugBuild) ? string.Empty : "-dev", "DataPrivacyPackage/3.0.0");
		}

		private static string getErrorString(UnityWebRequest www)
		{
			string text = www.downloadHandler.text;
			string text2 = www.error;
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "Empty response";
			}
			if (!string.IsNullOrEmpty(text))
			{
				text2 = text2 + ": " + text;
			}
			return text2;
		}

		public static void FetchPrivacyUrl(Action<string> success, Action<string> failure = null)
		{
			_003CFetchPrivacyUrl_003Ec__AnonStorey0 _003CFetchPrivacyUrl_003Ec__AnonStorey = new _003CFetchPrivacyUrl_003Ec__AnonStorey0();
			_003CFetchPrivacyUrl_003Ec__AnonStorey.failure = failure;
			_003CFetchPrivacyUrl_003Ec__AnonStorey.success = success;
			string s = JsonUtility.ToJson(GetUserData());
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			UploadHandlerRaw uploadHandlerRaw = new UploadHandlerRaw(bytes);
			uploadHandlerRaw.contentType = "application/json";
			_003CFetchPrivacyUrl_003Ec__AnonStorey.www = UnityWebRequest.Post("https://data-optout-service.uca.cloud.unity3d.com/token", string.Empty);
			_003CFetchPrivacyUrl_003Ec__AnonStorey.www.uploadHandler = uploadHandlerRaw;
			_003CFetchPrivacyUrl_003Ec__AnonStorey.www.SetRequestHeader("User-Agent", GetUserAgent());
			UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = _003CFetchPrivacyUrl_003Ec__AnonStorey.www.SendWebRequest();
			unityWebRequestAsyncOperation.completed += _003CFetchPrivacyUrl_003Ec__AnonStorey._003C_003Em__0;
		}
	}
}
