using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace Crittercism
{
	public class Critter
	{
		[DllImport("__Internal")]
		private static extern void Crittercism_EnableWithAppID (string appID);

		[DllImport("__Internal")]
		private static extern bool Crittercism_LogHandledException (string name, string reason, string stack, int platformId);

		[DllImport("__Internal")]
		private static extern void Crittercism_LogUnhandledException (string name, string reason, string stack, int platformId);

		public static void Init(string appId) {
			Crittercism_EnableWithAppID (appId);

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("----LogUnhandledException --UnhandledException :");

				Console.WriteLine( "args.ExceptionObject.GetType() = " + args.ExceptionObject.GetType().ToString() );
				Console.Out.Flush();

				System.Exception exception = (System.Exception)args.ExceptionObject;
				Critter.LogUnhandledException( exception );
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
			Crittercism.SetValue (value, key);
		}

		public static string SetUserName
		{
			set { Crittercism.Username = value; }
		}

		public static bool DidCrashOnLastLoad
		{
			get {
				return Crittercism.CrashedOnLastLoad; 
			}
		}

	}
}

