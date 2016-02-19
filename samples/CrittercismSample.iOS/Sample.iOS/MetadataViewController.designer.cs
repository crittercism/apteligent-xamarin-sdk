// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sample.iOS
{
	[Register ("MetadataViewController")]
	partial class MetadataViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton goodbyeWorldButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton helloWorldButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton setPlanButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton setUsernameButton { get; set; }

		[Action ("GoodbyeWorldButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void GoodbyeWorldButton_TouchUpInside (UIButton sender);

		[Action ("HelloWorldButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HelloWorldButton_TouchUpInside (UIButton sender);

		[Action ("SetPlanButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetPlanButton_TouchUpInside (UIButton sender);

		[Action ("SetUsernameButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetUsernameButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (goodbyeWorldButton != null) {
				goodbyeWorldButton.Dispose ();
				goodbyeWorldButton = null;
			}
			if (helloWorldButton != null) {
				helloWorldButton.Dispose ();
				helloWorldButton = null;
			}
			if (setPlanButton != null) {
				setPlanButton.Dispose ();
				setPlanButton = null;
			}
			if (setUsernameButton != null) {
				setUsernameButton.Dispose ();
				setUsernameButton = null;
			}
		}
	}
}
