using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Foundation;

namespace CrittercismIOS
{
	public partial class Crittercism
	{
		[DllImport("__Internal")]
		private static extern void Crittercism_EnableWithAppID (string appID, bool enableServiceMonitoring);

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

		[DllImport("__Internal")]
		private static extern void Crittercism_BeginTransaction(string name);

		[DllImport("__Internal")]
		private static extern void Crittercism_BeginTransactionWithValue(string name, int value);

		[DllImport("__Internal")]
		private static extern void Crittercism_EndTransaction(string name);

		[DllImport("__Internal")]
		private static extern void Crittercism_FailTransaction(string name);

		[DllImport("__Internal")]
		private static extern void Crittercism_SetTransactionValue(string name, int value);

		[DllImport("__Internal")]
		private static extern int Crittercism_GetTransactionValue(string name);

		[DllImport ("libc")]
		private static extern int sigaction (Signal sig, IntPtr act, IntPtr oact);

		//SIGILL , SIGINT , SIGTERM
		enum Signal {
			SIGABRT = 6,
			SIGFPE = 8,
			SIGBUS = 10,
			SIGSEGV = 11,
			SIGPIPE = 13
		}

		public static void Init(string appId) {

			IntPtr sigabrt = Marshal.AllocHGlobal (512);
			IntPtr sigfpe = Marshal.AllocHGlobal (512);
			IntPtr sigbus = Marshal.AllocHGlobal (512);
			IntPtr sigsegv = Marshal.AllocHGlobal (512);

			// When Crittercism is initialized, PLCrashReporter overwrites the Monoruntime's
			// signal handlers.  This is bad because the MonoRuntime uses signal handlers to
			// catch errors like DivideByZeroExceptions and NullPointerExceptions. How?
			// The byte code gets compiled down to assembly instructions which when executed,
			// trigger a signal that the runtime catches and subsequently turns into a C#
			// exception. Since we want to be able to catch these exceptions, we must not
			// let PLCrashReporter override the signals.  Rather than modify the iOS SDK to
			// do this, we save the signals handlers that are installed by Mono, initialize
			// Crittercism (which blows away Mono's signal handlers), and then we restore
			// Mono's signal handlers.
			//
			// XXX: Without this wonky signal saving code we would not be able to capture
			// NullPointerExceptions!

			sigaction (Signal.SIGABRT, IntPtr.Zero, sigabrt);
			sigaction (Signal.SIGFPE, IntPtr.Zero, sigfpe);
			sigaction (Signal.SIGBUS, IntPtr.Zero, sigbus);
			sigaction (Signal.SIGSEGV,IntPtr.Zero, sigsegv);

			// Disable service monitoring. There's issues with NSProxy
			Crittercism_EnableWithAppID (appId, false);

			// Restore or Destroy the handlers
			sigaction (Signal.SIGABRT, sigabrt, IntPtr.Zero);  		//RESTORE
			sigaction (Signal.SIGFPE, sigfpe, IntPtr.Zero);  		//RESTORE
			sigaction (Signal.SIGBUS, sigbus, IntPtr.Zero);			//RESTORE
			sigaction (Signal.SIGSEGV, sigsegv, IntPtr.Zero);		//RESTORE

			//Free sig structs
			Marshal.FreeHGlobal (sigabrt);
			Marshal.FreeHGlobal (sigfpe);
			Marshal.FreeHGlobal (sigbus);
			Marshal.FreeHGlobal (sigsegv);

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {
				// Register to get notified of unhandled C# exceptions

				Exception exception = (Exception)args.ExceptionObject;
				LogUnhandledException ( exception );

			};

		}

		// Crittercism-ios CRPluginException.h defines crPlatformId crXamarinId = 1 .
		private const int crXamarinId = 1;

		private static string StackTrace(System.Exception e)
		{
			// Allowing for the fact that the "name" and "reason" of the outermost
			// exception e are already shown in the Crittercism portal, we don't
			// need to repeat that bit of info.  However, for InnerException's, we
			// will include this information in the StackTrace .  The horizontal
			// lines (hyphens) separate InnerException's from each other and the
			// outermost Exception e .
			string answer = e.StackTrace;
			// Using seen for cycle detection to break cycling.
			List<System.Exception> seen = new List<System.Exception>();
			seen.Add(e);
			if (answer != null) {
				// There has to be some way of telling where InnerException ie stacktrace
				// ends and main Exception e stacktrace begins.  This is it.
				answer = ((e.GetType().FullName + " : " + e.Message + "\r\n")
					+ answer);
				System.Exception ie = e.InnerException;
				while ((ie != null) && (seen.IndexOf(ie) < 0)) {
					seen.Add(ie);
					answer = ((ie.GetType().FullName + " : " + ie.Message + "\r\n")
						+ (ie.StackTrace + "\r\n")
						+ answer);
					ie = ie.InnerException;
				}
			} else {
				answer = "";
			}
			return answer;
		}

		private static void LogUnhandledException(Exception e)
		{
			Crittercism_LogUnhandledException(e.GetType().FullName, e.Message, StackTrace(e), crXamarinId);
			NSDate date = NSDate.FromTimeIntervalSinceNow(2.0);
			NSRunLoop.Current.RunUntil(date);
		}

		public static void LogHandledException(Exception e)
		{
			if (e == null) {
				return;
			}
			Crittercism_LogHandledException(e.GetType().FullName, e.Message, StackTrace(e), crXamarinId);
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
			
		public static void BeginTransaction(string name)
		{
			Crittercism_BeginTransaction (name);
		}

		public static void BeginTransaction(string name, int value) 
		{
			Crittercism_BeginTransactionWithValue(name, value);
		}

		public static void EndTransaction(string name)
		{
			Crittercism_EndTransaction (name);
		}

		public static void FailTransaction(string name)
		{
			Crittercism_FailTransaction (name);
		}

		public static void SetTransactionValue(string name, int value)
		{
			Crittercism_SetTransactionValue (name, value);
		}

		public static int GetTransactionValue(string name)
		{
			return Crittercism_GetTransactionValue (name);
		}

	}
}

