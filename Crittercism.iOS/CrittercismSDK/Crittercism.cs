using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace Crittercism
{

	public partial class Crittercism
	{
		public static void Init(string appId) {

			Crittercism._EnableWithAppID (appId);

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("LogUnhandledException --UnhandledException :");

				Console.WriteLine( "args.ExceptionObject.GetType() = " + args.ExceptionObject.GetType().ToString() );
				Console.Out.Flush();

				//if ( args.ExceptionObject.GetType().IsEquivalentTo( Type.GetType(S
				{
					Console.WriteLine( " Log the LogUnHandledException with Crittercism");
					System.Exception exception = (System.Exception)args.ExceptionObject;
					LogUnHandledException( exception );

					Console.Out.Flush();

				}

//				Console.WriteLine (args.ExceptionObject.GetType ());
				//				CrittercismSDK.Crittercism.LogUnhandledException( 
				//					args.ExceptionObject.GetType().ToString(),
				//					args.ExceptionObject.GetType().ToString(),
				//					Environment.StackTrace.ToString());
			};
				
		}

		private static void LogUnHandledException( System.Exception e )
		{
			CRCSharpException ex = new CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism._LogCSharpException (ex);
		}

		public static void LogHandledException (System.Exception e)
		{
			CRCSharpException ex = new CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism._LogCSharpException (ex);
		}

		public static void myLeaveBreadcrumb (string breadcrumb)
		{
			Crittercism.LeaveBreadcrumb (breadcrumb);
		}

		public static void mySetValue (string value, string key)
		{
			Crittercism.SetValue (value, key);
		}

		public static string myUsername
		{
			set { Crittercism.Username = value; }
		}

		/*
		public static bool myDidCrashOnLastLoad
		{
			get {
				return Crittercism.DidCrashOnLastLoad; 
			}
		}
		*/

		/*
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
		*/
			
	}
}

