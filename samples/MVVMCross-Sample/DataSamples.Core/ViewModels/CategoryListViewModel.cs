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
    public class CategoryListViewModel : ListViewModelBase<Category>
    {
        public CategoryListViewModel()
        {
            // source items, should be plain items, not sorted or filtered
            this.SourceItems = this.Repository.GetAll().ToObservable();

            foreach (Category category in this.SourceItems)
                category.ItemCountText = this.ItemRepository.GetAll().Count(o => o.Category.Id == category.Id) + " items";
        }

        private ICategoryRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<ICategoryRepository>())
                    return Container.Current.Resolve<ICategoryRepository>();
                else
                    return new CategoryRepository(); // for designer support
            }
        }

        private IItemRepository ItemRepository
        {
            get
            {
                if (Container.Current.CanResolve<IItemRepository>())
                    return Container.Current.Resolve<ItemRepository>();
                else
                    return new ItemRepository(); // for designer support
            }
        }

		protected override void OnSourceItemsChanged(ICollection<Category> items)
		{
			if (items != null)
				this.Items = items.OrderBy(o => o.Name);
			else
				this.Items = null;
		}
    }
}
