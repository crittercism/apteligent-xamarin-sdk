using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;

namespace DataSamples.iOS
{
    [ImportBinding(typeof(ItemDetailBindingProvider))]
    public partial class ItemDetailViewController : UIViewController<ItemDetailViewModel>
    {
        public ItemDetailViewController() 
            : base ("ItemDetailViewController", null)
        {
            this.NavigationItem.Title = "Item Detail";
        }

        public override bool AutoFitContentSize
        {
            get
            {
                return true;
            }
        }
    }
}

