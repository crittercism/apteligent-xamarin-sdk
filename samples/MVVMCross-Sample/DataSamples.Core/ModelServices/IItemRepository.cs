using Intersoft.Crosslight;
using DataSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataSamples.ModelServices
{
    public interface IItemRepository : IEditableDataRepository<Item, string>
    {
        GroupItem<Item> GetLocationGroup(string group);
        CategoryGroup GetCategoryGroup(int group);
    }
}
