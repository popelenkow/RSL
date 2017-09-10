using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Views
{
    partial class MainView
    {
        private StudentView _studentViewControl;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            _studentViewControl = this.FindControl<StudentView>("studentViewControl");
        }
    }
}
