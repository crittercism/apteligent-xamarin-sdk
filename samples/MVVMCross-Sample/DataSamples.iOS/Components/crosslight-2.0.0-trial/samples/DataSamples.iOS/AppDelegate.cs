using MonoTouch.Foundation;
using MonoTouch.UIKit;

using IntersoftCore = Intersoft.Crosslight.iOS;
using System.Linq;

namespace DataSamples.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : IntersoftCore.UIApplicationDelegate
    {
        protected override UIViewController WrapRootViewController(UIViewController contentViewController)
        {
            if (contentViewController is UISplitViewController || contentViewController is UITabBarController)
                return contentViewController;

            return new UINavigationController(contentViewController);
        }
    }
}