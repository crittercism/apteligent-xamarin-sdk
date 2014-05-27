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
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			//Initialize Crittercism
			Crittercism.Initialize( ApplicationContext, "537fc935b573f15751000002");

			//Set the Username
			Crittercism.SetUsername ("ANDROID_USER_NAME");

			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {

				JSONObject jso = new JSONObject(
				);

				Crittercism.SetMetadata( jso );

				buttonAttachMetadata.Text = string.Format ("{0} Metadata sent!", count++);
			};

			Button buttonCrashNative = FindViewById<Button> (Resource.Id.buttonCrashNative);
			buttonCrashNative.Click += delegate {
				buttonCrashNative.Text = string.Format( "button crash native " );

				crashSomethingNative();
			};

			Button buttonNativeException = FindViewById<Button> (Resource.Id.buttonNativeException);
			buttonNativeException.Click += delegate(object sender, EventArgs e) {
				buttonNativeException.Text = string.Format( "boom");


				crashNative();

				//CrashAsync().Wait()

			};

			Button buttonCrashCLR = FindViewById<Button> (Resource.Id.buttonCrashCLR);
			buttonCrashCLR.Click += delegate(object sender, EventArgs e) {
				buttonCrashCLR.Text = string.Format( "boom");
				throw new InvalidOperationException("Make a CLR exception");
			};

			// ... 

			Button buttonLeaveBreadcrumb = FindViewById<Button> (Resource.Id.buttonBreadcrumb);
			buttonLeaveBreadcrumb.Click += delegate(object sender, EventArgs e) {
				Crittercism.LeaveBreadcrumb( "Android BreadCrumb");
				buttonLeaveBreadcrumb.Text = string.Format( "just left a breadcrumb");
			};



			// EXPERIMENTAL MASTODO http://stackoverflow.com/questions/19507452/how-to-handle-monodroid-uncaught-exceptions-globally-and-prevent-application-fro
			// 
			/*
			AppDomain.CurrentDomain.UnhandledException += (s,e)=>
			{
				System.Diagnostics.Debug.WriteLine("AppDomain.CurrentDomain.UnhandledException: {0}. IsTerminating: {1}", e.ExceptionObject, e.IsTerminating);
			};

			AndroidEnvironment.UnhandledExceptionRaiser += (s, e) =>
			{
				System.Diagnostics.Debug.WriteLine("AndroidEnvironment.UnhandledExceptionRaiser: {0}. IsTerminating: {1}", e.Exception, e.Handled);
				e.Handled = true;
			};

And then on button click I added the following code to raise both types of exceptions:

//foreground exception
throw new NullReferenceException("test nre from ui thread.");
//background exception
ThreadPool.QueueUserWorkItem(unused =>
{
    throw new NullReferenceException("test nre from back thread.");
});
			
			*/

		}//end onCreate

		public void crashSomethingNative()
		{
			SetContentView(444444);
		}

		public void crashNative()
		{
			//best way is to throw an exception 
			// ensures that you're testing the types of exceptions that the regular Android SDK handles
			throw new Java.Lang.IllegalArgumentException();
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

		public void crashBackgroundThread()
		{
			ThreadPool.QueueUserWorkItem(o => { 
				throw new Exception("Crashed Background thread."); 
			} );
		}//end crashBackgroundThread

		public void crashCLRException()
		{
			throw new Exception("Crashed NET/CLR thread.");
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

		}
		*/

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}

	}
}


