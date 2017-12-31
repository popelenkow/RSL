using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RSL.UI.Views
{
    public class WorkView : UserControl
    {
        public WorkView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
