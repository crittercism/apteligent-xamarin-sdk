using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace Crittercism.iOS
{
	public partial class Crittercism
	{
		[DllImport("__Internal")]
		private static extern void Crittercism_EnableWithAppID (string appID);

		[DllImport("__Internal")]
		private static extern bool Crittercism_LogHandledException (string name, string reason, string stack, int platformId);

		[DllImport("__Internal")]
		private static extern void Crittercism_LogUnhandledException (string name, string reason, string stack, int platformId);

		[DllImport("__Internal")]
		private static extern void Crittercism_SetValue(string value, string key);

		[DllImport("__Internal")]
		private static extern bool Crittercism_GetOptOutStatus();

		[DllImport("__Internal")]
		private static extern void Crittercism_SetOptOutStatus(bool status);

		public static void Init(string appId) {
			Crittercism_EnableWithAppID (appId);

			//remove sig abort handler 

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				System.Exception exception = (System.Exception)args.ExceptionObject;
				LogUnhandledException ( exception );
			};
		}

		private static void LogUnhandledException( System.Exception e )
		{
			Crittercism_LogUnhandledException (e.Message, e.Message, e.StackTrace, 1);
		}

		public static void LogHandledException (System.Exception e)
		{
			Crittercism_LogHandledException (e.Message, e.Message, e.StackTrace, 1);
		}

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			Crittercism.LeaveBreadcrumb (breadcrumb);
		}

		public static void SetMetadata (string key, string value)
		{
			Crittercism_SetValue (value, key);
		}

		public static void SetOptOutStatus(bool isOptedout)
		{
			Crittercism_SetOptOutStatus (isOptedout);
		}

		public static bool GetOptOutStatus()
		{
			return Crittercism_GetOptOutStatus ();
		}

		public static bool DidCrashOnLastLoad()
		{
			return DidCrashOnLastLoad ();
		}

	}
}

