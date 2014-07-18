using System;
using Intersoft.Crosslight;

namespace DataSamples
{
    public class EditableListBindingProvider : SubtitleListBindingProvider
    {
        public EditableListBindingProvider()
        {
            this.AddBinding("TableView", BindableProperties.DeleteItemCommandProperty, "DeleteCommand");
            this.AddBinding("TableView", BindableProperties.ReorderItemCommandProperty, "ReorderCommand");
            this.AddBinding("TableView", BindableProperties.IsEditingProperty, "IsEditing", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.IsBatchUpdatingProperty, "IsBatchUpdating", BindingMode.TwoWay);
            this.AddBinding("TableView", BindableProperties.SelectedItemsProperty, "SelectedItems", BindingMode.TwoWay);

            this.AddBinding("DeleteButton", BindableProperties.TextProperty, "DeleteText");
            this.AddBinding("DeleteButton", BindableProperties.CommandProperty, "DeleteCommand");
            this.AddBinding("DeleteButton", BindableProperties.CommandParameterProperty, "SelectedItems");

            this.AddBinding("BatchUpdateButton", BindableProperties.CommandProperty, "BatchUpdateCommand");

            this.AddBinding("SingleDeleteButton", BindableProperties.CommandProperty, "SingleDeleteCommand");
            this.AddBinding("SingleDeleteButton", BindableProperties.CommandParameterProperty, "SelectedItem");
        }
    }
}

