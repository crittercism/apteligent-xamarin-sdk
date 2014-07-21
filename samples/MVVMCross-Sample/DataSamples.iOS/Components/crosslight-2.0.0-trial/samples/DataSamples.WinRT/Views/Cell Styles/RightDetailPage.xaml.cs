using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(CategoryListViewModel))]
    [RegisterNavigation("RightDetailCellStyle")]
    public sealed partial class RightDetailPage
    {
        public RightDetailPage()
        {
            this.InitializeComponent();
        }
    }
}
