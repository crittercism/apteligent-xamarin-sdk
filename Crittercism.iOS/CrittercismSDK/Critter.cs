using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace Crittercism
{
	public class Critter
	{
		public static void Init(string appId) {

			Crittercism._EnableWithAppID (appId);
			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("----LogUnhandledException --UnhandledException :");

				Console.WriteLine( "args.ExceptionObject.GetType() = " + args.ExceptionObject.GetType().ToString() );
				Console.Out.Flush();

				//if ( args.ExceptionObject.GetType().IsEquivalentTo( Type.GetType(S
				{
					System.Exception exception = (System.Exception)args.ExceptionObject;
					Critter.LogUnHandledException( exception );
				}

				Console.WriteLine("---- survived Logged an LogUnHandledException !!! ");
				Console.Out.Flush();

//				Console.WriteLine (args.ExceptionObject.GetType ());
				//				CrittercismSDK.Crittercism.LogUnhandledException( 
				//					args.ExceptionObject.GetType().ToString(),
				//					args.ExceptionObject.GetType().ToString(),
				//					Environment.StackTrace.ToString());
			};
				
		}

		public static void LogUnHandledException( System.Exception e )
		{
			Console.WriteLine (" LogUnHandledException " + e.ToString());
			return;
			CRCSharpException ex = new CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism._LogCSharpException (ex);
		}

		public static void LogHandledException (System.Exception e)
		{
			Console.WriteLine (" LogHandledException " + e.ToString());
			CRCSharpException ex = new CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism._LogCSharpException (ex);
		}

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			Crittercism.LeaveBreadcrumb (breadcrumb);
		}

		public static void SetMetadata (string value, string key)
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

