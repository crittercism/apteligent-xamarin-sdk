using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("ReorderList")]
    public partial class ReorderList : PhoneApplicationPage
    {
        public ReorderList()
        {
            InitializeComponent();
        }
    }
}