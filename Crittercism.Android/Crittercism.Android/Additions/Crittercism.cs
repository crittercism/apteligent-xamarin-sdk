using System;
using Android.Runtime;
using Android.Content;
using Android.App;
using Org.Json;
using Java.Lang;

namespace Crittercism.Android
{
	public partial class Crittercism
	{
		public static void Init(Context appContext, string appId) {

			Com.Crittercism.App.Crittercism.Initialize(  appContext, "537fc935b573f15751000002");

			//Appdomain Exception handlers ???
			AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
			{
				//Java.Lang.Exception ex
				Console.WriteLine("-- AppDomain.CurrentDomain.UnhandledException: {0}. IsTerminating: {1}", e.ExceptionObject, e.IsTerminating);
				//LogUnHandledException( e.Equals );
			};

			AndroidEnvironment.UnhandledExceptionRaiser += (object sender, RaiseThrowableEventArgs e) => 
			{
				Console.WriteLine("-- AndroidEnvironment.UnhandledExceptionRaiser: {0}. IsTerminating: {1}", e.Exception, e.Handled);
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

		public static void LogCrashException (Java.Lang.Exception javaException)
		{
			//Console.WriteLine (" LogHandledException " + javaException.ToString());
			Com.Crittercism.App.Crittercism._logCrashException( javaException );
		}

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			Console.WriteLine (" Crittercism.LeaveBreadcrumb " + breadcrumb);
			//Com.Crittercism.App.Crittercism._logCrashException();
		}

		public static void SetMetadata (string key, string value)
		{
			JSONObject jso = new JSONObject();
			jso.Put(key, value);

			Com.Crittercism.App.Crittercism.SetMetadata( jso );
		}

		public static void SetUserName( string username )
		{
			Console.WriteLine (" Crittercism.SetUserName " + username);
			//Com.Crittercism.App.Crittercism.setUsername( username );
		}
		
		public static bool DidCrashOnLastLoad()
		{
			return Com.Crittercism.App.Crittercism.DidCrashOnLastLoad(); 
		}

		public static bool GGetOptOutStatus()
		{
			return Com.Crittercism.App.Crittercism.OptOutStatus;
		}

		public static bool OptOutStatus
		{
			get { return Com.Crittercism.App.Crittercism.OptOutStatus; }
			set { Com.Crittercism.App.Crittercism.OptOutStatus = value; }
		}


	}
}

