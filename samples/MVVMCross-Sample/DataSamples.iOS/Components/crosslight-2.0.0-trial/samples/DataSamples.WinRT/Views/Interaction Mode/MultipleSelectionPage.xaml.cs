using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Windows.UI.Xaml.Controls;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(CategoryMultipleSelectionViewModel))]
    public sealed partial class MultipleSelectionPage
    {
        public MultipleSelectionPage()
        {
            this.InitializeComponent();
        }
    }
}
