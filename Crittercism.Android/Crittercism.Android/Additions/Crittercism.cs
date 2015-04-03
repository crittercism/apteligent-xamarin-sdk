using System;
using Android.Runtime;
using Android.Content;
using Android.App;
using Org.Json;
using Java.Lang;
using System.Diagnostics;
using System.Collections.Generic;

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

		private static void LogUnhandledException(RaiseThrowableEventArgs e)
		{
			Java.Lang.Exception javaLangException = ExceptionHelper.createJavaException(e.Exception);
			Com.Crittercism.App.Crittercism._logCrashException(javaLangException);
		}
			
		public static void LogHandledException (System.Exception e)
		{
			Java.Lang.Exception javaLangException = ExceptionHelper.createJavaException (e);
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

		public static void BeginTransaction(string name)
		{
			Com.Crittercism.App.Crittercism.BeginTransaction (name);
		}

		public static void BeginTransaction (string name, int value)
		{
			Com.Crittercism.App.Crittercism.BeginTransaction (name);
			Com.Crittercism.App.Crittercism.SetTransactionValue (name, value);
		}

		public static void EndTransaction(string name)
		{
			Com.Crittercism.App.Crittercism.EndTransaction (name);
		}

		public static void FailTransaction(string name)
		{
			Com.Crittercism.App.Crittercism.FailTransaction (name);
		}

		public static void SetTransactionValue(string name, int value)
		{
			Com.Crittercism.App.Crittercism.SetTransactionValue (name, value);
		}

		public static int GetTransactionValue(string name)
		{
			return Com.Crittercism.App.Crittercism.GetTransactionValue (name);
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

