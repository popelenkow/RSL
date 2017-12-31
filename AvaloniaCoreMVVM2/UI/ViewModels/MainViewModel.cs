using System;
using System.Collections.Generic;
using System.Text;
using RSL.UI.MVVM;

namespace RSL.UI.ViewModels
{
    class MainViewModel : BindableBase
    {

        public MainViewModel()
        {
            NavCommand = new MyCommand<string>(OnNav);
        }

        private CustomerListViewModel _custListViewModel = new CustomerListViewModel();

        private OrderViewModel _orderViewModelModel = new OrderViewModel();

        private BindableBase _currentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }

        public MyCommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "orders":
                    CurrentViewModel = _orderViewModelModel;
                    break;
                case "customers":
                default:
                    CurrentViewModel = _custListViewModel;
                    break;
            }
        }
    }
}
