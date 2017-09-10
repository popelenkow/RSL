using MugenMvvmToolkit.Interfaces.Models;
using MugenMvvmToolkit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.ViewModels
{
    class WorkViewModel : ViewModelBase, IHasDisplayName
    {

        public WorkViewModel()
        {
            DisplayName = "Work";
        }

        #region Properties

        public string Name { get; set; }

        public string DisplayName { get; }

        #endregion
    }
}
