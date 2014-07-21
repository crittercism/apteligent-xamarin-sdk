using System.Linq;
using Intersoft.Crosslight.Input;

namespace DataSamples.ViewModels
{
    public class CategoryMultipleSelectionViewModel : CategoryListViewModel
    {
        public CategoryMultipleSelectionViewModel()
        {
            this.SelectedItems.Add(this.Items.ElementAt(1));
            this.SelectedItems.Add(this.Items.ElementAt(4));
            this.GetSelectionCommand = new DelegateCommand(ExecuteGetSelection);
        }

        public DelegateCommand GetSelectionCommand { get; set; }

        private void ExecuteGetSelection(object parameter)
        {
            int count = this.SelectedItems.Count;
            if (count == 0)
                this.ToastPresenter.Show("No category selected");
            else if (count == 1)
                this.ToastPresenter.Show("1 category selected");
            else
                this.ToastPresenter.Show(this.SelectedItems.Count + " categories selected");
        }
    }
}

