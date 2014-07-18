using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Subtitle with Image", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SubtitleListBindingProvider))]
    [RegisterNavigation("SubtitleImageCellStyle")]
    public class SubtitleImageStyleListActivity : SimpleListActivity
    {
        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.tablecellsubtitlewithimage;  }
        }

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.ListGroupLayout; }
        }

    }
}