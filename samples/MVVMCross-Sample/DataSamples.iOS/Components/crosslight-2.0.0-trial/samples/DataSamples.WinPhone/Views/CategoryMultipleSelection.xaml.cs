using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(CategoryMultipleSelectionViewModel))]
    public partial class CategoryMultipleSelection : PhoneApplicationPage
    {
        public CategoryMultipleSelection()
        {
            InitializeComponent();
        }
    }
}