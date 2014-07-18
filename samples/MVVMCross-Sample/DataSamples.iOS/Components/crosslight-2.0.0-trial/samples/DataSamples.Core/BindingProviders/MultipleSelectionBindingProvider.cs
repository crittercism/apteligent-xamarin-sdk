using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class MultipleSelectionBindingProvider : CategoryListBindingProvider
    {
        public MultipleSelectionBindingProvider()
            : base()
        {
            this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.SelectedItemsProperty, "SelectedItems", BindingMode.TwoWay);
            this.AddBinding("GetSelectionButton", BindableProperties.CommandProperty, "GetSelectionCommand");
        }
    }
}

