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
            _workViewModel = new WorkViewModel();
        }


        private BindableBase _workViewModel;

        public BindableBase WorkViewModel
        {
            get { return _workViewModel; }
            set { SetProperty(ref _workViewModel, value); }
        }
    }
}
