using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("MultipleDelete")]
    public partial class MultipleDelete : PhoneApplicationPage
    {
        public MultipleDelete()
        {
            InitializeComponent();
        }
    }
}