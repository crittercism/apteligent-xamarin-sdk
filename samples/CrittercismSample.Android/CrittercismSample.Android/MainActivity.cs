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

using CrittercismAndroid;

namespace CrittercismSample.Android
{
	[Activity (Label = "CrittercismSample.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Initialize Crittercism
			Crittercism.Init( ApplicationContext,  "537fc935b573f15751000002");

			//Set the Username
			Crittercism.SetUserName ("ANDROID_USER_NAME");

			checkDidCrash ();
			checkOptOutStatus (); 

			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {
				Crittercism.SetMetadata( "MyKey", "MyValue" );
				buttonAttachMetadata.Text = string.Format ("Metadata sent!");
			};

			/*
			Button buttonCrashNative = FindViewById<Button> (Resource.Id.buttonCrashNative);
			buttonCrashNative.Click += delegate {
				Crittercism.LeaveBreadcrumb( "Crash Native");
				crashNative();
			};
			
			Button buttonNativeException = FindViewById<Button> (Resource.Id.buttonNativeException);
			buttonNativeException.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Native Exception");
				nativeException();
			};
			*/

			Button buttonCLRException = FindViewById<Button> (Resource.Id.buttonCLRException);
			buttonCLRException.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb("CLR Exception");
				crashCLRException();
			};

			Button buttonCrashCLR = FindViewById<Button> (Resource.Id.buttonCrashCLR);
			buttonCrashCLR.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Crash CLR");
				crashCLR();
			};

			Button buttonLeaveBreadcrumb = FindViewById<Button> (Resource.Id.buttonBreadcrumb);
			buttonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
				buttonLeaveBreadcrumb.Text = string.Format( "just left a breadcrumb");
			};
			
		}//end onCreate

		public void crashCLR()
		{
			//throw new System.InvalidOperationException("Make a CLR exception");
			crashNullReference ();
		}//end crashCLR

		public void crashCLRException()
		{
			throw new System.Exception("Custom Exception");
			//throw new Exception("Crashed NET/CLR thread.");
		}//end crashCLRException


		private void crashNullReference()
		{
			object o = null;
			o.GetHashCode ();
		}

		public void crashDivideByZero()
		{
			int i = 0;
			i = 2 / i;
		}//end divideByZero

		public void crashIndexOutOfRange()
		{
			string[] arr	= new string[1];
			arr[2]	= "Crash";
		}//end indexOutOfRange


		// +++++++++++++++++++++++++++++++++++++++
		// Additional Crash & Exception
		// +++++++++++++++++++++++++++++++++++++++

		public void crashNative()
		{
			SetContentView(444444);
		}

		public void nativeException()
		{
			throw new Java.Lang.IllegalArgumentException();
		}

		public void crashMulti()
		{
			try
			{
				try
				{
					throw new System.ApplicationException("This is a nexted exception");
				}
				catch (Java.Lang.Exception e1)
				{
					throw new System.InvalidCastException("Level 1", e1);
				}
			}
			catch (Java.Lang.Exception e2)
			{
				throw new System.InvalidCastException("Level 2", e2);
			}
		}//end crashMulti


		public void crashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			} );
		}//end crashBackgroundThread

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}//end CrashAsync

		public void checkDidCrash() {

			if (Crittercism.DidCrashOnLastLoad() == true) {
				Toast.MakeText(this, "Crash On Last Load True", ToastLength.Short).Show();
			}
		}

		public void checkOptOutStatus() {

			Console.WriteLine ("Check the optout status =" + Com.Crittercism.App.Crittercism.OptOutStatus );
		}

	}
}


