using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("SubtitleImageCellStyle")]
    public sealed partial class SubtitleWithImagePage
    {
        public SubtitleWithImagePage()
        {
            this.InitializeComponent();
        }
    }
}
