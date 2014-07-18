using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("ReorderList")]
    public sealed partial class AllowReorderPage
    {
        public AllowReorderPage()
        {
            this.InitializeComponent();
        }
    }
}
