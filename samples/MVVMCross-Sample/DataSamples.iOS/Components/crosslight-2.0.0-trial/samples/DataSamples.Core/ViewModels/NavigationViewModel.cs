using System.Collections.Generic;
using System.Linq;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace DataSamples.ViewModels
{
    public class NavigationViewModel : ListViewModelBase<NavigationItem>
    {
        public NavigationViewModel()
        {
            IApplicationContext context = this.GetService<IApplicationService>().GetContext();

            List<NavigationItem> items = new List<NavigationItem>();

            items.Add(new NavigationItem("Simple List", "Data View", typeof(SimpleListViewModel)));
            items.Add(new NavigationItem("Grouped List", "Data View", typeof(GroupListViewModel)));
            items.Add(new NavigationItem("Grouped List (Section)", "Data View", new NavigationTarget(typeof(GroupListViewModel), "GroupStyle")));
            items.Add(new NavigationItem("Grouped List with Index", "Data View", new NavigationTarget(typeof(GroupListViewModel), "GroupIndex")));
            items.Add(new NavigationItem("Searchable List", "Data View", typeof(FilterListViewModel)));
            if (context.Platform.OperatingSystem != OSKind.Android && context.Platform.OperatingSystem != OSKind.WinPhone &&
                context.Platform.OperatingSystem != OSKind.WinRT)
                items.Add(new NavigationItem("Searchable List with Scope", "Data View", new NavigationTarget(typeof(FilterListViewModel), "FilterScope")));

            items.Add(new NavigationItem("Default", "Cell Styles", typeof(SimpleListViewModel)));
            items.Add(new NavigationItem("Right Detail", "Cell Styles", new NavigationTarget(typeof(CategoryListViewModel), "RightDetailCellStyle")));
            items.Add(new NavigationItem("Left Detail", "Cell Styles", new NavigationTarget(typeof(CategoryListViewModel), "LeftDetailCellStyle")));
            items.Add(new NavigationItem("Subtitle", "Cell Styles", new NavigationTarget(typeof(SimpleListViewModel), "SubtitleCellStyle")));
            items.Add(new NavigationItem("Subtitle with Image", "Cell Styles", new NavigationTarget(typeof(SimpleListViewModel), "SubtitleImageCellStyle")));
            items.Add(new NavigationItem("Custom Template", "Cell Styles", new NavigationTarget(typeof(SimpleListViewModel), "CustomCellStyle")));

            items.Add(new NavigationItem("Default", "Interaction Mode", typeof(SimpleListViewModel)));
            items.Add(new NavigationItem("Navigation", "Interaction Mode", new NavigationTarget(typeof(SimpleListViewModel), "ListNavigation")));
            items.Add(new NavigationItem("Single Selection", "Interaction Mode", typeof(CategorySelectionViewModel)));
            items.Add(new NavigationItem("Multiple Selection", "Interaction Mode", typeof(CategoryMultipleSelectionViewModel)));

            items.Add(new NavigationItem("Single Delete", "Editing", new NavigationTarget(typeof(EditableListViewModel), "SingleDelete")));
            items.Add(new NavigationItem("Multiple Delete", "Editing", new NavigationTarget(typeof(EditableListViewModel), "MultipleDelete")));

            if (context.Platform.OperatingSystem != OSKind.Android && context.Platform.OperatingSystem != OSKind.WinRT)
                items.Add(new NavigationItem("Allow Reorder", "Editing", new NavigationTarget(typeof(EditableListViewModel), "ReorderList")));

            items.Add(new NavigationItem("Batch Update", "Editing", new NavigationTarget(typeof(EditableListViewModel), "BatchUpdate")));

            items.Add(new NavigationItem("About This Sample", "About", typeof(AboutViewModel)));

            this.SourceItems = items;
            this.RefreshGroupItems();
        }

        public override void RefreshGroupItems()
        {
            if (this.Items != null)
                this.GroupItems = this.Items.GroupBy(o => o.Group).Select(o => new GroupItem<NavigationItem>(o)).ToList();
        }
    }
}
