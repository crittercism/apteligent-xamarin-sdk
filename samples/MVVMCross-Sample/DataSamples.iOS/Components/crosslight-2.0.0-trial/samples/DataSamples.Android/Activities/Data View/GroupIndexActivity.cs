using Android.App;
using Intersoft.Crosslight;

namespace DataSamples.Android
{
    [Activity(Label = "Grouped List with Index", Icon = "@drawable/icon")]
    [RegisterNavigation("GroupIndex")]
    public class GroupIndexActivity : GroupListActivity
    {
        protected override bool FastScrollAlwaysVisible
        {
            get { return true; }
        }

        protected override bool FastScrollEnabled
        {
            get { return true; }
        }

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