using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;


namespace CrittercismIOS
{

	[BaseType (typeof (NSObject))]
	internal partial interface Crittercism {

		[Static, Export ("leaveBreadcrumb:")]
		void LeaveBreadcrumb (string breadcrumb);

		[Static, Export ("logHandledException:")]
		bool LogHandledException (NSException exception);

		[Static, Export ("getUserUUID")]
		string UserUUID { get; }

		[Static, Export ("Username")]
		string Username { set; }
	}

	/// <summary>
	/// To get service monitoring working, we have to trick Xamarin into thinking that these classes
	/// inhertit from NSObject rather than NSProxy. Xamarin doesn't support NSProxy.
	/// </summary>

	// @interface CRNSURLSessionProxy : NSProxy
	[BaseType (typeof(NSObject))]
	interface CRNSURLSessionProxy
	{
	}

	// @interface CRNSURLSessionTaskProxy : NSProxy
	[BaseType (typeof(NSObject))]
	interface CRNSURLSessionTaskProxy
	{
	}

	// @interface CRNSURLSessionDelegateProxy : NSProxy <NSURLSessionDelegate, NSURLSessionTaskDelegate, NSURLSessionDataDelegate, NSURLSessionDownloadDelegate, NSURLSessionStreamDelegate>
	[BaseType (typeof(NSObject))]
	interface CRNSURLSessionDelegateProxy : INSUrlSessionDelegate, INSUrlSessionTaskDelegate, INSUrlSessionDataDelegate, INSUrlSessionDownloadDelegate, INSUrlSessionStreamDelegate
	{
	}

	// @interface CRNSURLConnectionDelegateProxy : NSProxy <NSURLConnectionDelegate, NSURLConnectionDataDelegate>
	[BaseType (typeof(NSObject))]
	interface CRNSURLConnectionDelegateProxy : INSUrlConnectionDelegate, INSUrlConnectionDataDelegate
	{
	}
}

