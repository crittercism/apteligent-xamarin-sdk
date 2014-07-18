using System.Collections.Generic;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;
using DataSamples.Models;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(FilterListViewModel))]
    public partial class FilterList : PhoneApplicationPage
    {
        public FilterList()
        {
            InitializeComponent();

            Items = (ICollection<Item>)(ViewModel as FilterListViewModel).Items;
        }

        private ICollection<Item> Items { get; set; }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
            SearchArea.Visibility = SearchArea.Visibility == System.Windows.Visibility.Visible ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(SearchBox.Text))
            {
                (ViewModel as FilterListViewModel).Items = Items;
                (ViewModel as FilterListViewModel).RefreshGroupItems();
            }
            else
            {
                string query = SearchBox.Text;
                (ViewModel as FilterListViewModel).Items = Items;
                (ViewModel as FilterListViewModel).Filter(query, "Name");
                (ViewModel as FilterListViewModel).Items = (ICollection<Item>)(ViewModel as FilterListViewModel).FilterItems;
                (ViewModel as FilterListViewModel).RefreshGroupItems();
            }
        }
    }
}