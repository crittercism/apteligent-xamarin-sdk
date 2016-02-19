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
	[Register ("UserflowViewController")]
	partial class UserflowViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton beginLoginButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton beginPaymentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton endLoginButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton endPaymentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton failLoginButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton failPaymentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton setLoginValueButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton setPaymentValueButton { get; set; }

		[Action ("BeginLoginButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BeginLoginButton_TouchUpInside (UIButton sender);

		[Action ("BeginPaymentButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BeginPaymentButton_TouchUpInside (UIButton sender);

		[Action ("EndLoginButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void EndLoginButton_TouchUpInside (UIButton sender);

		[Action ("EndPaymentButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void EndPaymentButton_TouchUpInside (UIButton sender);

		[Action ("FailLoginButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void FailLoginButton_TouchUpInside (UIButton sender);

		[Action ("FailPaymentButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void FailPaymentButton_TouchUpInside (UIButton sender);

		[Action ("SetLoginValueButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetLoginValueButton_TouchUpInside (UIButton sender);

		[Action ("SetPaymentValueButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SetPaymentValueButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (beginLoginButton != null) {
				beginLoginButton.Dispose ();
				beginLoginButton = null;
			}
			if (beginPaymentButton != null) {
				beginPaymentButton.Dispose ();
				beginPaymentButton = null;
			}
			if (endLoginButton != null) {
				endLoginButton.Dispose ();
				endLoginButton = null;
			}
			if (endPaymentButton != null) {
				endPaymentButton.Dispose ();
				endPaymentButton = null;
			}
			if (failLoginButton != null) {
				failLoginButton.Dispose ();
				failLoginButton = null;
			}
			if (failPaymentButton != null) {
				failPaymentButton.Dispose ();
				failPaymentButton = null;
			}
			if (setLoginValueButton != null) {
				setLoginValueButton.Dispose ();
				setLoginValueButton = null;
			}
			if (setPaymentValueButton != null) {
				setPaymentValueButton.Dispose ();
				setPaymentValueButton = null;
			}
		}
	}
}
