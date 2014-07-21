using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Allow Reorder", Icon = "@drawable/icon")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    [RegisterNavigation("ReorderList")]
    public class ReorderListActivity : ListActivity<EditableListViewModel>
    {
        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.tablecellsubtitlewithimage; }
        }

        public override EditingOptions EditingOptions
        {
            get { return EditingOptions.AllowEditing | EditingOptions.AllowReorder; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

    }
}