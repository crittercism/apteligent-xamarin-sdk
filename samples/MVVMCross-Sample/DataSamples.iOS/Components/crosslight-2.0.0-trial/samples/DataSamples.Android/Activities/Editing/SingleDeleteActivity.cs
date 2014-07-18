using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Single Delete", Icon = "@drawable/icon")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    [RegisterNavigation("SingleDelete")]
    public class SingleDeleteActivity : ListActivity<EditableListViewModel>
    {
        protected override ContextualActionBarSettings ContextualActionBarSettings
        {
            get
            {
                return new ContextualActionBarSettings
                {
                    ActionBarLayoutId = Resource.Layout.ListSingleDeleteActionBar
                };
            }
        }

        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.tablecellsubtitlewithimage; }
        }

        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.ChoiceInput;
            }
        }

        public override EditingOptions EditingOptions
        {
            get { return EditingOptions.AllowEditing; }
        }

        protected override int MenuLayoutId
        {
            get { return Resource.Layout.ListSingleDeleteActionBar; }
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

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.ViewModel.ToastPresenter.Show("Long press to enter selection mode", "Info", null, ToastDisplayDuration.Immediate, ToastGravity.Center);
        }
    }
}