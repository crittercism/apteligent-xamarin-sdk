using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ModernHttpClient;
using System.Net.Http;
using CrittercismIOS;

namespace Sample.iOS
{
	partial class NetworkViewController : UIViewController
	{
		public NetworkViewController (IntPtr handle) : base (handle)
		{
		}

		partial void ModernHttpGetRequestButton_TouchUpInside (UIButton sender)
		{
			// Crittercism will automatically log performance information about this network request.
			// No action is required on your part.

			var httpClient = new HttpClient (new NativeMessageHandler ());

			var response = httpClient.GetAsync ("https://httpbin.org/status/418").Result;

			var responseContent = response.Content;

			string responseString = responseContent.ReadAsStringAsync ().Result;

			Console.WriteLine (responseString);
		}

		partial void ModernHttpPostRequestButton_TouchUpInside (UIButton sender)
		{
			var httpClient = new HttpClient (new NativeMessageHandler ());

			HttpContent content = new StringContent ("crittercism post test");

			httpClient.PostAsync ("https://httpbin.org/post", content);
		}

		partial void ModernHttpTimeoutButton_TouchUpInside (UIButton sender)
		{
			HttpClient httpClient = new HttpClient (new NativeMessageHandler ());
			httpClient.Timeout = new TimeSpan (0, 0, 1);

			try {
				var response = httpClient.GetAsync ("https://httpbin.org/delay/3").Result;

				var responseContent = response.Content;

				string responseString = responseContent.ReadAsStringAsync ().Result;

				Console.WriteLine (responseString);
			} catch (Exception expected) {
			}
		}

		partial void ManualNetworkRequestButton_TouchUpInside (UIButton sender)
		{
			Random random = new Random ();
			string[] methods = { "GET", "POST", "HEAD" };
			string method = methods [random.Next (methods.Length)];
			string[] urls = {"http://www.critterwebservice.com",
				"http://www.crittersearchengine.com/?ilove=critters",
				"http://www.critterdatingservice.com/nutlovers",
				"http://www.crittergourmetfood.com/nutsandberries.htm",
				"http://www.critterworldnews.com/summerfun",
				"http://www.crittermoviereviews.com/starring=mrscritter",
				"http://www.critterburrowdecor.com"
			};
			string url = urls [random.Next (urls.Length)];
			int[] responseCodes = { 200, 202, 400, 404 };
			int responseCode = responseCodes [random.Next (responseCodes.Length)];
			Crittercism.LogNetworkRequest (
				method,
				url,
				random.NextDouble (),
				random.Next (10000),
				random.Next (1000),
				responseCode,
				0);
		}
	}
}
