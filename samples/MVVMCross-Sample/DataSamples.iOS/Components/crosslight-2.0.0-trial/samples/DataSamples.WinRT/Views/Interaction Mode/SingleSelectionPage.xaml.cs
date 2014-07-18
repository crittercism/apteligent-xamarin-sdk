using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(CategorySelectionViewModel))]
    public sealed partial class SingleSelectionPage
    {
        public SingleSelectionPage()
        {
            this.InitializeComponent();
        }
    }
}
