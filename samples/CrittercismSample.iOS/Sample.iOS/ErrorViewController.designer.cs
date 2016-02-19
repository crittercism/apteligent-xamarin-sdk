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
	[Register ("ErrorViewController")]
	partial class ErrorViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton divideByZeroCrashButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton handledExceptionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton indexOutOfRangeCrashButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton nestedUncaughtExceptionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton nullReferenceCrashButton { get; set; }

		[Action ("DivideByZeroCrashButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void DivideByZeroCrashButton_TouchUpInside (UIButton sender);

		[Action ("HandledExceptionButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void HandledExceptionButton_TouchUpInside (UIButton sender);

		[Action ("IndexOutOfRangeCrashButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void IndexOutOfRangeCrashButton_TouchUpInside (UIButton sender);

		[Action ("NestedUncaughtExceptionButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NestedUncaughtExceptionButton_TouchUpInside (UIButton sender);

		[Action ("NullReferenceCrashButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NullReferenceCrashButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (divideByZeroCrashButton != null) {
				divideByZeroCrashButton.Dispose ();
				divideByZeroCrashButton = null;
			}
			if (handledExceptionButton != null) {
				handledExceptionButton.Dispose ();
				handledExceptionButton = null;
			}
			if (indexOutOfRangeCrashButton != null) {
				indexOutOfRangeCrashButton.Dispose ();
				indexOutOfRangeCrashButton = null;
			}
			if (nestedUncaughtExceptionButton != null) {
				nestedUncaughtExceptionButton.Dispose ();
				nestedUncaughtExceptionButton = null;
			}
			if (nullReferenceCrashButton != null) {
				nullReferenceCrashButton.Dispose ();
				nullReferenceCrashButton = null;
			}
		}
	}
}
