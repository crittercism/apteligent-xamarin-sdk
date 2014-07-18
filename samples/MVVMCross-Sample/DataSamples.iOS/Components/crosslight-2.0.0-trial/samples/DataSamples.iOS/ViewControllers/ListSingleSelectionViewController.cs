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

namespace DataSamples.iOS.ViewControllers
{
    [Register("ListSingleSelectionViewController")]
    [ImportBinding(typeof(SingleSelectionBindingProvider))]
    public class ListSingleSelectionViewController : UITableViewController<CategorySelectionViewModel>
    {
        public override TableViewInteraction InteractionMode
        {
            get
            {
                return TableViewInteraction.ChoiceInput;
            }
        }

        public override ChoiceInputMode ChoiceInputMode
        {
            get
            {
                return ChoiceInputMode.Single;
            }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            UIBarButtonItem button = new UIBarButtonItem();
            button.Title = "Get Selection";

            this.NavigationItem.SetRightBarButtonItem(button, false);
            this.RegisterViewIdentifier("GetSelectionButton", button);
        }
    }
}
