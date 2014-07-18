using Intersoft.Crosslight;
using DataSamples.ViewModels;
using DataSamples.WinRT.Common;
using System.Linq;
using Windows.UI.ViewManagement;

namespace DataSamples.WinRT
{
    /// <summary>
    /// The main navigation page with the list view in the left panel and the detail frame in the right panel.
    /// </summary>
    [ViewModelType(typeof(NavigationViewModel))]
    public sealed partial class MainPage : SplitPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public new NavigationViewModel ViewModel
        {
            get
            {
                return base.ViewModel as NavigationViewModel;
            }
        }

        protected override void InitializeViewModel()
        {
            base.InitializeViewModel();

            // set initial selection for split page
            this.ViewModel.SelectedItem = this.ViewModel.Items.ElementAtOrDefault(0);
        }

        public override void InvalidateLayoutVisualState()
        {
            base.InvalidateLayoutVisualState();

            if (ApplicationView.Value != ApplicationViewState.Snapped)
            {
                if (this.ViewModel.SelectedItem == null)
                    this.itemDetail.Content = null;
            }
        }
    }
}
