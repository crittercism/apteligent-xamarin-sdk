using Intersoft.Crosslight;
using DataSamples.Models;
using System.Collections.Generic;
using System.Linq;
using DataSamples.ModelServices;

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item templates.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace DataSamples.WinRT.Data
{
    public sealed class DesignTimeDataSource
    {
        public IEnumerable<Item> Items { get; private set; }
        public DesignItemDetailViewModel ItemDetailViewModel { get; private set; }
        public IEnumerable<GroupItem<Item>> AllGroups { get; private set; }
        public GroupItem<Item> Group { get; private set; }
        public string ErrorTrace { get; private set; }

        public DesignTimeDataSource()
        {
            ItemRepository repository = new ItemRepository();

            this.Items = repository.GetAll();
            this.AllGroups = this.Items.OrderBy(o => o.Location).GroupBy(o => o.Location).Select(o => new GroupItem<Item>(o)).ToList();
            this.Group = this.AllGroups.First();
            this.ItemDetailViewModel = new DesignItemDetailViewModel(this.Group.First());
        }
    }

    public sealed class DesignItemDetailViewModel
    {
        public Item Item { get; set; }

        public DesignItemDetailViewModel(Item item)
        {
            this.Item = item;
        }
    }
}
