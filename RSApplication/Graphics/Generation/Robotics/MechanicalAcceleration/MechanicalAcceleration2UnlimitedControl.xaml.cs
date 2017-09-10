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
    /// Логика взаимодействия для MA2UnlimitedControl.xaml
    /// </summary>
    public partial class MechanicalAcceleration2UnlimitedControl : UserControl, IMechanicalAcceleration2Control
    {
        public MechanicalAcceleration2UnlimitedControl()
        {
            InitializeComponent();
        }

        public IMechanicalAcceleration2 Generate()
        {
            return new MechanicalAcceleration2Unlimited();
        }
    }
}
