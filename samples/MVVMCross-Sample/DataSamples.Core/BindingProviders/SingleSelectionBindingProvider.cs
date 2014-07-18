using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class SingleSelectionBindingProvider : CategoryListBindingProvider
    {
        public SingleSelectionBindingProvider()
            : base()
        {
            this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
            this.AddBinding("GetSelectionButton", BindableProperties.CommandProperty, "GetSelectionCommand");
        }
    }
}

