using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaCoreMVVM2.ViewModels
{
    class MainViewModel : BindableBase
    {

        public MainViewModel()
        {
            NavCommand = new MyCommand<string>(OnNav);
        }

        private CustomerListViewModel custListViewModel = new CustomerListViewModel();

        private OrderViewModel orderViewModelModel = new OrderViewModel();

        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyCommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "orders":
                    CurrentViewModel = orderViewModelModel;
                    break;
                case "customers":
                default:
                    CurrentViewModel = custListViewModel;
                    break;
            }
        }
    }
}
