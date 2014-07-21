using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;
using DataSamples.Infrastructure;
using DataSamples.Models;
using DataSamples.ModelServices;
using System.Collections.Generic;
using System.Linq;

namespace DataSamples.ViewModels
{
    public class SimpleListViewModel : ListViewModelBase<Item>
    {
        public SimpleListViewModel()
        {
            // source items, should be plain items, not sorted or filtered
            this.SourceItems = this.Repository.GetAll().ToObservable();
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

		protected override void OnSourceItemsChanged(ICollection<Item> items)
		{
			if (items != null)
				this.Items = items.OrderBy(o => o.Name);
			else
				this.Items = null;
		}
    }
}
