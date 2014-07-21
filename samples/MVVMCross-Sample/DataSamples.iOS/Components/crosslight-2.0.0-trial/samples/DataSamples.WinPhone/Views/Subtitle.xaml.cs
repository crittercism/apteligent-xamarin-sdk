using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("SubtitleCellStyle")]
    public partial class Subtitle : PhoneApplicationPage
    {
        public Subtitle()
        {
            InitializeComponent();
        }
    }
}