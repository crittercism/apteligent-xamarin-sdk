using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']"
	[global::Android.Runtime.Register ("com/crittercism/app/CrittercismConfig", DoNotGenerateAcw=true)]
	public partial class CrittercismConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/field[@name='API_VERSION']"
		[Register ("API_VERSION")]
		public const string ApiVersion = (string) "4.5.1";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/CrittercismConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CrittercismConfig); }
		}

		protected CrittercismConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_crittercism_app_CrittercismConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/constructor[@name='CrittercismConfig' and count(parameter)=1 and parameter[1][@type='com.crittercism.app.CrittercismConfig']]"
		[Register (".ctor", "(Lcom/crittercism/app/CrittercismConfig;)V", "")]
		public CrittercismConfig (global::Com.Crittercism.App.CrittercismConfig p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CrittercismConfig)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/crittercism/app/CrittercismConfig;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/crittercism/app/CrittercismConfig;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_crittercism_app_CrittercismConfig_ == IntPtr.Zero)
				id_ctor_Lcom_crittercism_app_CrittercismConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/crittercism/app/CrittercismConfig;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_crittercism_app_CrittercismConfig_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_crittercism_app_CrittercismConfig_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/constructor[@name='CrittercismConfig' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public CrittercismConfig (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CrittercismConfig)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/constructor[@name='CrittercismConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CrittercismConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CrittercismConfig)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_getCustomVersionName;
		static IntPtr id_setCustomVersionName_Ljava_lang_String_;
		public string CustomVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getCustomVersionName' and count(parameter)=0]"
			[Register ("getCustomVersionName", "()Ljava/lang/String;", "GetGetCustomVersionNameHandler")]
			get {
				if (id_getCustomVersionName == IntPtr.Zero)
					id_getCustomVersionName = JNIEnv.GetMethodID (class_ref, "getCustomVersionName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustomVersionName), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setCustomVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomVersionName", "(Ljava/lang/String;)V", "GetSetCustomVersionName_Ljava_lang_String_Handler")]
			set {
				if (id_setCustomVersionName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomVersionName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomVersionName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setCustomVersionName_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isLogcatReportingEnabled;
		static IntPtr id_setLogcatReportingEnabled_Z;
		public bool LogcatReportingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='isLogcatReportingEnabled' and count(parameter)=0]"
			[Register ("isLogcatReportingEnabled", "()Z", "GetIsLogcatReportingEnabledHandler")]
			get {
				if (id_isLogcatReportingEnabled == IntPtr.Zero)
					id_isLogcatReportingEnabled = JNIEnv.GetMethodID (class_ref, "isLogcatReportingEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isLogcatReportingEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setLogcatReportingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogcatReportingEnabled", "(Z)V", "GetSetLogcatReportingEnabled_ZHandler")]
			set {
				if (id_setLogcatReportingEnabled_Z == IntPtr.Zero)
					id_setLogcatReportingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLogcatReportingEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setLogcatReportingEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_getNativeDumpPath;
		static IntPtr id_setNativeDumpPath_Ljava_lang_String_;
		public string NativeDumpPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getNativeDumpPath' and count(parameter)=0]"
			[Register ("getNativeDumpPath", "()Ljava/lang/String;", "GetGetNativeDumpPathHandler")]
			get {
				if (id_getNativeDumpPath == IntPtr.Zero)
					id_getNativeDumpPath = JNIEnv.GetMethodID (class_ref, "getNativeDumpPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNativeDumpPath), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setNativeDumpPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNativeDumpPath", "(Ljava/lang/String;)V", "GetSetNativeDumpPath_Ljava_lang_String_Handler")]
			set {
				if (id_setNativeDumpPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setNativeDumpPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNativeDumpPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setNativeDumpPath_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isNdkCrashReportingEnabled;
		static IntPtr id_setNdkCrashReportingEnabled_Z;
		public bool NdkCrashReportingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='isNdkCrashReportingEnabled' and count(parameter)=0]"
			[Register ("isNdkCrashReportingEnabled", "()Z", "GetIsNdkCrashReportingEnabledHandler")]
			get {
				if (id_isNdkCrashReportingEnabled == IntPtr.Zero)
					id_isNdkCrashReportingEnabled = JNIEnv.GetMethodID (class_ref, "isNdkCrashReportingEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isNdkCrashReportingEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setNdkCrashReportingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNdkCrashReportingEnabled", "(Z)V", "GetSetNdkCrashReportingEnabled_ZHandler")]
			set {
				if (id_setNdkCrashReportingEnabled_Z == IntPtr.Zero)
					id_setNdkCrashReportingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setNdkCrashReportingEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setNdkCrashReportingEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_getNotificationTitle;
		static IntPtr id_setNotificationTitle_Ljava_lang_String_;
		public string NotificationTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getNotificationTitle' and count(parameter)=0]"
			[Register ("getNotificationTitle", "()Ljava/lang/String;", "GetGetNotificationTitleHandler")]
			get {
				if (id_getNotificationTitle == IntPtr.Zero)
					id_getNotificationTitle = JNIEnv.GetMethodID (class_ref, "getNotificationTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNotificationTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setNotificationTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationTitle", "(Ljava/lang/String;)V", "GetSetNotificationTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setNotificationTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotificationTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setNotificationTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getOptmzBlackListURLPatterns;
#pragma warning disable 0169
		static Delegate GetGetOptmzBlackListURLPatternsHandler ()
		{
			if (cb_getOptmzBlackListURLPatterns == null)
				cb_getOptmzBlackListURLPatterns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptmzBlackListURLPatterns);
			return cb_getOptmzBlackListURLPatterns;
		}

		static IntPtr n_GetOptmzBlackListURLPatterns (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.OptmzBlackListURLPatterns);
		}
#pragma warning restore 0169

		static Delegate cb_setOptmzBlackListURLPatterns_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetOptmzBlackListURLPatterns_Ljava_util_List_Handler ()
		{
			if (cb_setOptmzBlackListURLPatterns_Ljava_util_List_ == null)
				cb_setOptmzBlackListURLPatterns_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptmzBlackListURLPatterns_Ljava_util_List_);
			return cb_setOptmzBlackListURLPatterns_Ljava_util_List_;
		}

		static void n_SetOptmzBlackListURLPatterns_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OptmzBlackListURLPatterns = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOptmzBlackListURLPatterns;
		static IntPtr id_setOptmzBlackListURLPatterns_Ljava_util_List_;
		[Obsolete (@"deprecated")]
		public virtual global::System.Collections.IList OptmzBlackListURLPatterns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getOptmzBlackListURLPatterns' and count(parameter)=0]"
			[Register ("getOptmzBlackListURLPatterns", "()Ljava/util/List;", "GetGetOptmzBlackListURLPatternsHandler")]
			get {
				if (id_getOptmzBlackListURLPatterns == IntPtr.Zero)
					id_getOptmzBlackListURLPatterns = JNIEnv.GetMethodID (class_ref, "getOptmzBlackListURLPatterns", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOptmzBlackListURLPatterns), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptmzBlackListURLPatterns", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setOptmzBlackListURLPatterns' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setOptmzBlackListURLPatterns", "(Ljava/util/List;)V", "GetSetOptmzBlackListURLPatterns_Ljava_util_List_Handler")]
			set {
				if (id_setOptmzBlackListURLPatterns_Ljava_util_List_ == IntPtr.Zero)
					id_setOptmzBlackListURLPatterns_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setOptmzBlackListURLPatterns", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOptmzBlackListURLPatterns_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptmzBlackListURLPatterns", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isOptmzEnabled;
		static IntPtr id_setOptmzEnabled_Z;
		public bool OptmzEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='isOptmzEnabled' and count(parameter)=0]"
			[Register ("isOptmzEnabled", "()Z", "GetIsOptmzEnabledHandler")]
			get {
				if (id_isOptmzEnabled == IntPtr.Zero)
					id_isOptmzEnabled = JNIEnv.GetMethodID (class_ref, "isOptmzEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isOptmzEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setOptmzEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOptmzEnabled", "(Z)V", "GetSetOptmzEnabled_ZHandler")]
			set {
				if (id_setOptmzEnabled_Z == IntPtr.Zero)
					id_setOptmzEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOptmzEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setOptmzEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getPreserveQueryStringPatterns;
#pragma warning disable 0169
		static Delegate GetGetPreserveQueryStringPatternsHandler ()
		{
			if (cb_getPreserveQueryStringPatterns == null)
				cb_getPreserveQueryStringPatterns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreserveQueryStringPatterns);
			return cb_getPreserveQueryStringPatterns;
		}

		static IntPtr n_GetPreserveQueryStringPatterns (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.PreserveQueryStringPatterns);
		}
#pragma warning restore 0169

		static Delegate cb_setPreserveQueryStringPatterns_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPreserveQueryStringPatterns_Ljava_util_List_Handler ()
		{
			if (cb_setPreserveQueryStringPatterns_Ljava_util_List_ == null)
				cb_setPreserveQueryStringPatterns_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreserveQueryStringPatterns_Ljava_util_List_);
			return cb_setPreserveQueryStringPatterns_Ljava_util_List_;
		}

		static void n_SetPreserveQueryStringPatterns_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreserveQueryStringPatterns = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreserveQueryStringPatterns;
		static IntPtr id_setPreserveQueryStringPatterns_Ljava_util_List_;
		public virtual global::System.Collections.IList PreserveQueryStringPatterns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getPreserveQueryStringPatterns' and count(parameter)=0]"
			[Register ("getPreserveQueryStringPatterns", "()Ljava/util/List;", "GetGetPreserveQueryStringPatternsHandler")]
			get {
				if (id_getPreserveQueryStringPatterns == IntPtr.Zero)
					id_getPreserveQueryStringPatterns = JNIEnv.GetMethodID (class_ref, "getPreserveQueryStringPatterns", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPreserveQueryStringPatterns), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreserveQueryStringPatterns", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setPreserveQueryStringPatterns' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPreserveQueryStringPatterns", "(Ljava/util/List;)V", "GetSetPreserveQueryStringPatterns_Ljava_util_List_Handler")]
			set {
				if (id_setPreserveQueryStringPatterns_Ljava_util_List_ == IntPtr.Zero)
					id_setPreserveQueryStringPatterns_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPreserveQueryStringPatterns", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPreserveQueryStringPatterns_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreserveQueryStringPatterns", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getRateMyAppTestTarget;
		static IntPtr id_setRateMyAppTestTarget_Ljava_lang_String_;
		public string RateMyAppTestTarget {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getRateMyAppTestTarget' and count(parameter)=0]"
			[Register ("getRateMyAppTestTarget", "()Ljava/lang/String;", "GetGetRateMyAppTestTargetHandler")]
			get {
				if (id_getRateMyAppTestTarget == IntPtr.Zero)
					id_getRateMyAppTestTarget = JNIEnv.GetMethodID (class_ref, "getRateMyAppTestTarget", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRateMyAppTestTarget), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setRateMyAppTestTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRateMyAppTestTarget", "(Ljava/lang/String;)V", "GetSetRateMyAppTestTarget_Ljava_lang_String_Handler")]
			set {
				if (id_setRateMyAppTestTarget_Ljava_lang_String_ == IntPtr.Zero)
					id_setRateMyAppTestTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRateMyAppTestTarget", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setRateMyAppTestTarget_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getURLBlacklistPatterns;
#pragma warning disable 0169
		static Delegate GetGetURLBlacklistPatternsHandler ()
		{
			if (cb_getURLBlacklistPatterns == null)
				cb_getURLBlacklistPatterns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURLBlacklistPatterns);
			return cb_getURLBlacklistPatterns;
		}

		static IntPtr n_GetURLBlacklistPatterns (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.URLBlacklistPatterns);
		}
#pragma warning restore 0169

		static Delegate cb_setURLBlacklistPatterns_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetURLBlacklistPatterns_Ljava_util_List_Handler ()
		{
			if (cb_setURLBlacklistPatterns_Ljava_util_List_ == null)
				cb_setURLBlacklistPatterns_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetURLBlacklistPatterns_Ljava_util_List_);
			return cb_setURLBlacklistPatterns_Ljava_util_List_;
		}

		static void n_SetURLBlacklistPatterns_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Crittercism.App.CrittercismConfig __this = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CrittercismConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.URLBlacklistPatterns = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getURLBlacklistPatterns;
		static IntPtr id_setURLBlacklistPatterns_Ljava_util_List_;
		public virtual global::System.Collections.IList URLBlacklistPatterns {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='getURLBlacklistPatterns' and count(parameter)=0]"
			[Register ("getURLBlacklistPatterns", "()Ljava/util/List;", "GetGetURLBlacklistPatternsHandler")]
			get {
				if (id_getURLBlacklistPatterns == IntPtr.Zero)
					id_getURLBlacklistPatterns = JNIEnv.GetMethodID (class_ref, "getURLBlacklistPatterns", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getURLBlacklistPatterns), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getURLBlacklistPatterns", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setURLBlacklistPatterns' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setURLBlacklistPatterns", "(Ljava/util/List;)V", "GetSetURLBlacklistPatterns_Ljava_util_List_Handler")]
			set {
				if (id_setURLBlacklistPatterns_Ljava_util_List_ == IntPtr.Zero)
					id_setURLBlacklistPatterns_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setURLBlacklistPatterns", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setURLBlacklistPatterns_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setURLBlacklistPatterns", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isVersionCodeToBeIncludedInVersionString;
		static IntPtr id_setVersionCodeToBeIncludedInVersionString_Z;
		public bool VersionCodeToBeIncludedInVersionString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='isVersionCodeToBeIncludedInVersionString' and count(parameter)=0]"
			[Register ("isVersionCodeToBeIncludedInVersionString", "()Z", "GetIsVersionCodeToBeIncludedInVersionStringHandler")]
			get {
				if (id_isVersionCodeToBeIncludedInVersionString == IntPtr.Zero)
					id_isVersionCodeToBeIncludedInVersionString = JNIEnv.GetMethodID (class_ref, "isVersionCodeToBeIncludedInVersionString", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVersionCodeToBeIncludedInVersionString);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setVersionCodeToBeIncludedInVersionString' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVersionCodeToBeIncludedInVersionString", "(Z)V", "GetSetVersionCodeToBeIncludedInVersionString_ZHandler")]
			set {
				if (id_setVersionCodeToBeIncludedInVersionString_Z == IntPtr.Zero)
					id_setVersionCodeToBeIncludedInVersionString_Z = JNIEnv.GetMethodID (class_ref, "setVersionCodeToBeIncludedInVersionString", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVersionCodeToBeIncludedInVersionString_Z, new JValue (value));
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		protected static bool A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_delaySendingAppLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='delaySendingAppLoad' and count(parameter)=0]"
		[Register ("delaySendingAppLoad", "()Z", "")]
		public bool DelaySendingAppLoad ()
		{
			if (id_delaySendingAppLoad == IntPtr.Zero)
				id_delaySendingAppLoad = JNIEnv.GetMethodID (class_ref, "delaySendingAppLoad", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_delaySendingAppLoad);
		}

		static IntPtr id_setDelaySendingAppLoad_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismConfig']/method[@name='setDelaySendingAppLoad' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDelaySendingAppLoad", "(Z)V", "")]
		public void SetDelaySendingAppLoad (bool p0)
		{
			if (id_setDelaySendingAppLoad_Z == IntPtr.Zero)
				id_setDelaySendingAppLoad_Z = JNIEnv.GetMethodID (class_ref, "setDelaySendingAppLoad", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDelaySendingAppLoad_Z, new JValue (p0));
		}

	}
}
