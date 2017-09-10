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
    /// Логика взаимодействия для RSStackControl.xaml
    /// </summary>
    public partial class RSStackControl : UserControl
    {
        
        private Type _typeNewItem = typeof(object);
        public Type TypeNewItem
        {
            get { return _typeNewItem; }
            set { _typeNewItem = value; }
        }
        public UIElement Header
        {
            get { return HeaderControl.Child; }
            set { HeaderControl.Child = value; }
        }
        
        public RSStackControl()
        {
            InitializeComponent();
        }

        public void AddNewItem()
        {
            var item =  Activator.CreateInstance(TypeNewItem);
            var myItem = new RSStackItem
            {
                ContentValue = item
            };
            ItemsStackControl.Children.Add(myItem);
        }

        private void AddNewItemButton(object sender, RoutedEventArgs e)
        {
            AddNewItem();
        }
    }
}
