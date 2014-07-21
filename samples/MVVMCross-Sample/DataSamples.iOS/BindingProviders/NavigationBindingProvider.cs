using Intersoft.Crosslight;

namespace DataSamples
{
    public class NavigationBindingProvider : BindingProvider
    {
        public NavigationBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Title",
                NavigateMemberPath = "Target"
            };

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
            this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
        }
    }
}

