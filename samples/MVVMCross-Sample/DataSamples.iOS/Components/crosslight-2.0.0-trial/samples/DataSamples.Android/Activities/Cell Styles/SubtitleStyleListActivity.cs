using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Subtitle", Icon = "@drawable/icon")]
    [RegisterNavigation("SubtitleCellStyle")]
    public class SubtitleStyleListActivity : SimpleListActivity
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
            get { return Resource.Layout.tablecellsubtitle; }
        }

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.ListGroupLayout; }
        }

    }
}