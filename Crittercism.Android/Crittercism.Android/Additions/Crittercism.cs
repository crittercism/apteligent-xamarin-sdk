using System;
using System.Collections.Generic;
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

		private static string StackTrace(System.Exception e)
		{
			// Allowing for the fact that the "name" and "reason" of the outermost
			// exception e are already shown in the Crittercism portal, we don't
			// need to repeat that bit of info.  However, for InnerException's, we
			// will include this information in the StackTrace .  The horizontal
			// lines (hyphens) separate InnerException's from each other and the
			// outermost Exception e .
			string answer = e.StackTrace;
			// Using seen for cycle detection to break cycling.
			List<System.Exception> seen = new List<System.Exception>();
			seen.Add(e);
			if (answer != null) {
				// There has to be some way of telling where InnerException ie stacktrace
				// ends and main Exception e stacktrace begins.  This is it.
				answer = ((e.GetType().FullName + " : " + e.Message + "\r\n")
				          + answer);
				System.Exception ie = e.InnerException;
				while ((ie != null) && (seen.IndexOf(ie) < 0)) {
					seen.Add(ie);
					answer = ((ie.GetType().FullName + " : " + ie.Message + "\r\n")
					          + (ie.StackTrace + "\r\n")
					          + answer);
					ie = ie.InnerException;
				}
			} else {
				answer = "";
			}
			return answer;
		}

		public static void LogHandledException(System.Exception e)
		{
			string name = e.GetType().FullName;
			string message = e.Message;
			string stack = StackTrace(e);
			Com.Crittercism.App.Crittercism._logHandledException(name, message, stack);
		}

		private static void LogUnhandledException(RaiseThrowableEventArgs e)
		{
			string name = e.Exception.GetType().FullName;
			string message = e.Exception.Message;
			string stack = StackTrace(e.Exception);
			Com.Crittercism.App.Crittercism._logCrashException(name, message, stack);
		}

		public static void LogNetworkRequest(
			string method,
			string url,
			long responseTime,
			long bytesRead,
			long bytesSent,
			int responseCode,
			int errorCode)
		{
			Com.Crittercism.App.Crittercism.LogNetworkRequest(
				method,
				url,
				responseTime,
				bytesRead,
				bytesSent,
				responseCode,
				errorCode);
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

		public static void BeginUserflow(string name)
		{
			Com.Crittercism.App.Crittercism.BeginUserflow (name);
		}

		public static void BeginUserflow (string name, int value)
		{
			Com.Crittercism.App.Crittercism.BeginUserflow (name);
			Com.Crittercism.App.Crittercism.SetUserflowValue (name, value);
		}

		public static void EndUserflow(string name)
		{
			Com.Crittercism.App.Crittercism.EndUserflow (name);
		}

		public static void FailUserflow(string name)
		{
			Com.Crittercism.App.Crittercism.FailUserflow (name);
		}

		public static void SetUserflowValue(string name, int value)
		{
			Com.Crittercism.App.Crittercism.SetUserflowValue (name, value);
		}

		public static int GetUserflowValue(string name)
		{
			return Com.Crittercism.App.Crittercism.GetUserflowValue (name);
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

		#region Deprecated Methods

		[System.Obsolete("Use BeginUserflow", false)]
		public static void BeginTransaction(string name)
		{
			BeginUserflow (name);
		}

		[System.Obsolete("Use BeginUserflow", false)]
		public static void BeginTransaction (string name, int value)
		{
			BeginUserflow (name);
			SetUserflowValue (name, value);
		}

		[System.Obsolete("Use EndUserflow", false)]
		public static void EndTransaction(string name)
		{
			EndUserflow (name);
		}

		[System.Obsolete("Use FailUserflow", false)]
		public static void FailTransaction(string name)
		{
			FailUserflow (name);
		}

		[System.Obsolete("Use SetUserflowValue", false)]
		public static void SetTransactionValue(string name, int value)
		{
			SetUserflowValue (name, value);
		}

		[System.Obsolete("Use GetUserflowValue", false)]
		public static int GetTransactionValue(string name)
		{
			return GetUserflowValue (name);
		}

		#endregion
	}
}

