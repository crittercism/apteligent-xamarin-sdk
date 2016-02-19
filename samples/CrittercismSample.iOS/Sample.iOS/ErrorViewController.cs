using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

using CrittercismIOS;

namespace Sample.iOS
{
	partial class ErrorViewController : UIViewController
	{
		public ErrorViewController (IntPtr handle) : base (handle)
		{
		}

		partial void DivideByZeroCrashButton_TouchUpInside (UIButton sender)
		{
			int myNumber = 22;
			int divZero = 0;
			int result = myNumber / divZero;
		}

		partial void NullReferenceCrashButton_TouchUpInside (UIButton sender)
		{
			object o = null;
			o.GetHashCode ();
		}

		partial void IndexOutOfRangeCrashButton_TouchUpInside (UIButton sender)
		{
			string[] arr = new string[1];
			arr [2]	= "Crash";
		}

		partial void NestedUncaughtExceptionButton_TouchUpInside (UIButton sender)
		{
			try {
				DeepError (4);
			} catch (Exception ie) {
				throw new Exception ("Outer Exception", ie);
			}
		}

		public void DeepError (int n)
		{
			if (n == 0) {
				throw new Exception ("Deep Inner Exception");
			} else {
				DeepError (n - 1);
			}
		}

		partial void HandledExceptionButton_TouchUpInside (UIButton sender)
		{
			try {
				throw new Exception ("Custom exception");
			} catch (Exception e) {
				Crittercism.LogHandledException (e);
			}
		}

	}
}
