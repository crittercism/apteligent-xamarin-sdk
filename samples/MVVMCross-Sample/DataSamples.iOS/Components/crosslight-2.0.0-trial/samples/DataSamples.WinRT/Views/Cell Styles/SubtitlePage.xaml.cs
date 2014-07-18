using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("SubtitleCellStyle")]
    public sealed partial class SubtitlePage
    {
        public SubtitlePage()
        {
            this.InitializeComponent();
        }
    }
}
