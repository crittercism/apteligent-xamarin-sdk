using DataSamples.ViewModels;
using DataSamples.WinRT.Common;
using Intersoft.Crosslight;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace DataSamples.WinRT.Views.Interaction_Mode
{
    /// <summary>
    /// A page that displays details for a single item within a group while allowing gestures to
    /// flip through other items belonging to the same group.
    /// </summary>
    [ViewModelType(typeof(ItemDetailViewModel))]
    public sealed partial class ItemDetailPage : LayoutAwarePage
    {
        public ItemDetailPage()
        {
            this.InitializeComponent();
        }

        public new ItemDetailViewModel ViewModel
        {
            get
            {
                return base.ViewModel as ItemDetailViewModel;
            }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // Allow saved page state to override the initial item to display
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            // Save the selected item so we can restore it during application restart
            // The state saving and restoration is now performed automatically, see ItemDetailViewModel.cs
        }
    }
}
