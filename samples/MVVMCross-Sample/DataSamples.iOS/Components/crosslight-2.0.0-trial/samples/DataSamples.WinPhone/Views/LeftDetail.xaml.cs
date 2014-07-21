using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(CategoryListViewModel))]
    [RegisterNavigation("LeftDetailCellStyle")]
    public partial class LeftDetail : PhoneApplicationPage
    {
        public LeftDetail()
        {
            InitializeComponent();
        }
    }
}