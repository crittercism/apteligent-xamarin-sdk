using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Item Detail", Icon = "@drawable/icon")]
    [ImportBinding(typeof(ItemDetailBindingProvider))]
    public class ItemDetailActivity : Activity<ItemDetailViewModel>
    {
        protected override int ContentLayoutId
        {
            get { return Resource.Layout.ItemDetailView; }
        }
    }
}