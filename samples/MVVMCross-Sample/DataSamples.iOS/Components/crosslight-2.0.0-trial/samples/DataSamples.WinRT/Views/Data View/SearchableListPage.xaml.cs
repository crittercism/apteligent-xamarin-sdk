using System.Collections.Generic;
using DataSamples.Models;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Windows.UI.Xaml;

namespace DataSamples.WinRT.Views
{
    [ViewModelType(typeof(FilterListViewModel))]
    public sealed partial class SearchableListPage
    {
        public SearchableListPage()
        {
            this.InitializeComponent();

            Items = (ICollection<Item>)(ViewModel as FilterListViewModel).Items;
        }

        private ICollection<Item> Items { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                FilterListViewModel viewModel = ViewModel as FilterListViewModel;
                if (viewModel != null)
                {
                    viewModel.Items = Items;
                    viewModel.RefreshGroupItems();
                }
            }
            else
            {
                string query = SearchBox.Text;
                FilterListViewModel viewModel = ViewModel as FilterListViewModel;
                if (viewModel != null)
                {
                    viewModel.Items = Items;
                    viewModel.Filter(query, "Name");
                    viewModel.Items = (ICollection<Item>)(ViewModel as FilterListViewModel).FilterItems;
                    viewModel.RefreshGroupItems();
                }
            }
        }
    }
}
