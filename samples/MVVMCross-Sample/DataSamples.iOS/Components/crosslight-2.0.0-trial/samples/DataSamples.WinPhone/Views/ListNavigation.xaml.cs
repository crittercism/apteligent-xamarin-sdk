using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("ListNavigation")]
    public partial class ListNavigation : PhoneApplicationPage
    {
        public ListNavigation()
        {
            InitializeComponent();
        }
    }
}