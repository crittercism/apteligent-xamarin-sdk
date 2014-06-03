using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Com.Crittercism.App;
using System.Threading.Tasks;
using System.Threading;
using Org.Json;

namespace CrittercismSample.Android
{
	[Activity (Label = "CrittercismSample.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//Initialize Crittercism
			Crittercism.Initialize( ApplicationContext, "537fc935b573f15751000002");

			//Appdomain Exception handlers ???
			AppDomain.CurrentDomain.UnhandledException += (s,e)=>
			{
				Console.WriteLine("-- AppDomain.CurrentDomain.UnhandledException: {0}. IsTerminating: {1}", e.ExceptionObject, e.IsTerminating);
				//Crittercism.LogHandledException( (Java.Lang.Exception) e.ExceptionObject );
			};
			AndroidEnvironment.UnhandledExceptionRaiser += (s, e) =>
			{
				Console.WriteLine("-- AndroidEnvironment.UnhandledExceptionRaiser: {0}. IsTerminating: {1}", e.Exception, e.Handled);
				e.Handled = true;
			};


			//Set the Username
			Crittercism.SetUsername ("ANDROID_USER_NAME");

			getOptOutStatus ();

			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {

				JSONObject jso = new JSONObject(
				);

				Crittercism.SetMetadata( jso );

				buttonAttachMetadata.Text = string.Format ("Metadata sent!");
			};

			Button buttonCrashNative = FindViewById<Button> (Resource.Id.buttonCrashNative);
			buttonCrashNative.Click += delegate {
				crashNative();
			};

			Button buttonNativeException = FindViewById<Button> (Resource.Id.buttonNativeException);
			buttonNativeException.Click += delegate(object sender, EventArgs e) {
				nativeException();
			};

			Button buttonCrashCLR = FindViewById<Button> (Resource.Id.buttonCrashCLR);
			buttonCrashCLR.Click += delegate(object sender, EventArgs e) {
				crashCLR();
			};

			Button buttonLeaveBreadcrumb = FindViewById<Button> (Resource.Id.buttonBreadcrumb);
			buttonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
				buttonLeaveBreadcrumb.Text = string.Format( "just left a breadcrumb");
			};
			
		}//end onCreate

		public void crashNative()
		{
			try
			{
				SetContentView(444444);
			}
			catch ( Java.Lang.Exception ex ) {
				Crittercism.LogHandledException (ex);
			}
		}

		public void nativeException()
		{
			try
			{
				throw new Java.Lang.IllegalArgumentException();
			}
			catch ( Java.Lang.Exception ex ) {
				Crittercism.LogHandledException (ex);
			}
		}

		public void crashMulti()
		{
			try
			{
				try
				{
					throw new ApplicationException("This is a nexted exception");
				}
				catch (Java.Lang.Exception e1)
				{
					throw new InvalidCastException("Level 1", e1);
				}
			}
			catch (Java.Lang.Exception e2)
			{
				throw new InvalidCastException("Level 2", e2);
			}
		}//end crashMulti

		public void crashCLR()
		{
			try{
				throw new InvalidOperationException("Make a CLR exception");
			}
			catch ( Java.Lang.Exception ex ) {
				Crittercism.LogHandledException (ex);
			}
		}//end crashCLR

		public void crashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			} );
		}//end crashBackgroundThread

		public void crashCLRException()
		{
			try{
				throw new Exception("Crashed NET/CLR thread.");
			}
			catch ( Java.Lang.Exception ex ) {
				Console.WriteLine ("Crash CLR Exception");
				Crittercism.LogHandledException (ex);
			}
		}//end crashCLRException

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}//end CrashAsync

		public void getOptOutStatus() {

			Console.WriteLine ("Request the optout status ");

			ICritterCallback cb = new MyCritterCB ();
			CritterUserDataRequest request = new CritterUserDataRequest (cb);
			request.RequestOptOutStatus ();
		}
		/* 

As a hack for now im implementing the exception handlers for android as per this blog post then calling Crittercism.LogHandledException(Throwable.FromException(e.Exception)); from inside both the events.

It works, but im using Crittercism's handled exceptions for unhandled exceptions.. So when I want to send up real "HandledExceptions" they will be lost in the mess.



		 */

		/*
		public boolean getOptOutStatus() {

			final ConditionVariable condVar = new ConditionVariable(false);


			CritterCallback cb = new CritterCallback() {


				@Override public void onCritterDataReceived(CritterUserData userData) {

					isOptedOut = userData.isOptedOut();

					condVar.open();

				}

			};


			// Instantiate data request object, and specify that it should include

			// information on whether the has opted out.

			CritterUserDataRequest request = new CritterUserDataRequest(cb)

				.requestOptOutStatus()

				.requestDidCrashOnLastLoad();



			request.makeRequest();

			condVar.block();



			return isOptedOut;



			// EXPERIMENTAL MASTODO http://stackoverflow.com/questions/19507452/how-to-handle-monodroid-uncaught-exceptions-globally-and-prevent-application-fro
			// 
			/*

And then on button click I added the following code to raise both types of exceptions:

//foreground exception
throw new NullReferenceException("test nre from ui thread.");
//background exception
ThreadPool.QueueUserWorkItem(unused =>
{
    throw new NullReferenceException("test nre from back thread.");
});


		}
		*/


	}
}


