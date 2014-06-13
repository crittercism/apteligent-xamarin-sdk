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
			base.DidReceiveMemoryWarning ();
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Check for crasch on lastLoad
			if (Crittercism.iOS.Crittercism.DidCrashOnLastLoad() == true) {
				new UIAlertView ("Done"
					, ".DidCrashOnLastLoad is TRUE !"
					, null
					, "OK"
					, null).Show();
			}

			//Crittercism.iOS.Crittercism.UserName = "MyUserName";

			ButtonAttachUserMeta.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.iOS.Crittercism.SetMetadata("Game Level","5");
			};

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.iOS.Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonNativeException.TouchUpInside += (object sender, EventArgs e) => {
				crashNativeException();
			};

			ButtonCrashNative.TouchUpInside += (object sender, EventArgs e) => {
				crashDivideByZero();
			};

			ButtonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.iOS.Crittercism.LogHandledException(new Exception("I'm an error"));
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

