using System;

using System.Runtime.InteropServices;

namespace Crittercism
{
	public static class Crittercism
	{
		public static void EnableCrashReporting ( string appId )
		{
			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {
				Console.WriteLine("LogUnhandledException --UnhandledException :" + Environment.StackTrace);
				Console.WriteLine (args.ExceptionObject.GetType ());
				CrittercismSDK.Crittercism.LogUnhandledException( 
					args.ExceptionObject.GetType().ToString(),
					args.ExceptionObject.GetType().ToString(),
					Environment.StackTrace.ToString());
			};

			// Run your crash reporting library initialization code here--
			CrittercismSDK.Crittercism.EnableWithAppID( appId );

		}//EnableCrashReportingUnsafe

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			CrittercismSDK.Crittercism.LeaveBreadcrumb (breadcrumb);
		}

		public static void SetValue (string value, string key)
		{
			CrittercismSDK.Crittercism.SetValue (value, key);
		}

		public static string Username
		{
			set { CrittercismSDK.Crittercism.Username = value; }
		}

		public static bool DidCrashOnLastLoad
		{ 
			get {
				return CrittercismSDK.Crittercism.DidCrashOnLastLoad; 
			}
		}

		[DllImport ("libc")]
		private static extern int sigaction (Signal sig, IntPtr act, IntPtr oact);

		enum Signal { SIGBUS = 10, SIGSEGV = 11 }

		private static void EnableCrashReportingWithMonoSigRestore ( string appId )
		{

			IntPtr sigbus = Marshal.AllocHGlobal (512);
			IntPtr sigsegv = Marshal.AllocHGlobal (512);

			// Store Mono SIGSEGV and SIGBUS handlers
			sigaction (Signal.SIGBUS, IntPtr.Zero, sigbus);
			sigaction (Signal.SIGSEGV, IntPtr.Zero, sigsegv);

			// Enable crash reporting libraries
			EnableCrashReporting ( appId );

			// Restore Mono SIGSEGV and SIGBUS handlers
			sigaction (Signal.SIGBUS, sigbus, IntPtr.Zero);
			sigaction (Signal.SIGSEGV, sigsegv, IntPtr.Zero);

			Marshal.FreeHGlobal (sigbus);
			Marshal.FreeHGlobal (sigsegv);
		}//end EnableCrashReporting

	}
}

