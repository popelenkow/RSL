using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RSL.UI.Views
{
    public class OrderView : UserControl
    {
        public OrderView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
