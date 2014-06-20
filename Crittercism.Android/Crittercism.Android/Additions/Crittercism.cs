using System;
using Android.Runtime;
using Android.Content;
using Android.App;
using Org.Json;
using Java.Lang;

namespace CrittercismAndroid
{
	public partial class Crittercism
	{
		public static void Init(Context appContext, string appId) {

			Com.Crittercism.App.Crittercism.Initialize(  appContext, appId);

			//Appdomain Exception handlers
			AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
			{
				//Console.WriteLine("-- AppDomain.CurrentDomain.UnhandledException: {0}. IsTerminating: {1}", e.ExceptionObject, e.IsTerminating);
			};

			AndroidEnvironment.UnhandledExceptionRaiser += (object sender, RaiseThrowableEventArgs e) => 
			{
				//Console.WriteLine("-- AndroidEnvironment.UnhandledExceptionRaiser: {0}. IsTerminating: {1}", e.Exception, e.Handled);
				LogUnHandledException( e );
				e.Handled = true;
			};
		}

		public static void LogUnHandledException( RaiseThrowableEventArgs e )
		{
			//Console.WriteLine (" LogUnHandledException " + e.Exception.ToString());
			Java.Lang.Exception javaLangException = new Java.Lang.Exception();
			javaLangException.FillInStackTrace ();
			LogCrashException (javaLangException);
		}

		//TODO: Error - Crittercism does not contain a definition for 'log handled exception'
		public static void LogHandledException (Throwable paramThrowable)
		{
			Com.Crittercism.App.Crittercism.LogHandledException (paramThrowable);
//			Java.Lang.Exception sdfg = new Java.Lang.Exception();
//			Com.Crittercism.App.Crittercism.logHandledException (sdfg);
//			Com.Crittercism.App.Crittercism.logHandledException (paramThrowable);
		}

		public static void LogCrashException (Java.Lang.Exception javaException)
		{
			Com.Crittercism.App.Crittercism._logCrashException( javaException );
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

