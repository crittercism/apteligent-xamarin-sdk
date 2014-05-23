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
		MonoTouch.UIKit.UIButton buttonMisc1 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonMisc2 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonMisc3 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonNativeException { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageCrittercism { get; set; }

		[Action ("actionAttachUserMetadata:")]
		partial void actionAttachUserMetadata (MonoTouch.Foundation.NSObject sender);

		[Action ("actionBreadcrumb:")]
		partial void actionBreadcrumb (MonoTouch.Foundation.NSObject sender);

		[Action ("actionCLRException:")]
		partial void actionCLRException (MonoTouch.Foundation.NSObject sender);

		[Action ("actionCrashCLR:")]
		partial void actionCrashCLR (MonoTouch.Foundation.NSObject sender);

		[Action ("actionCrashNative:")]
		partial void actionCrashNative (MonoTouch.Foundation.NSObject sender);

		[Action ("actionNativeException:")]
		partial void actionNativeException (MonoTouch.Foundation.NSObject sender);
		
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

			if (buttonMisc1 != null) {
				buttonMisc1.Dispose ();
				buttonMisc1 = null;
			}

			if (buttonMisc2 != null) {
				buttonMisc2.Dispose ();
				buttonMisc2 = null;
			}

			if (buttonMisc3 != null) {
				buttonMisc3.Dispose ();
				buttonMisc3 = null;
			}
		}
	}
}
