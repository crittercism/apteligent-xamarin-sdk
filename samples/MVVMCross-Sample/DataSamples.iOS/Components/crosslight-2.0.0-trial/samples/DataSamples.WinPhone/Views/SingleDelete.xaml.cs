using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("SingleDelete")]
    public partial class SingleDelete : PhoneApplicationPage
    {
        public SingleDelete()
        {
            InitializeComponent();
        }
    }
}