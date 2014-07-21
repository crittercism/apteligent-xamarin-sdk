using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Single Selection", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SingleSelectionBindingProvider))]
    public class ListSingleSelectionActivity : ListActivity<CategorySelectionViewModel>
    {
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
            get { return ChoiceInputMode.Single; }
        }

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }


    }
}