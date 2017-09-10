using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RSL.ViewModels
{
    class MainViewModel : MultiViewModel<WorkViewModel>
    {

        #region Constructors

        public MainViewModel()
        {
            AddCommand = new RelayCommand(Add);
            InsertCommand = new RelayCommand(Insert, CanInsert, this);
            RemoveCommand = new RelayCommand(Remove, CanRemove, this);
        }

        #endregion

        #region Commands

        public ICommand AddCommand { get; }

        public ICommand InsertCommand { get; }

        public ICommand RemoveCommand { get; }

        private void Add(object o)
        {
            var itemViewModel = GetViewModel<WorkViewModel>();
            itemViewModel.Name = "Dynamic item";
            AddViewModel(itemViewModel);
            SelectedItem = itemViewModel;
        }

        private bool CanRemove(object o)
        {
            return SelectedItem != null;
        }

        private void Remove(object o)
        {
            RemoveViewModelAsync(SelectedItem);
        }

        private bool CanInsert(object obj)
        {
            return SelectedItem != null;
        }

        private void Insert(object o)
        {
            var itemViewModel = GetViewModel<WorkViewModel>();
            itemViewModel.Name = "Dynamic tab";
            var selectedIndex = ItemsSource.IndexOf(SelectedItem);
            ItemsSource.Insert(selectedIndex, itemViewModel);
            SelectedItem = itemViewModel;
        }

        #endregion
    }
}
