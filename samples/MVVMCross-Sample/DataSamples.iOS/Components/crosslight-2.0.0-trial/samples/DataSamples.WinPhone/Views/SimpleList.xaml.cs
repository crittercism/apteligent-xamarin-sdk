using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(SimpleListViewModel))]
    public partial class SimpleList : PhoneApplicationPage
    {
        public SimpleList()
        {
            InitializeComponent();
        }
    }
}