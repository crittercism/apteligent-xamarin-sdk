using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("BatchUpdate")]
    public partial class BatchUpdate : PhoneApplicationPage
    {
        public BatchUpdate()
        {
            InitializeComponent();
        }
    }
}