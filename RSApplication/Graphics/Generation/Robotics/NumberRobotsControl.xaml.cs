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
using RSL.Graphics.Generation.Maths.SequencePoints;

namespace RSL.Graphics.Generation.Robotics
{
    /// <summary>
    /// Логика взаимодействия для NumerRobotsControl.xaml
    /// </summary>
    public partial class NumberRobotsControl : UserControl
    {
        public int Number
        {
            get { return Convert.ToInt32(NumberControl.TextBox.Text); }
            set { NumberControl.TextBox.Text = value.ToString(); }
        }
        public NumberRobotsControl()
        {
            InitializeComponent();
            //todo
            Number = 10;
        }
        public int Generate()
        {
            return Number;
        }
    }
}
