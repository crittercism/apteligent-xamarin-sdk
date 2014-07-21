using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    [RegisterNavigation("CustomCellStyle")]
    public partial class CustomTemplate : PhoneApplicationPage
    {
        public CustomTemplate()
        {
            InitializeComponent();
        }
    }
}