using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("BatchUpdate")]
    public sealed partial class BatchUpdatePage
    {
        public BatchUpdatePage()
        {
            this.InitializeComponent();
        }
    }
}
