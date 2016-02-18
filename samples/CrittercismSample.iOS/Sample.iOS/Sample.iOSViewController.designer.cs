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
	[Register ("Sample_iOSViewController")]
	partial class Sample_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonBeginTransaction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonCrash { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonEndTransaction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonFailTransaction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonGetTransactionValue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonHandledException { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonLeaveBreadcrumb { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonLogNetworkRequest { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonSetMetadata { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonSetTransactionValue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonSetUsername { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton httpGetButton { get; set; }

		[Action ("HttpGetButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HttpGetButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ButtonBeginTransaction != null) {
				ButtonBeginTransaction.Dispose ();
				ButtonBeginTransaction = null;
			}
			if (ButtonCrash != null) {
				ButtonCrash.Dispose ();
				ButtonCrash = null;
			}
			if (ButtonEndTransaction != null) {
				ButtonEndTransaction.Dispose ();
				ButtonEndTransaction = null;
			}
			if (ButtonFailTransaction != null) {
				ButtonFailTransaction.Dispose ();
				ButtonFailTransaction = null;
			}
			if (ButtonGetTransactionValue != null) {
				ButtonGetTransactionValue.Dispose ();
				ButtonGetTransactionValue = null;
			}
			if (ButtonHandledException != null) {
				ButtonHandledException.Dispose ();
				ButtonHandledException = null;
			}
			if (ButtonLeaveBreadcrumb != null) {
				ButtonLeaveBreadcrumb.Dispose ();
				ButtonLeaveBreadcrumb = null;
			}
			if (ButtonLogNetworkRequest != null) {
				ButtonLogNetworkRequest.Dispose ();
				ButtonLogNetworkRequest = null;
			}
			if (ButtonSetMetadata != null) {
				ButtonSetMetadata.Dispose ();
				ButtonSetMetadata = null;
			}
			if (ButtonSetTransactionValue != null) {
				ButtonSetTransactionValue.Dispose ();
				ButtonSetTransactionValue = null;
			}
			if (ButtonSetUsername != null) {
				ButtonSetUsername.Dispose ();
				ButtonSetUsername = null;
			}
			if (httpGetButton != null) {
				httpGetButton.Dispose ();
				httpGetButton = null;
			}
		}
	}
}
