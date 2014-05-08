using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Crittercism.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']"
	[global::Android.Runtime.Register ("com/crittercism/app/CrittercismNDK", DoNotGenerateAcw=true)]
	public partial class CrittercismNDK : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/crittercism/app/CrittercismNDK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CrittercismNDK); }
		}

		protected CrittercismNDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/constructor[@name='CrittercismNDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CrittercismNDK () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CrittercismNDK)) {
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

		static IntPtr id_isNdkCrashReportingInstalled;
		public static bool IsNdkCrashReportingInstalled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='isNdkCrashReportingInstalled' and count(parameter)=0]"
			[Register ("isNdkCrashReportingInstalled", "()Z", "GetIsNdkCrashReportingInstalledHandler")]
			get {
				if (id_isNdkCrashReportingInstalled == IntPtr.Zero)
					id_isNdkCrashReportingInstalled = JNIEnv.GetStaticMethodID (class_ref, "isNdkCrashReportingInstalled", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNdkCrashReportingInstalled);
			}
		}

		static IntPtr id_checkLibraryVersion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='checkLibraryVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkLibraryVersion", "(I)Z", "")]
		public static bool CheckLibraryVersion (int p0)
		{
			if (id_checkLibraryVersion_I == IntPtr.Zero)
				id_checkLibraryVersion_I = JNIEnv.GetStaticMethodID (class_ref, "checkLibraryVersion", "(I)Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkLibraryVersion_I, new JValue (p0));
		}

		static IntPtr id_copyLibFromAssets_Landroid_content_Context_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='copyLibFromAssets' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("copyLibFromAssets", "(Landroid/content/Context;Ljava/io/File;)Z", "")]
		public static bool CopyLibFromAssets (global::Android.Content.Context p0, global::Java.IO.File p1)
		{
			if (id_copyLibFromAssets_Landroid_content_Context_Ljava_io_File_ == IntPtr.Zero)
				id_copyLibFromAssets_Landroid_content_Context_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "copyLibFromAssets", "(Landroid/content/Context;Ljava/io/File;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_copyLibFromAssets_Landroid_content_Context_Ljava_io_File_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_doNdkSharedLibrariesExist_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='doNdkSharedLibrariesExist' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("doNdkSharedLibrariesExist", "(Landroid/content/Context;)Z", "")]
		public static bool DoNdkSharedLibrariesExist (global::Android.Content.Context p0)
		{
			if (id_doNdkSharedLibrariesExist_Landroid_content_Context_ == IntPtr.Zero)
				id_doNdkSharedLibrariesExist_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "doNdkSharedLibrariesExist", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_doNdkSharedLibrariesExist_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getInstalledLibraryFile_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='getInstalledLibraryFile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstalledLibraryFile", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static global::Java.IO.File GetInstalledLibraryFile (global::Android.Content.Context p0)
		{
			if (id_getInstalledLibraryFile_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstalledLibraryFile_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstalledLibraryFile", "(Landroid/content/Context;)Ljava/io/File;");
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstalledLibraryFile_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getJarredLibFileStream_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='getJarredLibFileStream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getJarredLibFileStream", "(Landroid/content/Context;)Ljava/io/InputStream;", "")]
		public static global::System.IO.Stream GetJarredLibFileStream (global::Android.Content.Context p0)
		{
			if (id_getJarredLibFileStream_Landroid_content_Context_ == IntPtr.Zero)
				id_getJarredLibFileStream_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getJarredLibFileStream", "(Landroid/content/Context;)Ljava/io/InputStream;");
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJarredLibFileStream_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_installNdk_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='installNdk' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("installNdk", "(Ljava/lang/String;)Z", "")]
		public static bool InstallNdk (string p0)
		{
			if (id_installNdk_Ljava_lang_String_ == IntPtr.Zero)
				id_installNdk_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "installNdk", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_installNdk_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_installNdkLib_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='installNdkLib' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("installNdkLib", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void InstallNdkLib (global::Android.Content.Context p0, string p1)
		{
			if (id_installNdkLib_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_installNdkLib_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "installNdkLib", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_installNdkLib_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_loadLibraryFromAssets_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.crittercism.app']/class[@name='CrittercismNDK']/method[@name='loadLibraryFromAssets' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadLibraryFromAssets", "(Landroid/content/Context;)Z", "")]
		public static bool LoadLibraryFromAssets (global::Android.Content.Context p0)
		{
			if (id_loadLibraryFromAssets_Landroid_content_Context_ == IntPtr.Zero)
				id_loadLibraryFromAssets_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadLibraryFromAssets", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_loadLibraryFromAssets_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

	}
}
