using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    public sealed partial class GroupedListPage
    {
        public GroupedListPage()
        {
            this.InitializeComponent();
        }
    }
}
