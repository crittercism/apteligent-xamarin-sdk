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
	[Activity (Label = "CrittercismSample.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Initialize Crittercism
			//  AppId "Crittercism Android Library Internal Testing"
			Crittercism.Init( ApplicationContext,  "52e358a4400205569e000008");

			//Set the Username
			Crittercism.SetUserName ("ANDROID_USER_NAME");
			Crittercism.LeaveBreadcrumb("Xamarin Studio needs to be licensed.  Pay up!!!");

			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {
				Crittercism.SetMetadata( "MyKey", "MyValue" );
				buttonAttachMetadata.Text = string.Format ("Metadata sent!");
			};
				
			Button buttonHandledException = FindViewById<Button> (Resource.Id.buttonHandledException);
			buttonHandledException.Click += delegate(object sender, EventArgs e) {
				try {
					//throw new Exception();
					crashInnerException();
				} catch (System.Exception error){
					Crittercism.LogHandledException(error);
				}
			};

			Button buttonCrashCLR = FindViewById<Button> (Resource.Id.buttonCrashCLR);
			buttonCrashCLR.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Crash CLR");
				//crashCLR();
				crashInnerException();
			};

			Button buttonLeaveBreadcrumb = FindViewById<Button> (Resource.Id.buttonBreadcrumb);
			buttonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
				buttonLeaveBreadcrumb.Text = string.Format( "just left a breadcrumb");
			};

			Button buttonBeginTransaction = FindViewById<Button> (Resource.Id.buttonBeginTransaction);
			buttonBeginTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.BeginTransaction( "Android Transaction");
				buttonBeginTransaction.Text = string.Format( "just began a transaction");
			};

			Button buttonEndTransaction = FindViewById<Button> (Resource.Id.buttonEndTransaction);
			buttonEndTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.EndTransaction( "Android Transaction");
				buttonEndTransaction.Text = string.Format( "just ended a transaction");
			};

			Button buttonFailTransaction = FindViewById<Button> (Resource.Id.buttonFailTransaction);
			buttonFailTransaction.Click += delegate(object sender, EventArgs e) {
				Crittercism.FailTransaction( "Android Transaction");
				buttonFailTransaction.Text = string.Format( "just failed a transaction");
			};

			Button buttonSetTransactionValue = FindViewById<Button> (Resource.Id.buttonSetTransactionValue);
			buttonSetTransactionValue.Click += delegate(object sender, EventArgs e) {
				Crittercism.SetTransactionValue( "Android Transaction", 500);
				buttonSetTransactionValue.Text = string.Format( "just set transaction value to 500");
			};

			Button buttonGetTransactionValue = FindViewById<Button> (Resource.Id.buttonGetTransactionValue);
			buttonGetTransactionValue.Click += delegate(object sender, EventArgs e) {
				int value = Crittercism.GetTransactionValue( "Android Transaction");
				buttonGetTransactionValue.Text = string.Format("Value is: " + value.ToString());
			};
		}

		public void crashCLR()
		{
			crashNullReference ();
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
			string[] arr	= new string[1];
			arr[2]	= "Crash";
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

		// +++++++++++++++++++++++++++++++++++++++
		// Additional Crash & Exception
		// +++++++++++++++++++++++++++++++++++++++

		public void nativeException()
		{
			throw new Java.Lang.IllegalArgumentException();
		}

		public void crashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			} );
		}

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}
	}
}


