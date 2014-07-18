using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using DataSamples.Infrastructure;
using DataSamples.ModelServices;
using DataSamples.Models;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Input;
using Intersoft.Crosslight.ViewModels;

namespace DataSamples.ViewModels
{
    public class EditableListViewModel : EditableListViewModelBase<Item>
    {
        #region Properties

        public DelegateCommand BatchUpdateCommand { get; set; }

        public string DeleteText
        {
            get
            {
                if (this.SelectedItems == null || !this.SelectedItems.Any())
                    return "Delete";
                return "Delete (" + this.SelectedItems.Count() + ")";
            }
        }

        private int NewIndex { get; set; }

        private IItemRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<IItemRepository>())
                    return Container.Current.Resolve<IItemRepository>();
                return new ItemRepository(); // for designer support
            }
        }

        public DelegateCommand SingleDeleteCommand { get; set; }

        public string TotalItemsText
        {
            get
            {
                if (!this.Items.Any())
                    return "No items.";
                if (this.Items.Count() == 1)
                    return "1 item";
                return this.Items.Count() + " items";
            }
        }

        #endregion

        #region Constructors

        public EditableListViewModel()
        {
            // source items, should be plain items, not sorted or filtered
            this.SourceItems = this.Repository.GetAll().ToObservable();

            this.BatchUpdateCommand = new DelegateCommand(ExecuteBatchUpdate);
            this.SingleDeleteCommand = new DelegateCommand(ExecuteSingleDelete, CanExecuteSingleDelete);
        }

        #endregion

        #region Methods

        protected override bool CanExecuteDelete(object parameter)
        {
            if (parameter is Item)
                return true;
            IEnumerable<Item> items = parameter as IEnumerable<Item>;
            if (items != null)
                return items.Any();

            return false;
        }

        protected override bool CanExecuteReorder(object parameter)
        {
            ReorderParameter reorderParameter = parameter as ReorderParameter;

            if (reorderParameter != null)
            {
                if (reorderParameter.Action == ReorderAction.QueryState)
                {
                    if (reorderParameter.RowIndex < 3)
                        return false;
                }
                else if (reorderParameter.Action == ReorderAction.CustomizeTarget)
                {
                    if (reorderParameter.ProposedRowIndex < 3)
                        reorderParameter.ProposedRowIndex = 3;
                }
            }

            return true;
        }

        private bool CanExecuteSingleDelete(object parameter)
        {
            if (parameter is Item && this.SelectedItem != null)
                return true;
            return false;
        }

        private void ExecuteBatchUpdate(object parameter)
        {
            // Begin updating
            this.IsBatchUpdating = true;

            // Perform multiple add and remove simultaneously
            var items = this.Items.ToObservable();
            var updatedItem = items.ElementAt(0);

            updatedItem.Name = "Modified at " + DateTime.Now.ToString("hh:mm:ss");
            this.OnDataChanged(updatedItem);

            items.Insert(1, new Item {Name = "New Item " + this.NewIndex++, Location = "New warehouse", ThumbnailImage = updatedItem.ThumbnailImage});
            items.Insert(3, new Item {Name = "New Item " + this.NewIndex++, Location = "New warehouse", ThumbnailImage = updatedItem.ThumbnailImage});
            items.Insert(6, new Item {Name = "New Item " + this.NewIndex++, Location = "New warehouse", ThumbnailImage = updatedItem.ThumbnailImage});

            items.Remove(items.ElementAt(5));
            items.Remove(items.ElementAt(7));

            this.ToastPresenter.Show("Added 3 items, removed 2 items, updated 1 item", null, null, ToastDisplayDuration.Immediate, ToastGravity.Center);

            // End updating
            this.IsBatchUpdating = false;
        }

        protected override void ExecuteDelete(object parameter)
        {
            Item item = parameter as Item;
            if (item != null)
                this.Repository.Delete(item);
            else
            {
                IEnumerable<Item> items = parameter as IEnumerable<Item>;
                if (items != null)
                    this.Repository.Delete(items);
            }

            this.SelectedItem = null;

            if (this.SelectedItems != null)
                this.SelectedItems.Clear();
        }

        protected override void ExecuteReorder(object parameter)
        {
            ReorderParameter reorderParameter = parameter as ReorderParameter;

            if (reorderParameter != null && reorderParameter.Action == ReorderAction.ProcessReorder)
            {
                var items = this.Items.ToObservable();
                Item reorderItem = reorderParameter.Item as Item;

                if (reorderItem != null)
                {
                    items.Remove(reorderItem);
                    items.Insert(reorderParameter.ProposedRowIndex, reorderItem);
                }
            }
        }

        private void ExecuteSingleDelete(object obj)
        {
            if (this.SelectedItem != null)
                this.Repository.Delete(this.SelectedItem);
        }

        protected override void OnSelectedItemChanged(Item newItem)
        {
            base.OnSelectedItemChanged(newItem);
            this.SingleDeleteCommand.RaiseCanExecuteChanged();
        }

        protected override void OnSelectedItemsCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            this.OnPropertyChanged("DeleteText");
            this.DeleteCommand.RaiseCanExecuteChanged();
        }

        protected override void OnSourceItemsChanged(ICollection<Item> items)
        {
            this.Items = items != null ? items.OrderBy(o => o.Name) : null;
        }

        #endregion
    }
}