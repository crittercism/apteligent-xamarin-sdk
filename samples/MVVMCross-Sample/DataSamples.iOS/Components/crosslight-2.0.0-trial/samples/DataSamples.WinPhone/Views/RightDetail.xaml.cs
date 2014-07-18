using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(CategoryListViewModel))]
    [RegisterNavigation("RightDetailCellStyle")]
    public partial class RightDetail : PhoneApplicationPage
    {
        public RightDetail()
        {
            InitializeComponent();
        }
    }
}