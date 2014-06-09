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
			Crittercism.LogCrashException (javaLangException);
		}

		public static void LogCrashException (Java.Lang.Exception javaException)
		{
			//Console.WriteLine (" LogHandledException " + javaException.ToString());
			Com.Crittercism.App.Crittercism._logCrashException( javaException );
		}

		public static void LeaveBreadcrumb (string breadcrumb)
		{
			Console.WriteLine (" Crittercism.LeaveBreadcrumb " + breadcrumb);
			//Com.Crittercism.App.Crittercism._logCrashException( e);
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
		
		public static bool DidCrashOnLastLoad
		{
			get { return true; /*Com.Crittercism.App.Crittercism.CrashedOnLastLoad;*/ }
		}

		public static bool GetOptOutStatus()
		{
			/*
			ICritterCallback cb = new MyCritterCB ();
			CritterUserDataRequest request = new CritterUserDataRequest (cb);
			request.RequestOptOutStatus ();
			*/
			return false;
		}

		/* 

As a hack for now im implementing the exception handlers for android as per this blog post then calling Crittercism.LogHandledException(Throwable.FromException(e.Exception)); from inside both the events.

It works, but im using Crittercism's handled exceptions for unhandled exceptions.. So when I want to send up real "HandledExceptions" they will be lost in the mess.



		 */

		/*
		public boolean getOptOutStatus() {

			final ConditionVariable condVar = new ConditionVariable(false);


			CritterCallback cb = new CritterCallback() {


				@Override public void onCritterDataReceived(CritterUserData userData) {

					isOptedOut = userData.isOptedOut();

					condVar.open();

				}

			};


			// Instantiate data request object, and specify that it should include

			// information on whether the has opted out.

			CritterUserDataRequest request = new CritterUserDataRequest(cb)

				.requestOptOutStatus()

				.requestDidCrashOnLastLoad();



			request.makeRequest();

			condVar.block();



			return isOptedOut;



			// EXPERIMENTAL MASTODO http://stackoverflow.com/questions/19507452/how-to-handle-monodroid-uncaught-exceptions-globally-and-prevent-application-fro
			// 
			/*

And then on button click I added the following code to raise both types of exceptions:

//foreground exception
throw new NullReferenceException("test nre from ui thread.");
//background exception
ThreadPool.QueueUserWorkItem(unused =>
{
    throw new NullReferenceException("test nre from back thread.");
});


		}
		*/
		

	}
}

