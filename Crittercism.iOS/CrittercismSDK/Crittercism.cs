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

		[DllImport ("libc")]
		private static extern int sigaction (Signal sig, IntPtr act, IntPtr oact);

		//SIGILL
		enum Signal { SIGABRT = 6, SIGBUS = 10, SIGSEGV = 11} 

		public static void Init(string appId) {

			Crittercism_EnableWithAppID (appId);

			// Destrory the SIGSEGV handler
			sigaction (Signal.SIGABRT, IntPtr.Zero, IntPtr.Zero);

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				System.Exception exception = (System.Exception)args.ExceptionObject;
				LogUnhandledException ( exception );
			};
		}

		private static void LogUnhandledException( System.Exception e )
		{
			Crittercism_LogUnhandledException (e.Message, e.Message, e.StackTrace, 1);

			NSDate date = NSDate.FromTimeIntervalSinceNow (2.0);
			NSRunLoop.Current.RunUntil (date);
		}

		public static void LogHandledException (System.Exception e)
		{
			Crittercism_LogHandledException (e.Message, e.Message, e.StackTrace, 1);
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

		//FOR DEBUG USE ONLY, NOT A PUBLIC API
		private static void InitWithSigRestore(string appId) 
		{

			IntPtr sigbus = Marshal.AllocHGlobal (512);
			IntPtr sigsegv = Marshal.AllocHGlobal (512);

			// Store Mono SIGSEGV and SIGBUS handlers
			sigaction (Signal.SIGBUS, IntPtr.Zero, sigbus);
			sigaction (Signal.SIGSEGV, IntPtr.Zero, sigsegv);

			// Enable crash reporting libraries
			Crittercism_EnableWithAppID (appId);

			// Restore Mono SIGSEGV and SIGBUS handlers
			sigaction (Signal.SIGBUS, sigbus, IntPtr.Zero);
			sigaction (Signal.SIGSEGV, sigsegv, IntPtr.Zero);

			Marshal.FreeHGlobal (sigbus);
			Marshal.FreeHGlobal (sigsegv);
		}//end InitWithSigRestore

	}
}

