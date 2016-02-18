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

		#region View Lifecycle

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
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
			
		#endregion

		#region Crash Generation

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

		#endregion

		#region User Interaction

		partial void LeaveBreadcrumbButton_TouchUpInside (UIButton sender)
		{
			Crittercism.LeaveBreadcrumb("My Breadcrumb");
		}

		partial void SetUsernameButton_TouchUpInside (UIButton sender)
		{
			Crittercism.Username = "MrsCritter";
		}

		partial void SetMetadataButton_TouchUpInside (UIButton sender)
		{
			Crittercism.SetMetadata("Game Level", "5");
		}
			
		partial void CrashButton_TouchUpInside (UIButton sender)
		{
			CrashInnerException();
			//CrashDivideByZero();
			//CrashNullReference();
			//CrashIndexOutOfRange();
			//CrashCustomException();
		}

		partial void HandledExceptionButton_TouchUpInside (UIButton sender)
		{
			try {
				CrashInnerException();
			} catch (Exception error) {
				Crittercism.LogHandledException(error);
			}
		}

		partial void LogNetworkRequestButton_TouchUpInside (UIButton sender)
		{
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
		}

		partial void BeginUserflowButton_TouchUpInside (UIButton sender)
		{
			Crittercism.BeginUserflow("Exercise");
		}

		partial void EndUserflowButton_TouchUpInside (UIButton sender)
		{
			Crittercism.EndUserflow("Exercise");
		}

		partial void FailUserflowButton_TouchUpInside (UIButton sender)
		{
			Crittercism.FailUserflow("Exercise");
		}
			
		partial void SetUserflowValueButton_TouchUpInside (UIButton sender)
		{
			Random random = new Random();
			Crittercism.SetUserflowValue("Exercise", random.Next(1000));
		}

		partial void GetUserflowValueButton_TouchUpInside (UIButton sender)
		{
			int value = Crittercism.GetUserflowValue("Exercise");
			GetUserflowValueButton.SetTitle(value.ToString(), UIControlState.Normal);
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

