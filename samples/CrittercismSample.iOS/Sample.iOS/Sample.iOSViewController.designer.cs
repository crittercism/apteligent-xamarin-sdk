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
		UIButton ButtonAttachUserMeta { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonBeginTransaction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonCLRException { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonCrashCLR { get; set; }

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
		UIButton ButtonLeaveBreadcrumb { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonSetTransactionValue { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ButtonAttachUserMeta != null) {
				ButtonAttachUserMeta.Dispose ();
				ButtonAttachUserMeta = null;
			}
			if (ButtonBeginTransaction != null) {
				ButtonBeginTransaction.Dispose ();
				ButtonBeginTransaction = null;
			}
			if (ButtonCLRException != null) {
				ButtonCLRException.Dispose ();
				ButtonCLRException = null;
			}
			if (ButtonCrashCLR != null) {
				ButtonCrashCLR.Dispose ();
				ButtonCrashCLR = null;
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
			if (ButtonLeaveBreadcrumb != null) {
				ButtonLeaveBreadcrumb.Dispose ();
				ButtonLeaveBreadcrumb = null;
			}
			if (ButtonSetTransactionValue != null) {
				ButtonSetTransactionValue.Dispose ();
				ButtonSetTransactionValue = null;
			}
		}
	}
}
