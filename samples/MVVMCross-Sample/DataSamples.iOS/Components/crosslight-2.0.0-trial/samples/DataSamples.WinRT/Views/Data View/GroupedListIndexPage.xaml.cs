using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Windows.UI.Xaml.Controls;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(GroupListViewModel))]
    [RegisterNavigation("GroupIndex")]
    public sealed partial class GroupedListIndexPage
    {
        public GroupedListIndexPage()
        {
            this.InitializeComponent();
        }

        protected override void OnViewCreated()
        {
            base.OnViewCreated();

            if (GroupedItems.View != null)
            {
                var collectionGroups = GroupedItems.View.CollectionGroups;
                ((ListViewBase)this.Zoom.ZoomedOutView).ItemsSource = collectionGroups;
            }
        }
    }
}
