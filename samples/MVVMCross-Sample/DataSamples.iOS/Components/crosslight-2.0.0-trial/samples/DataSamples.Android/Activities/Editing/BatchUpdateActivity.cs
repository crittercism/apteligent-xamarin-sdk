using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Batch Update", Icon = "@drawable/icon")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    [RegisterNavigation("BatchUpdate")]
    public class BatchUpdateActivity : ListActivity<EditableListViewModel>
    {
        protected override int MenuLayoutId
        {
            get { return Resource.Layout.BatchUpdateActionBar; }
        }

        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.tablecellsubtitlewithimage; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

    }
}