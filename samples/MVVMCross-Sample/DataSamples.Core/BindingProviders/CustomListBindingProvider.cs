using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class CustomListBindingProvider : BindingProvider
    {
        public CustomListBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Name",
                DetailMemberPath = "Location",
                ImageMemberPath = "ThumbnailImage"
            };

            itemBinding.AddBinding("TextLabel", BindableProperties.TextProperty, "Name");
            itemBinding.AddBinding("DetailTextLabel", BindableProperties.TextProperty, "Location");
            itemBinding.AddBinding("ImageView", BindableProperties.ImageProperty, "ThumbnailImage");
            itemBinding.AddBinding("PriceLabel", BindableProperties.TextProperty, new BindingDescription("Price") { StringFormat = "{0:c}" });

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
        }
    }
}

