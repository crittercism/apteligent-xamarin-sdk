using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using CrittercismIOS;

namespace Sample.iOS
{
	public partial class Sample_iOSViewController : UIViewController
	{
		public Sample_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Check for crasch on lastLoad
			if (Crittercism.CrashedOnLastLoad == true) {
				new UIAlertView ("Done"
					, ".DidCrashOnLastLoad is TRUE !"
					, null
					, "OK"
					, null).Show();
			}

			ButtonAttachUserMeta.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.Username = "MyUserName";
				Crittercism.SetMetadata("5","Game Level");
			};

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonNativeException.TouchUpInside += (object sender, EventArgs e) => {
				crashNativeException();
			};

			ButtonCrashNative.TouchUpInside += (object sender, EventArgs e) => {
				crashDivideByZero();
			};

			ButtonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.LogHandledException(new Exception("I'm an error"));
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

		public void crashNativeException()
		{
			string[] arr = new string[1];
			arr[2]	= "Crash";
		}//end crashNativeException

		public void crashCustomException()
		{
			throw new System.Exception("Custom Exception");
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

