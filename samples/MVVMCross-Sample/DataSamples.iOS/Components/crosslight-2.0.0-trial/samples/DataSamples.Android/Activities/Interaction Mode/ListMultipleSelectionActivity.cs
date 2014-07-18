using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Multiple Selection", Icon = "@drawable/icon")]
    [ImportBinding(typeof(MultipleSelectionBindingProvider))]
    public class ListMultipleSelectionActivity : ListActivity<CategoryMultipleSelectionViewModel>
    {
        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.CheckableListView; }
        }

        protected override int MenuLayoutId
        {
            get { return Resource.Layout.ListSingleSelectionActionBar; }
        }

        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.ChoiceInput;
            }
        }

        public override ChoiceInputMode ChoiceInputMode
        {
            get { return ChoiceInputMode.Multiple; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

    }
}