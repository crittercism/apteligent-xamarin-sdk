using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']"
	[global::Android.Runtime.Register ("com/crittercism/app/Crittercism", DoNotGenerateAcw=true)]
	public partial class Crittercism : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/Crittercism", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Crittercism); }
		}

		protected Crittercism (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id__logCrashException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='_logCrashException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("_logCrashException", "(Ljava/lang/Throwable;)V", "")]
		public static void _logCrashException (global::Java.Lang.Throwable p0)
		{
			if (id__logCrashException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id__logCrashException_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "_logCrashException", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id__logCrashException_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_generateRateMyAppAlertDialog_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='generateRateMyAppAlertDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("generateRateMyAppAlertDialog", "(Landroid/content/Context;)Landroid/app/AlertDialog;", "")]
		public static global::Android.App.AlertDialog GenerateRateMyAppAlertDialog (global::Android.Content.Context p0)
		{
			if (id_generateRateMyAppAlertDialog_Landroid_content_Context_ == IntPtr.Zero)
				id_generateRateMyAppAlertDialog_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "generateRateMyAppAlertDialog", "(Landroid/content/Context;)Landroid/app/AlertDialog;");
			global::Android.App.AlertDialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateRateMyAppAlertDialog_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_generateRateMyAppAlertDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='generateRateMyAppAlertDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("generateRateMyAppAlertDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/app/AlertDialog;", "")]
		public static global::Android.App.AlertDialog GenerateRateMyAppAlertDialog (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_generateRateMyAppAlertDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateRateMyAppAlertDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generateRateMyAppAlertDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/app/AlertDialog;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Android.App.AlertDialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateRateMyAppAlertDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void Initialize (global::Android.Content.Context p0, string p1)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_crittercism_app_CrittercismConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.crittercism.app.CrittercismConfig']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/crittercism/app/CrittercismConfig;)V", "")]
		public static void Initialize (global::Android.Content.Context p0, string p1, global::Com.Crittercism.App.CrittercismConfig p2)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_crittercism_app_CrittercismConfig_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_crittercism_app_CrittercismConfig_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/crittercism/app/CrittercismConfig;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_crittercism_app_CrittercismConfig_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_performRateMyAppButtonAction_Lcom_crittercism_app_CritterRateMyAppButtons_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='performRateMyAppButtonAction' and count(parameter)=1 and parameter[1][@type='com.crittercism.app.CritterRateMyAppButtons']]"
		[Register ("performRateMyAppButtonAction", "(Lcom/crittercism/app/CritterRateMyAppButtons;)V", "")]
		public static void PerformRateMyAppButtonAction (global::Com.Crittercism.App.CritterRateMyAppButtons p0)
		{
			if (id_performRateMyAppButtonAction_Lcom_crittercism_app_CritterRateMyAppButtons_ == IntPtr.Zero)
				id_performRateMyAppButtonAction_Lcom_crittercism_app_CritterRateMyAppButtons_ = JNIEnv.GetStaticMethodID (class_ref, "performRateMyAppButtonAction", "(Lcom/crittercism/app/CritterRateMyAppButtons;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_performRateMyAppButtonAction_Lcom_crittercism_app_CritterRateMyAppButtons_, new JValue (p0));
		}

		static IntPtr id_sendAppLoadData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='sendAppLoadData' and count(parameter)=0]"
		[Register ("sendAppLoadData", "()V", "")]
		public static void SendAppLoadData ()
		{
			if (id_sendAppLoadData == IntPtr.Zero)
				id_sendAppLoadData = JNIEnv.GetStaticMethodID (class_ref, "sendAppLoadData", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAppLoadData);
		}

		static IntPtr id_setMetadata_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setMetadata", "(Lorg/json/JSONObject;)V", "")]
		public static void SetMetadata (global::Org.Json.JSONObject p0)
		{
			if (id_setMetadata_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setMetadata_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "setMetadata", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setMetadata_Lorg_json_JSONObject_, new JValue (p0));
		}

		static IntPtr id_setOptOutStatus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='setOptOutStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOptOutStatus", "(Z)V", "")]
		public static void SetOptOutStatus (bool p0)
		{
			if (id_setOptOutStatus_Z == IntPtr.Zero)
				id_setOptOutStatus_Z = JNIEnv.GetStaticMethodID (class_ref, "setOptOutStatus", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setOptOutStatus_Z, new JValue (p0));
		}

		static IntPtr id_setUsername_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUsername", "(Ljava/lang/String;)V", "")]
		public static void SetUsername (string p0)
		{
			if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
				id_setUsername_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setUsername_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_updateLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='Crittercism']/method[@name='updateLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("updateLocation", "(Landroid/location/Location;)V", "")]
		public static void UpdateLocation (global::Android.Locations.Location p0)
		{
			if (id_updateLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_updateLocation_Landroid_location_Location_ = JNIEnv.GetStaticMethodID (class_ref, "updateLocation", "(Landroid/location/Location;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_updateLocation_Landroid_location_Location_, new JValue (p0));
		}

	}
}
