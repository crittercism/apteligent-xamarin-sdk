using Android.App;
using Android.Content;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Custom Template", Icon = "@drawable/icon")]
    [ImportBinding(typeof(CustomListBindingProvider))]
    [RegisterNavigation("CustomCellStyle")]
    public class CustomStyleActivity : ListActivity<SimpleListViewModel>
    {
        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.None;
            }
        }

        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.CustomTableCell; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }
    }
}