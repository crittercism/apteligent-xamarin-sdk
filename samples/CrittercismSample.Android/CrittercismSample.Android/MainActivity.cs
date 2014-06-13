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

//using Com.Crittercism.App;
using Crittercism.Android;

namespace CrittercismSample.Android
{
	[Activity (Label = "CrittercismSample.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Initialize Crittercism
			Crittercism.Android.Crittercism.Init( ApplicationContext,  "537fc935b573f15751000002");

			//Set the Username
			Crittercism.Android.Crittercism.SetUserName ("ANDROID_USER_NAME");

			checkDidCrash ();
			//checkOptOutStatus (); 

			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {
				Crittercism.Android.Crittercism.SetMetadata( "MyKey", "MyValue" );
				buttonAttachMetadata.Text = string.Format ("Metadata sent!");
			};

			Button buttonCrashNative = FindViewById<Button> (Resource.Id.buttonCrashNative);
			buttonCrashNative.Click += delegate {
				Crittercism.Android.Crittercism.LeaveBreadcrumb( "Crash Native");
				crashNative();
			};

			Button buttonNativeException = FindViewById<Button> (Resource.Id.buttonNativeException);
			buttonNativeException.Click += delegate(object sender, EventArgs e) {
				Crittercism.Android.Crittercism.LeaveBreadcrumb( "Native Exception");
				nativeException();
			};

			Button buttonCrashCLR = FindViewById<Button> (Resource.Id.buttonCrashCLR);
			buttonCrashCLR.Click += delegate(object sender, EventArgs e) {
				Crittercism.Android.Crittercism.LeaveBreadcrumb( "Crash CLR");
				crashCLR();
			};

			Button buttonLeaveBreadcrumb = FindViewById<Button> (Resource.Id.buttonBreadcrumb);
			buttonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.Android.Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
				buttonLeaveBreadcrumb.Text = string.Format( "just left a breadcrumb");
			};
			
		}//end onCreate

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

		public void crashCLR()
		{
			throw new System.InvalidOperationException("Make a CLR exception");
		}//end crashCLR

		public void crashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			} );
		}//end crashBackgroundThread

		public void crashCLRException()
		{
			throw new Exception("Crashed NET/CLR thread.");
		}//end crashCLRException

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}//end CrashAsync

		public void checkDidCrash() {
			if (Crittercism.Android.Crittercism.DidCrashOnLastLoad() == true) {
				Toast.MakeText(this, "Crash On Last Load True", ToastLength.Short).Show();
			}
		}

		public void checkOptOutStatus() {
			Console.WriteLine ("Request the optout status =" + Com.Crittercism.App.Crittercism.OptOutStatus );

			Console.WriteLine ("Request the optout status =" + Crittercism.Android.Crittercism.GGetOptOutStatus() );

			Console.WriteLine ("Request the optout status =" + Crittercism.Android.Crittercism.OptOutStatus );

			//Com.Crittercism.App.Crittercism ();
			//Crittercism.Android.Critter.GetOptOutStatus ();
		}

	}
}


