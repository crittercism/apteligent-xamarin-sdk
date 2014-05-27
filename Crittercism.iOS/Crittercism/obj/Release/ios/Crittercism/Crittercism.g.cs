//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace Crittercism {
	[Register("Crittercism", true)]
	public unsafe partial class Crittercism : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selDidCrashOnLastLoad = "didCrashOnLastLoad";
		static readonly IntPtr selDidCrashOnLastLoadHandle = Selector.GetHandle ("didCrashOnLastLoad");
		[CompilerGenerated]
		const string selEnableWithAppID_ = "enableWithAppID:";
		static readonly IntPtr selEnableWithAppID_Handle = Selector.GetHandle ("enableWithAppID:");
		[CompilerGenerated]
		const string selEnableWithAppIDAndDelegate_ = "enableWithAppID:andDelegate:";
		static readonly IntPtr selEnableWithAppIDAndDelegate_Handle = Selector.GetHandle ("enableWithAppID:andDelegate:");
		[CompilerGenerated]
		const string selEnableWithAppIDAndDelegateAndURLFilters_ = "enableWithAppID:andDelegate:andURLFilters:";
		static readonly IntPtr selEnableWithAppIDAndDelegateAndURLFilters_Handle = Selector.GetHandle ("enableWithAppID:andDelegate:andURLFilters:");
		[CompilerGenerated]
		const string selEnableWithAppIDAndDelegateAndURLFiltersDisableInstrumentation_ = "enableWithAppID:andDelegate:andURLFilters:disableInstrumentation:";
		static readonly IntPtr selEnableWithAppIDAndDelegateAndURLFiltersDisableInstrumentation_Handle = Selector.GetHandle ("enableWithAppID:andDelegate:andURLFilters:disableInstrumentation:");
		[CompilerGenerated]
		const string selEnableWithAppIDAndURLFilters_ = "enableWithAppID:andURLFilters:";
		static readonly IntPtr selEnableWithAppIDAndURLFilters_Handle = Selector.GetHandle ("enableWithAppID:andURLFilters:");
		[CompilerGenerated]
		const string selGetOptOutStatus = "getOptOutStatus";
		static readonly IntPtr selGetOptOutStatusHandle = Selector.GetHandle ("getOptOutStatus");
		[CompilerGenerated]
		const string selGetUserUUID = "getUserUUID";
		static readonly IntPtr selGetUserUUIDHandle = Selector.GetHandle ("getUserUUID");
		[CompilerGenerated]
		const string selLeaveBreadcrumb_ = "leaveBreadcrumb:";
		static readonly IntPtr selLeaveBreadcrumb_Handle = Selector.GetHandle ("leaveBreadcrumb:");
		[CompilerGenerated]
		const string selLogHandledException_ = "logHandledException:";
		static readonly IntPtr selLogHandledException_Handle = Selector.GetHandle ("logHandledException:");
		[CompilerGenerated]
		const string selLogUnhandledException_ = "logUnhandledException:";
		static readonly IntPtr selLogUnhandledException_Handle = Selector.GetHandle ("logUnhandledException:");
		[CompilerGenerated]
		const string selMaxOfflineCrashReports = "maxOfflineCrashReports";
		static readonly IntPtr selMaxOfflineCrashReportsHandle = Selector.GetHandle ("maxOfflineCrashReports");
		[CompilerGenerated]
		const string selSetAsyncBreadcrumbMode_ = "setAsyncBreadcrumbMode:";
		static readonly IntPtr selSetAsyncBreadcrumbMode_Handle = Selector.GetHandle ("setAsyncBreadcrumbMode:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetMaxOfflineCrashReports_ = "setMaxOfflineCrashReports:";
		static readonly IntPtr selSetMaxOfflineCrashReports_Handle = Selector.GetHandle ("setMaxOfflineCrashReports:");
		[CompilerGenerated]
		const string selSetOptOutStatus_ = "setOptOutStatus:";
		static readonly IntPtr selSetOptOutStatus_Handle = Selector.GetHandle ("setOptOutStatus:");
		[CompilerGenerated]
		const string selSetUsername_ = "setUsername:";
		static readonly IntPtr selSetUsername_Handle = Selector.GetHandle ("setUsername:");
		[CompilerGenerated]
		const string selSetValueForKey_ = "setValue:forKey:";
		static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle ("setValue:forKey:");
		[CompilerGenerated]
		const string selUpdateLocation_ = "updateLocation:";
		static readonly IntPtr selUpdateLocation_Handle = Selector.GetHandle ("updateLocation:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Crittercism");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Crittercism () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public Crittercism (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Crittercism (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Crittercism (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enableWithAppID:")]
		[CompilerGenerated]
		public static void EnableWithAppID (string appId)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selEnableWithAppID_Handle, nsappId);
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("enableWithAppID:andDelegate:")]
		[CompilerGenerated]
		public static void EnableWithAppID (string appId, CrittercismDelegate critterDelegate)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (critterDelegate == null)
				throw new ArgumentNullException ("critterDelegate");
			var nsappId = NSString.CreateNative (appId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selEnableWithAppIDAndDelegate_Handle, nsappId, critterDelegate.Handle);
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("enableWithAppID:andDelegate:andURLFilters:")]
		[CompilerGenerated]
		public static void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, NSObject[] filters)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (critterDelegate == null)
				throw new ArgumentNullException ("critterDelegate");
			if (filters == null)
				throw new ArgumentNullException ("filters");
			var nsappId = NSString.CreateNative (appId);
			var nsa_filters = NSArray.FromNSObjects (filters);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selEnableWithAppIDAndDelegateAndURLFilters_Handle, nsappId, critterDelegate.Handle, nsa_filters.Handle);
			NSString.ReleaseNative (nsappId);
			nsa_filters.Dispose ();
			
		}
		
		[Export ("enableWithAppID:andURLFilters:")]
		[CompilerGenerated]
		public static void EnableWithAppID (string appId, NSObject[] filters)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (filters == null)
				throw new ArgumentNullException ("filters");
			var nsappId = NSString.CreateNative (appId);
			var nsa_filters = NSArray.FromNSObjects (filters);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selEnableWithAppIDAndURLFilters_Handle, nsappId, nsa_filters.Handle);
			NSString.ReleaseNative (nsappId);
			nsa_filters.Dispose ();
			
		}
		
		[Export ("enableWithAppID:andDelegate:andURLFilters:disableInstrumentation:")]
		[CompilerGenerated]
		public static void EnableWithAppID (string appId, CrittercismDelegate critterDelegate, NSObject[] filters, bool disableInstrumentation)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (critterDelegate == null)
				throw new ArgumentNullException ("critterDelegate");
			if (filters == null)
				throw new ArgumentNullException ("filters");
			var nsappId = NSString.CreateNative (appId);
			var nsa_filters = NSArray.FromNSObjects (filters);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (class_ptr, selEnableWithAppIDAndDelegateAndURLFiltersDisableInstrumentation_Handle, nsappId, critterDelegate.Handle, nsa_filters.Handle, disableInstrumentation);
			NSString.ReleaseNative (nsappId);
			nsa_filters.Dispose ();
			
		}
		
		[Export ("leaveBreadcrumb:")]
		[CompilerGenerated]
		public static void LeaveBreadcrumb (string breadcrumb)
		{
			if (breadcrumb == null)
				throw new ArgumentNullException ("breadcrumb");
			var nsbreadcrumb = NSString.CreateNative (breadcrumb);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selLeaveBreadcrumb_Handle, nsbreadcrumb);
			NSString.ReleaseNative (nsbreadcrumb);
			
		}
		
		[Export ("logHandledException:")]
		[CompilerGenerated]
		public static bool LogHandledException (NSException exception)
		{
			if (exception == null)
				throw new ArgumentNullException ("exception");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selLogHandledException_Handle, exception.Handle);
		}
		
		[Export ("logHandledException:")]
		[CompilerGenerated]
		public static bool LogHandledException (string name, string reason, string stack)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (reason == null)
				throw new ArgumentNullException ("reason");
			if (stack == null)
				throw new ArgumentNullException ("stack");
			var nsname = NSString.CreateNative (name);
			var nsreason = NSString.CreateNative (reason);
			var nsstack = NSString.CreateNative (stack);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogHandledException_Handle, nsname, nsreason, nsstack);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsreason);
			NSString.ReleaseNative (nsstack);
			
			return ret;
		}
		
		[Export ("logUnhandledException:")]
		[CompilerGenerated]
		public static bool LogUnhandledException (string name, string reason, string stack)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (reason == null)
				throw new ArgumentNullException ("reason");
			if (stack == null)
				throw new ArgumentNullException ("stack");
			var nsname = NSString.CreateNative (name);
			var nsreason = NSString.CreateNative (reason);
			var nsstack = NSString.CreateNative (stack);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogUnhandledException_Handle, nsname, nsreason, nsstack);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsreason);
			NSString.ReleaseNative (nsstack);
			
			return ret;
		}
		
		[Export ("setValue:forKey:")]
		[CompilerGenerated]
		public static void SetValue (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selSetValueForKey_Handle, nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("updateLocation:")]
		[CompilerGenerated]
		public static void UpdateLocation (global::MonoTouch.CoreLocation.CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selUpdateLocation_Handle, location.Handle);
		}
		
		[CompilerGenerated]
		public static bool AsyncBreadcrumbMode {
			[Export ("setAsyncBreadcrumbMode:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetAsyncBreadcrumbMode_Handle, value);
			}
		}
		
		[CompilerGenerated]
		static object __mt_Delegate_var_static;
		[CompilerGenerated]
		public static CrittercismDelegate Delegate {
			[Export ("delegate")]
			get {
				CrittercismDelegate ret;
				ret =  Runtime.GetNSObject<CrittercismDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDelegateHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Delegate_var_static = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetDelegate_Handle, value.Handle);
			}
		}
		
		[CompilerGenerated]
		public static bool DidCrashOnLastLoad {
			[Export ("didCrashOnLastLoad")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selDidCrashOnLastLoadHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool GetOptOutStatus {
			[Export ("getOptOutStatus")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selGetOptOutStatusHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static string GetUserUUID {
			[Export ("getUserUUID")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetUserUUIDHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static global::System.UInt32 MaxOfflineCrashReports {
			[Export ("maxOfflineCrashReports")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (class_ptr, selMaxOfflineCrashReportsHandle);
			}
			
			[Export ("setMaxOfflineCrashReports:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (class_ptr, selSetMaxOfflineCrashReports_Handle, value);
			}
		}
		
		[CompilerGenerated]
		public static bool OptOutStatus {
			[Export ("setOptOutStatus:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetOptOutStatus_Handle, value);
			}
		}
		
		[CompilerGenerated]
		public static string Username {
			[Export ("setUsername:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetUsername_Handle, nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class Crittercism */
}
