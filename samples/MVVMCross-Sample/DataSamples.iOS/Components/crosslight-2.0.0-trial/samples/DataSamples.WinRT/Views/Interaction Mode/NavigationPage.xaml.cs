using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("ListNavigation")]
    public sealed partial class NavigationPage
    {
        public NavigationPage()
        {
            this.InitializeComponent();
        }
    }
}
