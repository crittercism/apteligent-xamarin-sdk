using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(ItemDetailViewModel))]
    public partial class ItemDetail : PhoneApplicationPage
    {
        public ItemDetail()
        {
            InitializeComponent();
        }
    }
}