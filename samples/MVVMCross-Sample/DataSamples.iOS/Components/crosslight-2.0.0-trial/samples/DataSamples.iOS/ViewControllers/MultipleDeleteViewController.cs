using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DataSamples.ViewModels;
using System.ComponentModel;

namespace DataSamples.iOS.ViewControllers
{
    [Register("MultipleDeleteViewController")]
    [RegisterNavigation("MultipleDelete")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    public class MultipleDeleteViewController : UITableViewController<EditableListViewModel>
    {
        public override TableViewCellStyle CellStyle
        {
            get
            {
                return TableViewCellStyle.Subtitle;
            }
        }

        public override ImageSettings CellImageSettings 
        {
            get 
            {
                return DefaultSettings.ImageSettings;
            }
        }

        public override EditingOptions EditingOptions
        {
            get
            {
                return EditingOptions.AllowEditing | EditingOptions.AllowMultipleSelection;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            // Configure ToolBar
            UIBarButtonItem deleteButton = new UIBarButtonItem();
            deleteButton.Style = UIBarButtonItemStyle.Bordered;
            deleteButton.TintColor = UIColor.Red;

            this.SetToolbarItems(new UIBarButtonItem[] { deleteButton }, false);
            this.RegisterViewIdentifier("DeleteButton", deleteButton);
        }

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsEditing")
                this.NavigationController.SetToolbarHidden(!this.ViewModel.IsEditing, true);
        }
    }
}
