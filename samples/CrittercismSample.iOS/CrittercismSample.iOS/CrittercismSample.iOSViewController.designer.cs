// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CrittercismSample.iOS
{
	[Register ("CrittercismSample_iOSViewController")]
	partial class CrittercismSample_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonAttachUserMetadata { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonCLRException { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonCrashCLR { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonCrashNative { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonLeaveBreadcrumb { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton buttonNativeException { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageCrittercism { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ButtonAttachUserMetadata != null) {
				ButtonAttachUserMetadata.Dispose ();
				ButtonAttachUserMetadata = null;
			}
			if (buttonCLRException != null) {
				buttonCLRException.Dispose ();
				buttonCLRException = null;
			}
			if (buttonCrashCLR != null) {
				buttonCrashCLR.Dispose ();
				buttonCrashCLR = null;
			}
			if (buttonCrashNative != null) {
				buttonCrashNative.Dispose ();
				buttonCrashNative = null;
			}
			if (buttonLeaveBreadcrumb != null) {
				buttonLeaveBreadcrumb.Dispose ();
				buttonLeaveBreadcrumb = null;
			}
			if (buttonNativeException != null) {
				buttonNativeException.Dispose ();
				buttonNativeException = null;
			}
			if (imageCrittercism != null) {
				imageCrittercism.Dispose ();
				imageCrittercism = null;
			}
		}
	}
}
