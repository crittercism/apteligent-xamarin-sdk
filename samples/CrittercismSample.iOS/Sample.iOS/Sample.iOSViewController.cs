using System;
using UIKit;
using CrittercismIOS;
using ModernHttpClient;
using System.Net.Http;

namespace Sample.iOS
{
	public partial class Sample_iOSViewController : UIViewController
	{
		public Sample_iOSViewController(IntPtr handle)
			: base(handle)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		#region View lifecycle

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			ButtonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			ButtonSetUsername.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.Username = "MrsCritter";
			};

			ButtonSetMetadata.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.SetMetadata("Game Level", "5");
			};

			ButtonCrash.TouchUpInside += (object sender, EventArgs e) => {
				CrashInnerException();
				//CrashDivideByZero();
				//CrashNullReference();
				//CrashIndexOutOfRange();
				//CrashCustomException();
			};

			ButtonHandledException.TouchUpInside += (object sender, EventArgs e) => {
				try {
					CrashInnerException();
				} catch (Exception error) {
					Crittercism.LogHandledException(error);
				}
			};

			ButtonLogNetworkRequest.TouchUpInside += (object sender, EventArgs e) => {
				Random random = new Random();
				string[] methods = { "GET", "POST", "HEAD" };
				string method = methods[random.Next(methods.Length)];
				string[] urls = {"http://www.critterwebservice.com",
					"http://www.crittersearchengine.com/?ilove=critters",
					"http://www.critterdatingservice.com/nutlovers",
					"http://www.crittergourmetfood.com/nutsandberries.htm",
					"http://www.critterworldnews.com/summerfun",
					"http://www.crittermoviereviews.com/starring=mrscritter",
					"http://www.critterburrowdecor.com"
				};
				string url = urls[random.Next(urls.Length)];
				int[] responseCodes = { 200, 202, 400, 404 };
				int responseCode = responseCodes[random.Next(responseCodes.Length)];
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
				Crittercism.BeginTransaction("Exercise");
			};

			ButtonEndTransaction.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.EndTransaction("Exercise");
			};

			ButtonFailTransaction.TouchUpInside += (object sender, EventArgs e) => {
				Crittercism.FailTransaction("Exercise");
			};

			ButtonSetTransactionValue.TouchUpInside += (object sender, EventArgs e) => {
				Random random = new Random();
				Crittercism.SetTransactionValue("Exercise", random.Next(1000));
				ButtonGetTransactionValue.SetTitle("Get Transaction Value", UIControlState.Normal);
			};

			ButtonGetTransactionValue.TouchUpInside += (object sender, EventArgs e) => {
				int value = Crittercism.GetTransactionValue("Exercise");
				ButtonGetTransactionValue.SetTitle(value.ToString(), UIControlState.Normal);
			};

		}

		private void CrashDivideByZero()
		{
			int myNumber = 22;
			int divZero = 0;
			int result = myNumber / divZero;
			Console.WriteLine(result);
		}

		private void CrashNullReference()
		{
			object o = null;
			o.GetHashCode();
		}

		public void CrashIndexOutOfRange()
		{
			string[] arr = new string[1];
			arr[2]	= "Crash";
		}

		public void CrashCustomException()
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

		public void CrashInnerException()
		{
			try {
				DeepError(4);
			} catch (Exception ie) {
				throw new Exception("Outer Exception", ie);
			}
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}
			
		partial void HttpGetButton_TouchUpInside (UIButton sender)
		{
			var httpClient = new HttpClient (new NativeMessageHandler ());

			var response = httpClient.GetAsync ("https://httpbin.org/status/418").Result;

			var responseContent = response.Content;

			string responseString = responseContent.ReadAsStringAsync ().Result;

			Console.WriteLine (responseString);
		}
		#endregion
	}
}

