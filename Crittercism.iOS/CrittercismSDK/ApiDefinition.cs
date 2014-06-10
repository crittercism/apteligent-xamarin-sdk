using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Crittercism
{

	[BaseType (typeof (NSObject)) ]
	public partial interface CRCSharpException {
		[Export ("initWithName:reason:stacktrace:exceptionType:platformId:")]
		IntPtr Constructor (string name, string reason, string stacktrace, int typeId, int platformId);
	}

	[BaseType (typeof (NSObject))]
	internal partial interface Crittercism {

		[Static, Export ("enableWithAppID:")]
		void _EnableWithAppID (string appId);

		[Static, Export ("leaveBreadcrumb:")]
		void LeaveBreadcrumb (string breadcrumb);

		[Static, Export ("logHandledException:")]
		bool LogHandledException (NSException exception);

		[Static, Export ("setOptOutStatus:")]
		bool OptOutStatus { set; }

//		[Static, Export ("getOptOutStatus")]
//		bool OptOutStatus { get; }

		[Static, Export ("getUserUUID")]
		string UserUUID { get; }

		[Static, Export ("Username")]
		string Username { set; }

		[Static, Export ("setValue:forKey:")]
		void SetValue (string value, string key);

		[Static, Export ("didCrashOnLastLoad")]
		bool CrashedOnLastLoad { get; }

		[Static, Export ("logCSharpException:")]
		void _LogCSharpException(CRCSharpException cSharpException);


	}

}

