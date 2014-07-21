using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using DataSamples.ViewModels;

namespace DataSamples.Android
{
    [Activity(Label = "Crosslight App", Icon = "@drawable/icon")]
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class MainActivity : ListActivity<NavigationViewModel>
    {
        protected override int ContentLayoutId
        {
            get { return Resource.Layout.listgroupsectionlayout; }
        }

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.listgroupsectionheaderlayout; }
        }

        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.Navigation;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }
    }
}

