using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RSL.UI.Views
{
    public class MainView : Window
    {
        public MainView()
        {
            this.InitializeComponent();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
