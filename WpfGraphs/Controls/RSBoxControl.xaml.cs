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
    /// Логика взаимодействия для RSBoxControl.xaml
    /// </summary>
    public partial class RSBoxControl : UserControl
    {
        public UIElement Header
        {
            get { return HeaderControl.Child; }
            set { HeaderControl.Child = value; }
        }
        public UIElement ContentValue
        {
            get { return ContentValueControl.Child; }
            set { ContentValueControl.Child = value; }
        }
        public RSBoxControl()
        {
            InitializeComponent();
        }
    }
}
