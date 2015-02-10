using System;
using System.Drawing;

using Foundation;
using UIKit;

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

			Crittercism.Username = "MyUserName";

			ButtonAttachUserMeta.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.SetMetadata("Game Level","5");
			};

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				try {
					crashCustomException();
				} catch (System.Exception error) {
					Crittercism.LogHandledException(error);
				}
			};

			ButtonCrashCLR.TouchUpInside += (object sender, EventArgs e) => {
				crashDivideByZero();
				//crashNullReference();
				//crashIndexOutOfRange();
			};

			ButtonBeginTransaction.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.BeginTransaction("Transaction");
			};

			ButtonEndTransaction.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.EndTransaction("Transaction");
			};

			ButtonFailTransaction.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.FailTransaction("Transaction");
			};

			ButtonSetTransactionValue.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.SetTransactionValue("Transaction", 500);
				ButtonSetTransactionValue.SetTitle("Set value to 500", UIControlState.Normal);
			};

			ButtonGetTransactionValue.TouchUpInside += (object sender, EventArgs e) => {
				int value = Crittercism.GetTransactionValue("Transaction");
				ButtonGetTransactionValue.SetTitle(value.ToString(), UIControlState.Normal);
			};
		}

		private void crashDivideByZero()
		{
			int myNumber = 22;
			int divZero = 0;
			int result = myNumber / divZero;
			Console.WriteLine (result);
		}

		private void crashNullReference()
		{
			object o = null;
			o.GetHashCode ();
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

