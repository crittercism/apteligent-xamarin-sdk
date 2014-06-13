using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace CrittercismIOS
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

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("----LogUnhandledException --UnhandledException :");

				Console.WriteLine( "args.ExceptionObject.GetType() = " + args.ExceptionObject.GetType().ToString() );
				Console.Out.Flush();

				System.Exception exception = (System.Exception)args.ExceptionObject;
				Crittercism.LogUnhandledException( exception );

				Console.WriteLine("---- survived Logged an LogUnHandledException !!! ");
				Console.Out.Flush();

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

		public static void SetMetadata (string value, string key)
		{
			Crittercism_SetValue (value, key);
		}

		public bool OptOutStatus
		{
			get { return Crittercism_GetOptOutStatus (); }
			set { Crittercism_SetOptOutStatus (value); }
		}


	}
}

