using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class ItemDetailBindingProvider : BindingProvider
    {
        public ItemDetailBindingProvider()
        {
            this.AddBinding("NameLabel", BindableProperties.TextProperty, "Item.Name");
            this.AddBinding("LocationLabel", BindableProperties.TextProperty, "Item.Location");
            this.AddBinding("PriceLabel", BindableProperties.TextProperty, new BindingDescription("Item.Price") { StringFormat = "{0:c}" });
            this.AddBinding("ImageView", BindableProperties.ImageProperty, "Item.ThumbnailImage");

            this.AddBinding("DescriptionLabel", BindableProperties.TextProperty, "Item.Description");
            this.AddBinding("CategoryLabel", BindableProperties.TextProperty, "Item.Category.Name");
            this.AddBinding("QtyLabel", BindableProperties.TextProperty, "Item.Quantity");
            this.AddBinding("PurchaseDateLabel", BindableProperties.TextProperty, new BindingDescription("Item.PurchaseDate") { StringFormat = "{0:d}" });
        }
    }
}

