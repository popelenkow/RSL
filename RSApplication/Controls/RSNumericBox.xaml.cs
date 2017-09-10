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
using System.Text.RegularExpressions;

namespace RSL.Controls
{
    /// <summary>
    /// Логика взаимодействия для RSNumericBox.xaml
    /// </summary>
    public partial class RSNumericBox : UserControl
    {
        public bool IsSigned
        {
            get { return (bool)GetValue(IsSignedProperty); }
            set { SetValue(IsSignedProperty, value); }
        }
        public bool IsPointed
        {
            get { return (bool)GetValue(IsPointedProperty); }
            set { SetValue(IsPointedProperty, value); }
        }
        public static readonly DependencyProperty IsSignedProperty =
            DependencyProperty.Register("IsSigned", typeof(bool), typeof(RSNumericBox));
        public static readonly DependencyProperty IsPointedProperty =
            DependencyProperty.Register("IsPointed", typeof(bool), typeof(RSNumericBox));

        public RSNumericBox()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            bool isBad;

            string text = e.Text;
            Regex regex;
            {
                string sign = "-";
                string point = ".";
                string re = string.Format("[^0-9{0}{1}]+", sign, point);
                regex = new Regex(re);
            }

            isBad = regex.IsMatch(text);

            e.Handled = isBad;
        }
    }
}
