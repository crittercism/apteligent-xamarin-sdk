using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;
using DataSamples.Infrastructure;
using DataSamples.Models;
using DataSamples.ModelServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace DataSamples.ViewModels
{
    public class GroupListViewModel : ListViewModelBase<Item>
    {
        public GroupListViewModel()
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
    }
}
