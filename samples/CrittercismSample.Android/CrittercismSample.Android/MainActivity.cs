using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Threading.Tasks;
using System.Threading;
using Org.Json;

//using Java.Lang;

using CrittercismAndroid;

namespace CrittercismSample.Android
{
	[Activity(Label = "CrittercismSample.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			// Initialize Crittercism
			Crittercism.Init(ApplicationContext, "YOUR APP ID GOES HERE");

			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

			Button ButtonLeaveBreadcrumb = FindViewById<Button>(Resource.Id.ButtonBreadcrumb);
			ButtonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb("My Breadcrumb");
			};

			Button ButtonSetUserName = FindViewById<Button>(Resource.Id.ButtonSetUserName);
			ButtonSetUserName.Click += delegate {
				Crittercism.SetUserName("MrsCritter");
			};

			Button ButtonSetMetadata = FindViewById<Button>(Resource.Id.ButtonSetMetadata);
			ButtonSetMetadata.Click += delegate {
				Crittercism.SetMetadata("Game Level", "5");
			};

			Button ButtonCrash = FindViewById<Button>(Resource.Id.ButtonCrash);
			ButtonCrash.Click += delegate(object sender, EventArgs e) {
				CrashInnerException();
				//CrashDivideByZero();
				//CrashNullReference();
				//CrashIndexOutOfRange();
				//CrashCustomException();
			};
				
			Button ButtonHandledException = FindViewById<Button>(Resource.Id.ButtonHandledException);
			ButtonHandledException.Click += delegate(object sender, EventArgs e) {
				try {
					CrashInnerException();
				} catch (System.Exception error) {
					Crittercism.LogHandledException(error);
				}
			};
				
			Button ButtonLogNetworkRequest = FindViewById<Button>(Resource.Id.ButtonLogNetworkRequest);
			ButtonLogNetworkRequest.Click += delegate(object sender, EventArgs e) {
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
					(long)(1000 * random.NextDouble()),
					random.Next(10000),
					random.Next(1000),
					responseCode,
					0);
			};

			Button ButtonBeginTransaction = FindViewById<Button>(Resource.Id.ButtonBeginTransaction);
			ButtonBeginTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.BeginUserflow("Exercise");
			};

			Button ButtonEndTransaction = FindViewById<Button>(Resource.Id.ButtonEndTransaction);
			ButtonEndTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.EndUserflow("Exercise");
			};

			Button ButtonFailTransaction = FindViewById<Button>(Resource.Id.ButtonFailTransaction);
			ButtonFailTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.FailUserflow("Exercise");
			};

			Button ButtonSetTransactionValue = FindViewById<Button>(Resource.Id.ButtonSetTransactionValue);
			Button ButtonGetTransactionValue = FindViewById<Button>(Resource.Id.ButtonGetTransactionValue);
			ButtonSetTransactionValue.Click += delegate(object sender, EventArgs e) {
				Random random = new Random();
				Crittercism.SetUserflowValue("Exercise", random.Next(1000));
			};
			ButtonGetTransactionValue.Click += delegate(object sender, EventArgs e) {
				int value = Crittercism.GetUserflowValue("Exercise");
				ButtonGetTransactionValue.Text = value.ToString();
			};
		}

		public void Crash()
		{
			CrashNullReference();
		}

		private void CrashNullReference()
		{
			object o = null;
			o.GetHashCode();
		}

		public void CrashDivideByZero()
		{
			int i = 0;
			i = 2 / i;
		}

		public void CrashIndexOutOfRange()
		{
			string[] arr	= new string[1];
			arr[2]	= "Crash";
		}

		public void DeepError(int n)
		{
			if (n == 0) {
				throw new CrittercismSampleException("Deep Inner Exception");
			} else {
				DeepError(n - 1);
			}
		}

		public void CrashInnerException()
		{
			try {
				DeepError(4);
			} catch (Exception ie) {
				throw new CrittercismSampleException("Outer Exception", ie);
			}
		}

		// +++++++++++++++++++++++++++++++++++++++
		// Additional Crash & Exception
		// +++++++++++++++++++++++++++++++++++++++

		public void nativeException()
		{
			throw new Java.Lang.IllegalArgumentException();
		}

		public void CrashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			});
		}

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}
	}
}


