using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CrittercismIOS;

namespace Sample.iOS
{
	partial class MetadataViewController : UIViewController
	{
		public MetadataViewController (IntPtr handle) : base (handle)
		{
		}

		partial void HelloWorldButton_TouchUpInside (UIButton sender)
		{
			Crittercism.LeaveBreadcrumb("Hello world");
		}

		partial void GoodbyeWorldButton_TouchUpInside (UIButton sender)
		{
			Crittercism.LeaveBreadcrumb("Goodbye world");
		}
			
		partial void SetUsernameButton_TouchUpInside (UIButton sender)
		{
			Crittercism.Username = "Bob";
		}

		partial void SetPlanButton_TouchUpInside (UIButton sender)
		{
			Crittercism.SetMetadata("Plan", "Paid");
		}
	}
}
