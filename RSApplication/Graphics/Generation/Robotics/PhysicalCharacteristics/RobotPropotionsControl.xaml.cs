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

namespace RSL.Graphics.Generation.Robotics.PhysicalCharacteristics
{
    /// <summary>
    /// Логика взаимодействия для RobotPropotionsControl.xaml
    /// </summary>
    public partial class RobotPropotionsControl : UserControl
    {
        public double Radius
        {
            get { return double.Parse(RadiusControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { RadiusControl.TextBox.Text = value.ToString(); }
        }
        public RobotPropotionsControl()
        {
            InitializeComponent();
        }
        public double Generate()
        {
            return Radius;
        }
    }
}
