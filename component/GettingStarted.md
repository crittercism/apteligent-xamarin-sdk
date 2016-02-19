
### Initializing the SDK

Use the ``Crittercism.Init`` API to initialize Crittercism.

#### For iOS Apps

In your AppDelegate.cs: 

```csharp
    using CrittercismIOS;

    public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
    {
        //Initialize Crittercism with your App ID from crittercism.com
        Crittercism.Init("YOUR APP ID GOES HERE");
        return true;
    }
```

#### For Android Apps

In your main activity class:

```csharp
    using CrittercismAndroid;

    protected override void OnCreate (Bundle bundle)
    {
        //Initialize Crittercism with your App ID from crittercism.com
        Crittercism.Init( ApplicationContext, "YOUR APP ID GOES HERE");
    }
```

If you are using MvvmCross with Android, you should initialize the app
in your Setup.cs file:

```csharp
    using CrittercismAndroid;

    public Setup(Context applicationContext) : base(applicationContext)
    {
          Crittercism.Init (applicationContext, "YOUR APP ID GOES HERE");
    }
```

### Logging Handled Exceptions

Use the ``LogHandledException`` API to track error conditions that do not
necessarily cause a crash.

Handled exceptions may be used for tracking exceptions caught in a try/catch
block, testing 3rd party SDKs, and monitoring areas in the code that may
currently be using assertions. Handled exceptions can also be used to track
error events such as low memory warnings. For an introduction, see Handled
Exceptions.

Handled Exceptions will be grouped by stacktrace, much like crash reports.
Handled Exceptions may be viewed in the “Handled Exceptions” area of the
Crittercism portal.

Here’s an example of how to log a handled exception:

```csharp
    try {
          throw new TestException();
    } catch (System.Exception error) {
          Crittercism.LogHandledException(error);
    }
```

### Logging Breadcrumbs

Use the ``LeaveBreadcrumb`` API to write to a chronological log that is reported
with crashes and handled exceptions.

A breadcrumb is a developer-defined text string (up to 140 characters) that
allows developers to capture app run-time information. Example breadcrumbs may
include variable values, progress through the code, user actions, or low memory
warnings. For an introduction, see Breadcrumbs.

Here’s an example of how to leave a breadcrumb:

```csharp
    Crittercism.LeaveBreadcrumb("User started level 5");
```

### Logging User Metadata

Developers can set user metadata to tracking information about individual
users. For an introduction, see User Metadata.

#### Adding a Username

Setting a username will allow the ability to monitor app performance for each
user. Once a username is set, the Crittercism portal’s “Search by User” feature
may be used to lookup a list of crashes and errors a specific user has
experienced. We recommend setting a username to a value that can be tied back
to your customer support system.

Here’s an example of how to set a user name:

```csharp
    Crittercism.Username = "MommaCritter";
```

#### Adding Arbitrary User Metadata

Up to ten key/value pairs of arbitrary metadata may be set for each user. The
data will be displayed on the developer portal when viewing a user profile.

Here’s an example of how to associate metadata with the current user:

```csharp
    Crittercism.SetMetadata("5", "GameLevel");
```

### Logging Userflows

Userflows allows companies to track key interactions or user flows in their
app such as login, account registration, and in app purchase.  By default, the
SDK will automatically track application load time as a userflow.  You can
specify additional userflows by adding a few more lines of code to your
application. 

Developers must add code to specify where a userflow starts and where a
userflow ends. All other API calls are optional. If a crash occurs, all
in-flight userflows will automatically be failed and reported with the
crash. Use the ``BeginUserflow``, ``EndUserflow``, and ``FailUserflow``
methods to log userflows. 

Here's an example of how to log a single userflow:

```csharp
    Crittercism.BeginUserflow("login");
    // Run the code you want to monitor
    bool didLogin = RunMyLoginCode();
    if (didLogin) {
        Crittercism.EndUserflow("login");
    } else {
        Crittercism.FailUserflow("login");
    }
```

When beginning a userflow, you can also assign the userflow a value:

```csharp
    int valueInCents = 100;
    Crittercism.BeginUserflow("my_userflow", valueInCents);
```

Use the ``SetUserflowValue`` and ``GetUserflowValue`` methods to modify
the value of a userflow. The value of a userflow should be specified in
cents.

```csharp
    int itemValueInCents = 100;
    int totalValueInCents = 100 + Crittercism.GetUserflowValue("shopping cart");
    Crittercism.SetUserflowValue("shopping cart", totalValueInCents);
```

### Other Resources

View the full Crittercism documentation at http://docs.crittercism.com

