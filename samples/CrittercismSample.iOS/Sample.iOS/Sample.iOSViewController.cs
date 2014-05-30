using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sample.iOS
{
	public partial class Sample_iOSViewController : UIViewController
	{
		public Sample_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CrittercismSDK.myClass.test ();
			//CrittercismSDK.yack.foo();
			
			// Check for crach on lastLoad !
			if (Crittercism.Crittercism.DidCrashOnLastLoad == true) {
				new UIAlertView ("Done"
					, ".DidCrashOnLastLoad is TRUE !"
					, null
					, "OK"
					, null).Show();
			}

			ButtonAttachUserMeta.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("Attach User Metadata ");

				Crittercism.Crittercism.SetValue("5","Game Level");

				new UIAlertView ("Metadata "
					, "Key = " + "5" + " Value = " + "Game Level"
					, null
					, "OK"
					, null).Show();
			};

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("Leave Breadcrumb ");

				Crittercism.Crittercism.LeaveBreadcrumb("MyBreadCrumb");

				Crittercism.Crittercism.Username = "MyUserName";

				Crittercism.Crittercism.SetValue("someValue","SomeKey");

				new UIAlertView ("Crittercism.LeaveBreadcrumb "
					, "String = " + "MyBreadCrumb"
					, null
					, "OK"
					, null).Show();
			};

			ButtonNativeException.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("-Native Exception");
			};

			ButtonCrashNative.TouchUpInside += (object sender, EventArgs e) => {
				crashDivideByZero();
			};

			ButtonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				crashCustomException();
			};

			ButtonCrashCLR.TouchUpInside += (object sender, EventArgs e) => {

				/*
				try
				{
					crashIndexOutOfRange();
				}
				catch( Exception ex )
				{
					Console.WriteLine( "caught exception" + ex.ToString() );
					//CrittercismSDK.Crittercism.LogHandledException( ex );
					CrittercismSDK.Crittercism.LogUnhandledException( "name", "reason", Environment.StackTrace );
				}
				*/
				crashIndexOutOfRange();
			};
			
		}

		private void crashNullReference()
		{
			object o = null;
			o.GetHashCode ();
		}

		public void crashDivideByZero()
		{
			int i = 0;
			i = 2 / i;
		}//end divideByZero

		public void crashIndexOutOfRange()
		{
			string[] arr = new string[1];
			arr[2]	= "Crash";
		}//end indexOutOfRange

		public void crashCustomException()
		{
			throw new System.Exception("Custom Exception");
		}

		/*
		public void CoroutineCustomException()
		{
			StartCoroutine(MonoCorutineCrash());	
		}
		
		public void CoroutineNullException()
		{
			StartCoroutine(MonoCorutineNullCrash());	
		}
		*/

		private System.Collections.IEnumerator crashMonoCorutineNullCrash()
		{
			string crash = null;
			crash	= crash.ToLower();
			yield break;
		}

		private System.Collections.IEnumerator crashMonoCorutineCrash()
		{
			throw new System.Exception("Custom Coroutine Exception");
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

