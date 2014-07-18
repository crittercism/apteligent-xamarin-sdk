using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    public partial class GroupList : PhoneApplicationPage
    {
        public GroupList()
        {
            InitializeComponent();
        }
    }
}