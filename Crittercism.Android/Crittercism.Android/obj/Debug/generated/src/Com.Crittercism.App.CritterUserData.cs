using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']"
	[global::Android.Runtime.Register ("com/crittercism/app/CritterUserData", DoNotGenerateAcw=true)]
	public partial class CritterUserData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/CritterUserData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CritterUserData); }
		}

		protected CritterUserData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isOptedOut;
#pragma warning disable 0169
		static Delegate GetIsOptedOutHandler ()
		{
			if (cb_isOptedOut == null)
				cb_isOptedOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOptedOut);
			return cb_isOptedOut;
		}

		static bool n_IsOptedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOptedOut;
		}
#pragma warning restore 0169

		static IntPtr id_isOptedOut;
		public virtual bool IsOptedOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='isOptedOut' and count(parameter)=0]"
			[Register ("isOptedOut", "()Z", "GetIsOptedOutHandler")]
			get {
				if (id_isOptedOut == IntPtr.Zero)
					id_isOptedOut = JNIEnv.GetMethodID (class_ref, "isOptedOut", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOptedOut);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptedOut", "()Z"));
			}
		}

		static Delegate cb_getRateMyAppMessage;
#pragma warning disable 0169
		static Delegate GetGetRateMyAppMessageHandler ()
		{
			if (cb_getRateMyAppMessage == null)
				cb_getRateMyAppMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRateMyAppMessage);
			return cb_getRateMyAppMessage;
		}

		static IntPtr n_GetRateMyAppMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RateMyAppMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getRateMyAppMessage;
		public virtual string RateMyAppMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='getRateMyAppMessage' and count(parameter)=0]"
			[Register ("getRateMyAppMessage", "()Ljava/lang/String;", "GetGetRateMyAppMessageHandler")]
			get {
				if (id_getRateMyAppMessage == IntPtr.Zero)
					id_getRateMyAppMessage = JNIEnv.GetMethodID (class_ref, "getRateMyAppMessage", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRateMyAppMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRateMyAppMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRateMyAppTitle;
#pragma warning disable 0169
		static Delegate GetGetRateMyAppTitleHandler ()
		{
			if (cb_getRateMyAppTitle == null)
				cb_getRateMyAppTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRateMyAppTitle);
			return cb_getRateMyAppTitle;
		}

		static IntPtr n_GetRateMyAppTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RateMyAppTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getRateMyAppTitle;
		public virtual string RateMyAppTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='getRateMyAppTitle' and count(parameter)=0]"
			[Register ("getRateMyAppTitle", "()Ljava/lang/String;", "GetGetRateMyAppTitleHandler")]
			get {
				if (id_getRateMyAppTitle == IntPtr.Zero)
					id_getRateMyAppTitle = JNIEnv.GetMethodID (class_ref, "getRateMyAppTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRateMyAppTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRateMyAppTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserUUID;
#pragma warning disable 0169
		static Delegate GetGetUserUUIDHandler ()
		{
			if (cb_getUserUUID == null)
				cb_getUserUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserUUID);
			return cb_getUserUUID;
		}

		static IntPtr n_GetUserUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserUUID);
		}
#pragma warning restore 0169

		static IntPtr id_getUserUUID;
		public virtual string UserUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='getUserUUID' and count(parameter)=0]"
			[Register ("getUserUUID", "()Ljava/lang/String;", "GetGetUserUUIDHandler")]
			get {
				if (id_getUserUUID == IntPtr.Zero)
					id_getUserUUID = JNIEnv.GetMethodID (class_ref, "getUserUUID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserUUID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_crashedOnLastLoad;
#pragma warning disable 0169
		static Delegate GetCrashedOnLastLoadHandler ()
		{
			if (cb_crashedOnLastLoad == null)
				cb_crashedOnLastLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CrashedOnLastLoad);
			return cb_crashedOnLastLoad;
		}

		static bool n_CrashedOnLastLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CrashedOnLastLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_crashedOnLastLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='crashedOnLastLoad' and count(parameter)=0]"
		[Register ("crashedOnLastLoad", "()Z", "GetCrashedOnLastLoadHandler")]
		public virtual bool CrashedOnLastLoad ()
		{
			if (id_crashedOnLastLoad == IntPtr.Zero)
				id_crashedOnLastLoad = JNIEnv.GetMethodID (class_ref, "crashedOnLastLoad", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_crashedOnLastLoad);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crashedOnLastLoad", "()Z"));
		}

		static Delegate cb_shouldShowRateMyAppAlert;
#pragma warning disable 0169
		static Delegate GetShouldShowRateMyAppAlertHandler ()
		{
			if (cb_shouldShowRateMyAppAlert == null)
				cb_shouldShowRateMyAppAlert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldShowRateMyAppAlert);
			return cb_shouldShowRateMyAppAlert;
		}

		static bool n_ShouldShowRateMyAppAlert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserData __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldShowRateMyAppAlert ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldShowRateMyAppAlert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserData']/method[@name='shouldShowRateMyAppAlert' and count(parameter)=0]"
		[Register ("shouldShowRateMyAppAlert", "()Z", "GetShouldShowRateMyAppAlertHandler")]
		public virtual bool ShouldShowRateMyAppAlert ()
		{
			if (id_shouldShowRateMyAppAlert == IntPtr.Zero)
				id_shouldShowRateMyAppAlert = JNIEnv.GetMethodID (class_ref, "shouldShowRateMyAppAlert", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldShowRateMyAppAlert);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldShowRateMyAppAlert", "()Z"));
		}

	}
}
