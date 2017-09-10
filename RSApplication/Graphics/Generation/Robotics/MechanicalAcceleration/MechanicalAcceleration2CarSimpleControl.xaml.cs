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
using RSL.Robotics.MechanicalAcceleration;

namespace RSL.Graphics.Generation.Robotics.MechanicalAcceleration
{
    /// <summary>
    /// Логика взаимодействия для MA2CarSimpleControl.xaml
    /// </summary>
    public partial class MechanicalAcceleration2CarSimpleControl : UserControl, IMechanicalAcceleration2Control
    {
        public double Angle
        {
            get { return double.Parse(AngleControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { AngleControl.TextBox.Text = value.ToString(); }
        }
        public double Speed
        {
            get { return double.Parse(SpeedControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { SpeedControl.TextBox.Text = value.ToString(); }
        }
        public double MaxSpeed
        {
            get { return double.Parse(MaxSpeedControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { MaxSpeedControl.TextBox.Text = value.ToString(); }
        }
        public MechanicalAcceleration2CarSimpleControl()
        {
            InitializeComponent();
        }

        public IMechanicalAcceleration2 Generate()
        {
            return new MechanicalAcceleration2CarSimple()
            {
                MaxAngularVelocity = Angle,
                MaxSpeedVelocity = Speed,
                MaxSpeed = MaxSpeed
            };
        }
    }
}