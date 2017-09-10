using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using RSL.ViewModels;

namespace RSL.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            this.InitializeComponent();
            this.AttachDevTools();
        }


    }
}
