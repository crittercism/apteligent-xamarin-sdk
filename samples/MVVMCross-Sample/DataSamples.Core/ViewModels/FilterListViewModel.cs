using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using DataSamples.Infrastructure;
using DataSamples.Models;
using DataSamples.ModelServices;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DataSamples.ViewModels
{
    public class FilterListViewModel : ListViewModelBase<Item>
    {
        public FilterListViewModel()
        {
            // source items, should be plain items, not sorted or filtered
            this.SourceItems = this.Repository.GetAll().ToObservable();

            // set group items
            this.RefreshGroupItems();
        }

        public string TotalItemsText
        {
            get
            {
                if (this.Items.Count() == 0)
                    return "No items.";
                else if (this.Items.Count() == 1)
                    return "1 item";
                else
                    return this.Items.Count() + " items";
            }
        }

        private IItemRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<IItemRepository>())
                    return Container.Current.Resolve<IItemRepository>();
                else
                    return new ItemRepository(); // for designer support
            }
        }

        public override void RefreshGroupItems()
        {
            // Uncomment the following line to display items in plain list
            if (this.Items != null)
                this.GroupItems = this.Items.OrderBy(o => o.Category.Name).GroupBy(o => o.Category.Name).Select(o => new CategoryGroup(o)).ToList();
        }

        protected override void OnSourceItemsChanged(ICollection<Item> items)
        {
            if (items != null)
                this.Items = items.OrderBy(o => o.Name);
            else
                this.Items = null;

            this.RefreshGroupItems();
        }

        public override void Filter(string query, string scope)
        {
            if (string.IsNullOrEmpty(scope) || scope == "Name")
                this.FilterItems = this.Items.Where(o => o.Name.ToLowerInvariant().Contains(query.ToLowerInvariant())).ToList();
            else if (scope == "Location")
                this.FilterItems = this.Items.Where(o => o.Location.ToLowerInvariant().Contains(query.ToLowerInvariant())).ToList();
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            this.RefreshGroupItems();
            this.OnPropertyChanged("TotalItemsText");
            this.OnPropertyChanged("TitleText");

            // WinRT requires GroupItems notification in another UI thread
            if (this.GetService<IApplicationService>().GetContext().Platform.OperatingSystem == OSKind.WinRT)
                this.GetService<IViewService>().RunOnUIThread(() => this.OnPropertyChanged("GroupItems"));
        }
    }
}
