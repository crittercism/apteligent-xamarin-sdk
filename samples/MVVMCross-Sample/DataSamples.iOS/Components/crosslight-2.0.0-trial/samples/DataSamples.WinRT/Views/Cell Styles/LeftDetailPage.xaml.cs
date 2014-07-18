using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(CategoryListViewModel))]
    [RegisterNavigation("LeftDetailCellStyle")]
    public sealed partial class LeftDetailPage
    {
        public LeftDetailPage()
        {
            this.InitializeComponent();
        }
    }
}
