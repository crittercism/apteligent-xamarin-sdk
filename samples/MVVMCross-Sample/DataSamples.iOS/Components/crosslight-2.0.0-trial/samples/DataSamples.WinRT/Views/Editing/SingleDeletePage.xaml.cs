using DataSamples.ViewModels;
using Intersoft.Crosslight;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(EditableListViewModel))]
    [RegisterNavigation("SingleDelete")]
    public sealed partial class SingleDeletePage
    {
        public SingleDeletePage()
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
            else
            {
                BottomAppBar.IsOpen = false;
                BottomAppBar.IsSticky = false;
            }
        }
    }
}
