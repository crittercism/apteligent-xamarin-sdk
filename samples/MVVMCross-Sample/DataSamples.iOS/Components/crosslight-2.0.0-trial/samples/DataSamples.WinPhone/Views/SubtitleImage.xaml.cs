using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("SubtitleImageCellStyle")]
    public partial class SubtitleImage : PhoneApplicationPage
    {
        public SubtitleImage()
        {
            InitializeComponent();
        }
    }
}