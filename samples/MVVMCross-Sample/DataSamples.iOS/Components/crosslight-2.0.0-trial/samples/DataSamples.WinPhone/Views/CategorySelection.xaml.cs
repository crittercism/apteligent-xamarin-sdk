using System.Linq;
using System.Windows.Controls;
using DataSamples.Models;
using DataSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.WinPhone;

namespace DataSamples.WinPhone.Views
{
    [ViewModelType(typeof(CategorySelectionViewModel))]
    public partial class CategorySelection : PhoneApplicationPage
    {
        public CategorySelection()
        {
            InitializeComponent();
        }
    }
}