using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

using System.Runtime.InteropServices;

using Crittercism;

namespace CrittercismXam
{
	public static class CrashReporting
	{
		// http://stackoverflow.com/questions/14499334/how-to-prevent-ios-crash-reporters-from-crashing-monotouch-apps/

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

			// - sigabrt MATT TODO
			// sigabrt_signal_handler
			/* 
			 * 
			 * https://bugzilla.xamarin.com/show_bug.cgi?id=4120
			 * http://stackoverflow.com/questions/14499334/how-to-prevent-ios-crash-reporters-from-crashing-monotouch-apps/
			 * http://stackoverflow.com/questions/17131045/xamarin-ios-crashs-without-any-exception
			 * 
			 * 
			 * Mono doesn't seem to be raising a SIGABRT when it get a SIGSEGV from unmanaged code.
			 * 
			 * this means the mono runtime tried to tell you something before the crash. 
			 * You should be able to see this in the console log (inside Xcode). 
			 * 
			 * This was often due to to a lack of trampoline. The exact type of trampolines, 0, 1 or 2, would be specified in the logs.
			 * 
			 * http://docs.xamarin.com/ios/troubleshooting#Ran_out_of_trampolines_of_type_0 http://docs.xamarin.com/ios/troubleshooting#Ran_out_of_trampolines_of_type_1 http://docs.xamarin.com/ios/troubleshooting#Ran_out_of_trampolines_of_type_2
			 * MonoTouch 6.0.8 removed this limitation. Note that it's always helpful, when posting any crash, to tell all software/versions you're using. MonoDevelop about dialog can give such list to you (easy to copy/paste).
			 * 
			 * Got a SIGABRT while executing native code. This usually indicates
			 * a fatal error in the mono runtime or one of the native libraries 
			 * used by your application.
			 * 
			 * Got a SIGABRT while executing native code. This usually indicates
			 * a fatal error in the mono runtime or one of the native libraries 
			 * used by your application.
			 * 
			 * 
			 * Found an error message on the device log.  Looks like this SIGABRT is being caused by a 
			 * lack of type 2 trampolines.  Any way to get that written to the debugger?
			 */

			// Enable crash reporting libraries
			EnableCrashReporting ( appId );

			// Restore Mono SIGSEGV and SIGBUS handlers
			sigaction (Signal.SIGBUS, sigbus, IntPtr.Zero);
			sigaction (Signal.SIGSEGV, sigsegv, IntPtr.Zero);

			Marshal.FreeHGlobal (sigbus);
			Marshal.FreeHGlobal (sigsegv);
		}//end EnableCrashReporting

		public static void EnableCrashReporting ( string appId )
		{

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {
				Console.WriteLine("--UnhandledException :" + Environment.StackTrace);
				Console.WriteLine (args.ExceptionObject.GetType ());
				Crittercism.Crittercism.LogUnhandledException( 
					args.ExceptionObject.GetType().ToString(),
					args.ExceptionObject.GetType().ToString(),
					Environment.StackTrace.ToString());
			};

			// Run your crash reporting library initialization code here--
			Crittercism.Crittercism.EnableWithAppID("5342d5a70ee9483d74000007");
		}//EnableCrashReportingUnsafe

	}
}

