using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']"
	[global::Android.Runtime.Register ("com/crittercism/app/CritterUserDataRequest", DoNotGenerateAcw=true)]
	public partial class CritterUserDataRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/CritterUserDataRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CritterUserDataRequest); }
		}

		protected CritterUserDataRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_crittercism_app_CritterCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/constructor[@name='CritterUserDataRequest' and count(parameter)=1 and parameter[1][@type='com.crittercism.app.CritterCallback']]"
		[Register (".ctor", "(Lcom/crittercism/app/CritterCallback;)V", "")]
		public CritterUserDataRequest (global::Com.Crittercism.App.ICritterCallback p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CritterUserDataRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/crittercism/app/CritterCallback;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/crittercism/app/CritterCallback;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_crittercism_app_CritterCallback_ == IntPtr.Zero)
				id_ctor_Lcom_crittercism_app_CritterCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/crittercism/app/CritterCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_crittercism_app_CritterCallback_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_crittercism_app_CritterCallback_, new JValue (p0));
		}

		static Delegate cb_makeRequest;
#pragma warning disable 0169
		static Delegate GetMakeRequestHandler ()
		{
			if (cb_makeRequest == null)
				cb_makeRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MakeRequest);
			return cb_makeRequest;
		}

		static void n_MakeRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserDataRequest __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MakeRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_makeRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/method[@name='makeRequest' and count(parameter)=0]"
		[Register ("makeRequest", "()V", "GetMakeRequestHandler")]
		public virtual void MakeRequest ()
		{
			if (id_makeRequest == IntPtr.Zero)
				id_makeRequest = JNIEnv.GetMethodID (class_ref, "makeRequest", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_makeRequest);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeRequest", "()V"));
		}

		static Delegate cb_requestDidCrashOnLastLoad;
#pragma warning disable 0169
		static Delegate GetRequestDidCrashOnLastLoadHandler ()
		{
			if (cb_requestDidCrashOnLastLoad == null)
				cb_requestDidCrashOnLastLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestDidCrashOnLastLoad);
			return cb_requestDidCrashOnLastLoad;
		}

		static IntPtr n_RequestDidCrashOnLastLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserDataRequest __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestDidCrashOnLastLoad ());
		}
#pragma warning restore 0169

		static IntPtr id_requestDidCrashOnLastLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/method[@name='requestDidCrashOnLastLoad' and count(parameter)=0]"
		[Register ("requestDidCrashOnLastLoad", "()Lcom/crittercism/app/CritterUserDataRequest;", "GetRequestDidCrashOnLastLoadHandler")]
		public virtual global::Com.Crittercism.App.CritterUserDataRequest RequestDidCrashOnLastLoad ()
		{
			if (id_requestDidCrashOnLastLoad == IntPtr.Zero)
				id_requestDidCrashOnLastLoad = JNIEnv.GetMethodID (class_ref, "requestDidCrashOnLastLoad", "()Lcom/crittercism/app/CritterUserDataRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallObjectMethod  (Handle, id_requestDidCrashOnLastLoad), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestDidCrashOnLastLoad", "()Lcom/crittercism/app/CritterUserDataRequest;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestOptOutStatus;
#pragma warning disable 0169
		static Delegate GetRequestOptOutStatusHandler ()
		{
			if (cb_requestOptOutStatus == null)
				cb_requestOptOutStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestOptOutStatus);
			return cb_requestOptOutStatus;
		}

		static IntPtr n_RequestOptOutStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserDataRequest __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestOptOutStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_requestOptOutStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/method[@name='requestOptOutStatus' and count(parameter)=0]"
		[Register ("requestOptOutStatus", "()Lcom/crittercism/app/CritterUserDataRequest;", "GetRequestOptOutStatusHandler")]
		public virtual global::Com.Crittercism.App.CritterUserDataRequest RequestOptOutStatus ()
		{
			if (id_requestOptOutStatus == IntPtr.Zero)
				id_requestOptOutStatus = JNIEnv.GetMethodID (class_ref, "requestOptOutStatus", "()Lcom/crittercism/app/CritterUserDataRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallObjectMethod  (Handle, id_requestOptOutStatus), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestOptOutStatus", "()Lcom/crittercism/app/CritterUserDataRequest;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestRateMyAppInfo;
#pragma warning disable 0169
		static Delegate GetRequestRateMyAppInfoHandler ()
		{
			if (cb_requestRateMyAppInfo == null)
				cb_requestRateMyAppInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestRateMyAppInfo);
			return cb_requestRateMyAppInfo;
		}

		static IntPtr n_RequestRateMyAppInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserDataRequest __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestRateMyAppInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_requestRateMyAppInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/method[@name='requestRateMyAppInfo' and count(parameter)=0]"
		[Register ("requestRateMyAppInfo", "()Lcom/crittercism/app/CritterUserDataRequest;", "GetRequestRateMyAppInfoHandler")]
		public virtual global::Com.Crittercism.App.CritterUserDataRequest RequestRateMyAppInfo ()
		{
			if (id_requestRateMyAppInfo == IntPtr.Zero)
				id_requestRateMyAppInfo = JNIEnv.GetMethodID (class_ref, "requestRateMyAppInfo", "()Lcom/crittercism/app/CritterUserDataRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallObjectMethod  (Handle, id_requestRateMyAppInfo), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestRateMyAppInfo", "()Lcom/crittercism/app/CritterUserDataRequest;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestUserUUID;
#pragma warning disable 0169
		static Delegate GetRequestUserUUIDHandler ()
		{
			if (cb_requestUserUUID == null)
				cb_requestUserUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestUserUUID);
			return cb_requestUserUUID;
		}

		static IntPtr n_RequestUserUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CritterUserDataRequest __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestUserUUID ());
		}
#pragma warning restore 0169

		static IntPtr id_requestUserUUID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterUserDataRequest']/method[@name='requestUserUUID' and count(parameter)=0]"
		[Register ("requestUserUUID", "()Lcom/crittercism/app/CritterUserDataRequest;", "GetRequestUserUUIDHandler")]
		public virtual global::Com.Crittercism.App.CritterUserDataRequest RequestUserUUID ()
		{
			if (id_requestUserUUID == IntPtr.Zero)
				id_requestUserUUID = JNIEnv.GetMethodID (class_ref, "requestUserUUID", "()Lcom/crittercism/app/CritterUserDataRequest;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallObjectMethod  (Handle, id_requestUserUUID), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserDataRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestUserUUID", "()Lcom/crittercism/app/CritterUserDataRequest;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
