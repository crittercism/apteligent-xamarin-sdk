using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    public sealed partial class SimpleListPage
    {
        public SimpleListPage()
        {
            this.InitializeComponent();
        }
    }
}
