using DataSamples.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DataSamples.ModelServices
{
    public class CategoryRepository : ICategoryRepository
    {
        IEnumerable<Category> _items = null;

        public virtual Category Get(int id)
        {
            return this.GetAll().FirstOrDefault(o => o.Id == id);
        }

        public virtual Category GetByName(string name)
        {
            return this.GetAll().FirstOrDefault(o => o.Name == name);
        }

        public virtual IEnumerable<Category> GetAll()
        {
            if (_items == null)
            {
                XDocument doc = XDocument.Load(typeof(CategoryRepository).Assembly.GetManifestResourceStream("DataSamples.Core.Assets.Data.Categories.xml"));

                var query = from x in doc.Descendants("Category")
                                 select CreateCategory(x);

                _items = query.ToList();
            }

            return _items;
        }

        private Category CreateCategory(XElement x)
        {
            Category category = new Category()
            {
                Name = x.Element("Name").Value,
                Id = int.Parse(x.Element("Id").Value),
                Image = x.Element("Id").Value + ".jpg"
            };

            return category;
        }
    }
}
