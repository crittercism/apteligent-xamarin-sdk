using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Crittercism;
using System.Net;
using System.IO;


namespace CrittercismSample.iOS
{
	public partial class CrittercismSample_iOSViewController : UIViewController
	{

		public CrittercismSample_iOSViewController (IntPtr handle) : base (handle)
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

			// Check for crach on lastLoad !
			Console.WriteLine( "- Crittercism.DidCrashOnLastLoad ? " + Crittercism.Crittercism.DidCrashOnLastLoad );
			if (Crittercism.Crittercism.DidCrashOnLastLoad == true) {

				new UIAlertView ("Done"
					, "Crittercism.Crittercism.DidCrashOnLastLoad is TRUE !"
					, null
					, "OK"
					, null).Show();
			}//end if DidCrashOnLastLoad == true

			// Attach Button Handlers
			ButtonAttachUserMetadata.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("Attach Metadata");
				Crittercism.Crittercism.SetValue("5","Game Level");

				new UIAlertView ("Metadata "
					, "Key = " + "5" + " Value = " + "Game Level"
					, null
					, "OK"
					, null).Show();
			};//end buttonAttachMetadata

			buttonCrashNative.TouchUpInside +=  (object sender, EventArgs e) => {
				Console.WriteLine("-Crash Native");
				divideByZero();
			};

			buttonNativeException.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("-Native Exception");
			};

			buttonCrashCLR.TouchUpInside +=  (object sender, EventArgs e) => {
				Console.WriteLine("-Crash CLR");

				//null reference exception = SIGSEGV signal at first
				try {
					Console.WriteLine("--Null Reference Exception-- try ");
					object o = null;
					o.GetHashCode ();
				} catch {
					// This Catch block will not be called if crash reporting is enabled, unless you restore sigV (Instead, the app will crash.)
					Console.WriteLine("--Null Reference Exception-- catch ");
				}//end catch

				Console.WriteLine("--Crash CLR Environment.StackTrace :" + Environment.StackTrace);
			};


			buttonCLRException.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine( "-CLR Exception");

				try {
					object o = null;
					o.GetHashCode ();
				} catch {
					Console.WriteLine(" catch ");
				}//end catch
			};

			buttonLeaveBreadcrumb.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine( "-Crittercism.LeaveBreadcrumb :  MyBreadCrumb" ); 
				Crittercism.Crittercism.LeaveBreadcrumb("MyBreadCrumb");

				new UIAlertView ("Crittercism.LeaveBreadcrumb "
					, "String = " + "MyBreadCrumb"
					, null
					, "OK"
					, null).Show();

				//Console.WriteLine( "- setAsyncBreadcrumbMode : True" );
				//Crittercism.Crittercism.setAsyncBreadcrumbMode(true);

				Console.WriteLine( "- Crittercism.Username = MyUserName" );
				Crittercism.Crittercism.Username = "MyUserName";

				Console.WriteLine( "- Crittercism.SetValue(,)" );
				Crittercism.Crittercism.SetValue("someValue","SomeKey");

			};

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

		// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		// Helper methods: raise exceptions, signals, generate network activity	
		// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		#region Helper methods

		public void divideByZero()
		{
			int i = 0;
			i = 2 / i;
		}//end divideByZero

		public void indexOutOfRange()
		{
			string[] arr	= new string[1];
			arr[2]	= "Crash";
		}//end indexOutOfRange

		public void customException()
		{
			throw new System.Exception("Custom Exception");
		}

		/*
		public void CoroutineCustomException()
		{
			StartCoroutine(MonoCorutineCrash());	
		}
		
		public void CoroutineNullException()
		{
			StartCoroutine(MonoCorutineNullCrash());	
		}
		*/

		private System.Collections.IEnumerator MonoCorutineNullCrash()
		{
			string crash = null;
			crash	= crash.ToLower();
			yield break;
		}

		private System.Collections.IEnumerator MonoCorutineCrash()
		{
			throw new System.Exception("Custom Coroutine Exception");
		}

		public void DoSomeNetworkRequest()
		{
			Console.WriteLine ("Do Some Network Request");

			var webClient = new WebClient();

			webClient.DownloadDataCompleted += (s, e) => {
				var bytes = e.Result; // get the downloaded data
				string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				string localFilename = "downloaded.png";
				string localPath = Path.Combine (documentsPath, localFilename);
				File.WriteAllBytes (localPath, bytes); // writes to local storage   

				Console.WriteLine(" Saved to local " + localPath );
			};

			var url = new Uri("http://xamarin.com/resources/design/home/devices.png");
			webClient.DownloadDataAsync(url);

		}//end DoSomeNetworkRequest
		#endregion

	}
}

