using System;
using System.Runtime.InteropServices;

using MonoTouch.Foundation;

namespace CrittercismSDK
{

	public partial class Crittercism
	{
		public static void Init(string appId) {
			Crittercism._EnableWithAppID (appId);

			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("LogUnhandledException --UnhandledException :");
				Console.Out.Flush();

//				Console.WriteLine (args.ExceptionObject.GetType ());
				//				CrittercismSDK.Crittercism.LogUnhandledException( 
				//					args.ExceptionObject.GetType().ToString(),
				//					args.ExceptionObject.GetType().ToString(),
				//					Environment.StackTrace.ToString());
			};
				
		}

		static public void LogHandledException (System.Exception e)
		{
			CRCSharpException ex = new CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism._LogCSharpException (ex);
		}
			
	}
}

