using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Simple List", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SimpleListBindingProvider))]
    public class SimpleListActivity : ListActivity<SimpleListViewModel>
    {
        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.None;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }


    }
}