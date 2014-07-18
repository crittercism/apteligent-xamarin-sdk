using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Right Detail", Icon = "@drawable/icon")]
    [ImportBinding(typeof(CategoryListBindingProvider))]
    [RegisterNavigation("RightDetailCellStyle")]
    public class RightDetailListActivity : ListActivity<CategoryListViewModel>
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
            get { return Resource.Layout.tablecellrightdetail; }
        }

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.ListGroupLayout; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }


    }
}