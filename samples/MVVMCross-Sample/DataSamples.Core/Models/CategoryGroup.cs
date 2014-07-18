using Intersoft.Crosslight;
using DataSamples.Infrastructure;
using DataSamples.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataSamples.Models
{
    public partial class CategoryGroup : GroupItem<Item>
    {
        public Category Category { get; private set; }

        private ICategoryRepository CategoryRepository
        {
            get
            {
                return Container.Current.Resolve<ICategoryRepository>();
            }
        }

        private IItemRepository ItemRepository
        {
            get
            {
                return Container.Current.Resolve<IItemRepository>();
            }
        }

        public CategoryGroup(IGrouping<string, Item> groupItem)
            : base(groupItem)
        {
            this.Category = this.CategoryRepository.GetByName(groupItem.Key);
        }
    }
}
