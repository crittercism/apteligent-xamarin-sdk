using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    [RegisterNavigation("GroupStyle")]
    public partial class GroupListSection : PhoneApplicationPage
    {
        public GroupListSection()
        {
            InitializeComponent();
        }
    }
}