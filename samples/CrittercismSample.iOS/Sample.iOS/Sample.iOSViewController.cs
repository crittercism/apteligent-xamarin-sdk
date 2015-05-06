using System;
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

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonSetUsername.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.Username = "MrsCritter";
			};

			ButtonSetMetadata.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.SetMetadata("Game Level","5");
			};

			ButtonCrash.TouchUpInside += (object sender, EventArgs e) => {
				crashInnerException();
				//crashDivideByZero();
				//crashNullReference();
				//crashIndexOutOfRange();
			};

			ButtonHandledException.TouchUpInside += (object sender, EventArgs e) => {
				try {
					//crashCustomException();
					crashInnerException();
				} catch (Exception error) {
					Crittercism.LogHandledException(error);
				}
			};

			ButtonLogNetworkRequest.TouchUpInside += (object sender, EventArgs e) => {
				Random random = new Random();
				string[] methods = {"GET","POST","HEAD"};
				string method=methods[random.Next(methods.Length)];
				string[] urls = {"http://www.critterwebservice.com",
					"http://www.crittersearchengine.com/?ilove=critters",
					"http://www.critterdatingservice.com/nutlovers",
					"http://www.crittergourmetfood.com/nutsandberries.htm",
					"http://www.critterworldnews.com/summerfun",
					"http://www.crittermoviereviews.com/starring=mrscritter",
					"http://www.critterburrowdecor.com"};
				string url=urls[random.Next(urls.Length)];
				int[] responseCodes={200,202,400,404};
				int responseCode=responseCodes[random.Next(responseCodes.Length)];
				Crittercism.LogNetworkRequest(
					method,
					url,
					random.NextDouble(),
					random.Next(10000),
					random.Next(1000),
					responseCode,
					0);
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
			throw new Exception("Custom Exception");
		}

		public void DeepError(int n)
		{
			if (n == 0) {
				throw new Exception("Deep Inner Exception");
			} else {
				DeepError(n - 1);
			}
		}

		public void crashInnerException()
		{
			try {
				DeepError(4);
			} catch (Exception ie) {
				throw new Exception("Outer Exception", ie);
			}
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

