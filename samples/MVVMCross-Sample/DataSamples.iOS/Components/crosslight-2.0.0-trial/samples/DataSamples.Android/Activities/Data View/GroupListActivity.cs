using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Group List", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SimpleListBindingProvider))]
    public class GroupListActivity : ListActivity<GroupListViewModel>
    {
        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.None;
            }
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