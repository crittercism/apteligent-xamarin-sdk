using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Navigation", Icon = "@drawable/icon")]
    [RegisterNavigation("ListNavigation")]
    public class ListNavigationListActivity : SubtitleImageStyleListActivity
    {
        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.Navigation;
            }
        }
    }
}