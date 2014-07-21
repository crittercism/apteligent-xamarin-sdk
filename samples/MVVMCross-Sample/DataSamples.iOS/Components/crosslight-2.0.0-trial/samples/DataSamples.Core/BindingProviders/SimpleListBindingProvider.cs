using Intersoft.Crosslight;

namespace DataSamples
{
    public class SimpleListBindingProvider : BindingProvider
    {
        public SimpleListBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Name",
                DetailMemberPath = "Location"
            };

            itemBinding.AddBinding("TextLabel", BindableProperties.TextProperty, "Name");
            itemBinding.AddBinding("DetailTextLabel", BindableProperties.TextProperty, "Name");

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
        }
    }
}

