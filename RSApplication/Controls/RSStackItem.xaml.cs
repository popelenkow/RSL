using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSL.Controls
{
    /// <summary>
    /// Логика взаимодействия для RSStackItem.xaml
    /// </summary>
    public partial class RSStackItem : UserControl
    {

        public object ContentValue
        {
            get { return ContentValueControl.Content; }
            set { ContentValueControl.Content = value; }
        }
        public RSStackItem()
        {
            InitializeComponent();

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            var parent = Parent;
            var s = parent as StackPanel;
            var children = s.Children;
            children.Remove(this);
        }
    }
}
