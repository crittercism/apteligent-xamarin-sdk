using Android.App;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DataSamples.Android
{
    [Activity(Label = "Multiple Delete", Icon = "@drawable/icon")]
    [ImportBinding(typeof(EditableListBindingProvider))]
    [RegisterNavigation("MultipleDelete")]
    public class MultipleDeleteActivity : ListActivity<EditableListViewModel>
    {
        protected override ContextualActionBarSettings ContextualActionBarSettings
        {
            get
            {
                return new ContextualActionBarSettings
                {
                    ActionBarLayoutId = Resource.Layout.ListDeleteActionBar
                };
            }
        }

        protected override int ListItemLayoutId
        {
            get { return Resource.Layout.tablecellsubtitlewithimage; }
        }

        public override EditingOptions EditingOptions
        {
            get { return EditingOptions.AllowEditing | EditingOptions.AllowMultipleSelection; }
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