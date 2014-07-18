using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "About This Sample", Icon = "@drawable/icon")]
    [ImportBinding(typeof(AboutBindingProvider))]
    public class BindingModeActivity : Activity<AboutViewModel>
    {
        public BindingModeActivity()
            : base(Resource.Layout.AboutView)
        {

        }
    }
}

