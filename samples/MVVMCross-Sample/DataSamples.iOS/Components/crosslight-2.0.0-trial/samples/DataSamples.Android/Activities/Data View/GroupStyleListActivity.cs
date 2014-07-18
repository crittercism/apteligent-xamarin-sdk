using Android.App;
using Intersoft.Crosslight;

namespace DataSamples.Android
{
    [Activity(Label = "Grouped List (Section)", Icon = "@drawable/icon")]
    [RegisterNavigation("GroupStyle")]
    public class GroupStyleListActivity : GroupListActivity
    {
        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.listgroupsectionheaderlayout; }
        }

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.listgroupsectionlayout; }
        }
    }
}