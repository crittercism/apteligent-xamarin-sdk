using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']"
	[global::Android.Runtime.Register ("com/crittercism/app/CritterRateMyAppButtons", DoNotGenerateAcw=true)]
	public sealed partial class CritterRateMyAppButtons : global::Java.Lang.Enum {


		static IntPtr LATER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']/field[@name='LATER']"
		[Register ("LATER")]
		public static global::Com.Crittercism.App.CritterRateMyAppButtons Later {
			get {
				if (LATER_jfieldId == IntPtr.Zero)
					LATER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATER", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterRateMyAppButtons> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LATER_jfieldId == IntPtr.Zero)
					LATER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATER", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, LATER_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']/field[@name='NO']"
		[Register ("NO")]
		public static global::Com.Crittercism.App.CritterRateMyAppButtons No {
			get {
				if (NO_jfieldId == IntPtr.Zero)
					NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterRateMyAppButtons> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NO_jfieldId == IntPtr.Zero)
					NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NO_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr YES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']/field[@name='YES']"
		[Register ("YES")]
		public static global::Com.Crittercism.App.CritterRateMyAppButtons Yes {
			get {
				if (YES_jfieldId == IntPtr.Zero)
					YES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YES", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterRateMyAppButtons> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (YES_jfieldId == IntPtr.Zero)
					YES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YES", "Lcom/crittercism/app/CritterRateMyAppButtons;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, YES_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/CritterRateMyAppButtons", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CritterRateMyAppButtons); }
		}

		internal CritterRateMyAppButtons (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/crittercism/app/CritterRateMyAppButtons;", "")]
		public static global::Com.Crittercism.App.CritterRateMyAppButtons ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/crittercism/app/CritterRateMyAppButtons;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Crittercism.App.CritterRateMyAppButtons __ret = global::Java.Lang.Object.GetObject<global::Com.Crittercism.App.CritterRateMyAppButtons> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CritterRateMyAppButtons']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/crittercism/app/CritterRateMyAppButtons;", "")]
		public static global::Com.Crittercism.App.CritterRateMyAppButtons[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/crittercism/app/CritterRateMyAppButtons;");
			return (global::Com.Crittercism.App.CritterRateMyAppButtons[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Crittercism.App.CritterRateMyAppButtons));
		}

	}
}
