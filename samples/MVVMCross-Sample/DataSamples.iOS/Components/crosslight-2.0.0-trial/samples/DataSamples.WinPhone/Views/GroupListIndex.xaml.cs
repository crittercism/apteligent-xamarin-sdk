using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    [RegisterNavigation("GroupIndex")]
    public partial class GroupListIndex : PhoneApplicationPage
    {
        public GroupListIndex()
        {
            InitializeComponent();
        }
    }
}