using System.Linq;
using Intersoft.Crosslight.Input;

namespace DataSamples.ViewModels
{
    public class CategorySelectionViewModel : CategoryListViewModel
    {
        public CategorySelectionViewModel()
            : base()
        {
            this.SelectedItem = this.Items.FirstOrDefault();
            this.GetSelectionCommand = new DelegateCommand(ExecuteGetSelection);
        }

        public DelegateCommand GetSelectionCommand { get; set; }

        private void ExecuteGetSelection(object parameter)
        {
            this.ToastPresenter.Show("Selected category: " + this.SelectedItem.Name);
        }
    }
}

