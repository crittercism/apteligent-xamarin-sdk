using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    [RegisterNavigation("GroupStyle")]
    public sealed partial class GroupedListSectionPage
    {
        public GroupedListSectionPage()
        {
            this.InitializeComponent();
        }
    }
}
