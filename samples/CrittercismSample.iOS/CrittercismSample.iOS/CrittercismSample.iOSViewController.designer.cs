// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CrittercismSample.iOS
{
	[Register ("CrittercismSample_iOSViewController")]
	partial class CrittercismSample_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton ButtonAttachUserMetadata { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonCLRException { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonCrashCLR { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonCrashNative { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonLeaveBreadcrumb { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonNativeException { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageCrittercism { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ButtonAttachUserMetadata != null) {
				ButtonAttachUserMetadata.Dispose ();
				ButtonAttachUserMetadata = null;
			}

			if (buttonCrashNative != null) {
				buttonCrashNative.Dispose ();
				buttonCrashNative = null;
			}

			if (buttonNativeException != null) {
				buttonNativeException.Dispose ();
				buttonNativeException = null;
			}

			if (buttonCrashCLR != null) {
				buttonCrashCLR.Dispose ();
				buttonCrashCLR = null;
			}

			if (buttonCLRException != null) {
				buttonCLRException.Dispose ();
				buttonCLRException = null;
			}

			if (buttonLeaveBreadcrumb != null) {
				buttonLeaveBreadcrumb.Dispose ();
				buttonLeaveBreadcrumb = null;
			}

			if (imageCrittercism != null) {
				imageCrittercism.Dispose ();
				imageCrittercism = null;
			}

		}
	}
}
