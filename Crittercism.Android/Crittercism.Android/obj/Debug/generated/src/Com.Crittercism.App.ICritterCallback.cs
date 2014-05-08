using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.crittercism.app']/interface[@name='CritterCallback']"
	[Register ("com/crittercism/app/CritterCallback", "", "Com.Crittercism.App.ICritterCallbackInvoker")]
	public partial interface ICritterCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/interface[@name='CritterCallback']/method[@name='onCritterDataReceived' and count(parameter)=1 and parameter[1][@type='com.crittercism.app.CritterUserData']]"
		[Register ("onCritterDataReceived", "(Lcom/crittercism/app/CritterUserData;)V", "GetOnCritterDataReceived_Lcom_crittercism_app_CritterUserData_Handler:Com.Crittercism.App.ICritterCallbackInvoker, Crittercism.Android")]
		void OnCritterDataReceived (global::Com.Crittercism.App.CritterUserData p0);

	}

	[global::Android.Runtime.Register ("com/crittercism/app/CritterCallback", DoNotGenerateAcw=true)]
	internal class ICritterCallbackInvoker : global::Java.Lang.Object, ICritterCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/crittercism/app/CritterCallback");
		IntPtr class_ref;

		public static ICritterCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICritterCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.crittercism.app.CritterCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICritterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICritterCallbackInvoker); }
		}

		static Delegate cb_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_;
#pragma warning disable 0169
		static Delegate GetOnCritterDataReceived_Lcom_crittercism_app_CritterUserData_Handler ()
		{
			if (cb_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_ == null)
				cb_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCritterDataReceived_Lcom_crittercism_app_CritterUserData_);
			return cb_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_;
		}

		static void n_OnCritterDataReceived_Lcom_crittercism_app_CritterUserData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Crittercism.App.ICritterCallback __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.ICritterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Crittercism.App.CritterUserData p0 = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterUserData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCritterDataReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_;
		public void OnCritterDataReceived (global::Com.Crittercism.App.CritterUserData p0)
		{
			if (id_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_ == IntPtr.Zero)
				id_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_ = JNIEnv.GetMethodID (class_ref, "onCritterDataReceived", "(Lcom/crittercism/app/CritterUserData;)V");
			JNIEnv.CallVoidMethod (Handle, id_onCritterDataReceived_Lcom_crittercism_app_CritterUserData_, new JValue (p0));
		}

	}

}
