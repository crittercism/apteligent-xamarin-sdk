using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sample.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			//Crittercism.Crittercism._EnableWithAppID("537b83b617878472d3000001");
			Crittercism.Critter.Init("537b83b617878472d3000001");
			return true;

			/*
			AppDomain.CurrentDomain.UnhandledException += (sender, args) => {

				Console.WriteLine("YACK LogUnhandledException --UnhandledException :");
				Console.WriteLine( "args.ExceptionObject.GetType() = " + args.ExceptionObject.GetType().ToString() );
				Console.Out.Flush();
					Console.WriteLine( " Log the LogUnHandledException with Crittercism");
					System.Exception exception = (System.Exception)args.ExceptionObject;
					LogUnHandledException( exception );

					Console.Out.Flush();
			};
			*/
		}

		/*
		private static void LogUnHandledException( System.Exception e )
		{
			Crittercism.CRCSharpException ex = new Crittercism.CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism.Crittercism._LogCSharpException (ex);
		}

		public static void LogHandledException (System.Exception e)
		{
			Crittercism.CRCSharpException ex = new Crittercism.CRCSharpException(e.Message, e.Message, e.StackTrace, 0, 1);
			Crittercism.Crittercism._LogCSharpException (ex);
		}
		*/
		
		public override UIWindow Window {
			get;
			set;
		}
		
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}
	}
}

