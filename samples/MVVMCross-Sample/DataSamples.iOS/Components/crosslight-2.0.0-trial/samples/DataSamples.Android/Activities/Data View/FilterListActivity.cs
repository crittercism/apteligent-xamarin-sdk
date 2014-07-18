using Android.App;
using Android.Content.PM;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Searchable List", LaunchMode = LaunchMode.SingleTop, Icon = "@drawable/icon")]
    [ImportBinding(typeof (SimpleListBindingProvider))]
    public class FilterListActivity : SearchableListActivity<FilterListViewModel>
    {
        #region Properties

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
            get { return ListViewInteraction.None; }
        }

        protected override int ListItemLayoutId
        {
            get { return global::Android.Resource.Layout.SimpleListItem1; }
        }

        protected override int MenuLayoutId
        {
            get { return Resource.Layout.FilterListActionBar; }
        }

        protected override int SearchButtonId
        {
            get { return Resource.Id.SearchButton; }
        }

        protected override string SearchHint
        {
            get { return "Search Product.."; }
        }

        public override string SearchScope
        {
            get { return "Name"; }
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        #endregion
    }
}