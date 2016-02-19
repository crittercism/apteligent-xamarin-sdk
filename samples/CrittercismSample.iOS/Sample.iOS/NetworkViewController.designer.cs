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
	[Register ("NetworkViewController")]
	partial class NetworkViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton manualNetworkRequestButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton modernHttpGetRequestButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton modernHttpPostRequestButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton modernHttpTimeoutButton { get; set; }

		[Action ("ManualNetworkRequestButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ManualNetworkRequestButton_TouchUpInside (UIButton sender);

		[Action ("ModernHttpGetRequestButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ModernHttpGetRequestButton_TouchUpInside (UIButton sender);

		[Action ("ModernHttpPostRequestButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ModernHttpPostRequestButton_TouchUpInside (UIButton sender);

		[Action ("ModernHttpTimeoutButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ModernHttpTimeoutButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (manualNetworkRequestButton != null) {
				manualNetworkRequestButton.Dispose ();
				manualNetworkRequestButton = null;
			}
			if (modernHttpGetRequestButton != null) {
				modernHttpGetRequestButton.Dispose ();
				modernHttpGetRequestButton = null;
			}
			if (modernHttpPostRequestButton != null) {
				modernHttpPostRequestButton.Dispose ();
				modernHttpPostRequestButton = null;
			}
			if (modernHttpTimeoutButton != null) {
				modernHttpTimeoutButton.Dispose ();
				modernHttpTimeoutButton = null;
			}
		}
	}
}
