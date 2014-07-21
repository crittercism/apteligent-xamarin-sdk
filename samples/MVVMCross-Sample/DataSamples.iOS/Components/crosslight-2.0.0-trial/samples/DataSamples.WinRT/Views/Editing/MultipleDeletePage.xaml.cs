using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Windows.UI.Xaml.Controls;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("MultipleDelete")]
    public sealed partial class MultipleDeletePage
    {
        public MultipleDeletePage()
        {
            this.InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                BottomAppBar.IsOpen = true;
                BottomAppBar.IsSticky = true;
            }
            if ((sender as ListView).SelectedItems.Count == 0)
            {
                BottomAppBar.IsOpen = false;
                BottomAppBar.IsSticky = false;
            }
        }
    }
}
