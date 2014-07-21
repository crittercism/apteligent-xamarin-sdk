using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("CustomCellStyle")]
    public sealed partial class CustomTemplatePage
    {
        public CustomTemplatePage()
        {
            this.InitializeComponent();
        }
    }
}
