using System;
using Android.Runtime;
using Android.Content;
using Android.App;
using Org.Json;
using Java.Lang;
using System.Diagnostics;

namespace CrittercismAndroid
{
	public partial class Crittercism
	{
		public static void Init(Context appContext, string appId) {

			Com.Crittercism.App.Crittercism.Initialize( appContext, appId );

			//Appdomain Exception handlers
			AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
			{

			};

			AndroidEnvironment.UnhandledExceptionRaiser += (object sender, RaiseThrowableEventArgs e) => 
			{
				LogUnhandledException( e );
				e.Handled = true;
			};
		}

		// Takes the contents of a C# exception and stuffs them into a java exception.
		// This is used to feed into the Crittercism Android SDK.
		private static Java.Lang.Exception createJavaException( System.Exception e )
		{
			Java.Lang.Exception javaLangException = new Java.Lang.Exception (e.Message);

			StackTrace stackTrace = new StackTrace (e, true);
			Java.Lang.StackTraceElement[] javaStackElements = new StackTraceElement[stackTrace.FrameCount];

			for (int i = 0; i < stackTrace.FrameCount; i++) {
				StackFrame frame = stackTrace.GetFrame (i);

				javaStackElements[i] = new Java.Lang.StackTraceElement (
					frame.GetMethod().DeclaringType.Name,
					frame.GetMethod().Name,
					frame.GetFileName(),
					frame.GetFileLineNumber());
			}

			javaLangException.SetStackTrace (javaStackElements);

			return javaLangException;
		}

		private static void LogUnhandledException( RaiseThrowableEventArgs e )
		{
			Java.Lang.Exception javaLangException = createJavaException (e.Exception);
			Com.Crittercism.App.Crittercism._logCrashException( javaLangException );
		}
			
		public static void LogHandledException (System.Exception e)
		{
			Java.Lang.Exception javaLangException = createJavaException (e);
			Com.Crittercism.App.Crittercism.LogHandledException (javaLangException);
		}

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			Com.Crittercism.App.Crittercism.LeaveBreadcrumb (breadcrumb);
		}

		public static void SetUserName( string username )
		{
			Com.Crittercism.App.Crittercism.SetUsername( username );
		}

		public static void SetMetadata (string key, string value)
		{
			JSONObject jso = new JSONObject();
			jso.Put(key, value);

			Com.Crittercism.App.Crittercism.SetMetadata( jso );
		}

		public static bool DidCrashOnLastLoad()
		{
			return Com.Crittercism.App.Crittercism.DidCrashOnLastLoad(); 
		}

		public static bool OptOutStatus
		{
			get { return Com.Crittercism.App.Crittercism.OptOutStatus; }
			set { Com.Crittercism.App.Crittercism.OptOutStatus = value; }
		}

	}
}

