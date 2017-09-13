using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCoreMVVM2.Views
{
    public class CustomerListView : UserControl
    {
        public CustomerListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
