using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class CategoryListBindingProvider : BindingProvider
    {
        public CategoryListBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Name",
                DetailMemberPath = "ItemCountText"
            };

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
        }
    }
}

