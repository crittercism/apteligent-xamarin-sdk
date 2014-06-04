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

			// Check for crach on lastLoad !
			if (Crittercism.Crittercism.CrashedOnLastLoad == true) {
				new UIAlertView ("Done"
					, ".DidCrashOnLastLoad is TRUE !"
					, null
					, "OK"
					, null).Show();
			}

			ButtonAttachUserMeta.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.Crittercism.Username = "MyUserName";
				Crittercism.Crittercism.SetValue("5","Game Level");
			};

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonNativeException.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("-Native Exception");
			};

			ButtonCrashNative.TouchUpInside += (object sender, EventArgs e) => {
				crashDivideByZero();
			};

			ButtonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				//try {
				crashCustomException();
				//crashIndexOutOfRange();
				//} catch (IndexOutOfRangeException exception) {
				//	CrittercismSDK.Crittercism.LogHandledException(exception);
				//	}


			};

			ButtonCrashCLR.TouchUpInside += (object sender, EventArgs e) => {
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
		}

		public void crashIndexOutOfRange()
		{
			string[] arr = new string[1];
			arr[2]	= "Crash";
		}

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

