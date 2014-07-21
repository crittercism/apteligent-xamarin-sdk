using DataSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataSamples.ModelServices
{
    public interface ICategoryRepository : IDataRepository<Category, int>
    {
        Category GetByName(string name);
    }
}
