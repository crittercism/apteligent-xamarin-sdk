using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//using Crittercism.Android;

using Com.Crittercism.App;
using System.Threading.Tasks;

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

			Crittercism.SetUsername ("ANDROID_USER_NAME");

			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button buttonAttachMetadata = FindViewById<Button> (Resource.Id.buttonAttachMeta);
			buttonAttachMetadata.Click += delegate {
				buttonAttachMetadata.Text = string.Format ("{0} clicks!", count++);
			};

			Button buttonCrashNative = FindViewById<Button> (Resource.Id.buttonCrashNative);
			buttonCrashNative.Click += delegate {
				buttonCrashNative.Text = string.Format( "button crash native " );
				SetContentView(444444);
			};

			Button buttonNativeException = FindViewById<Button> (Resource.Id.buttonNativeException);
			buttonNativeException.Click += delegate(object sender, EventArgs e) {
				buttonNativeException.Text = string.Format( "boom");

				try
				{
					try
					{
						throw new ApplicationException("This is a nexted exception");
					}
					catch (Exception e1)
					{
						throw new InvalidCastException("Level 1", e1);
					}
				}
				catch (Exception e2)
				{
					throw new InvalidCastException("Level 2", e2);
				}

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

		}//end onCreate

		public async Task CrashAsync()
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("Exception in task");
		}

	}
}


