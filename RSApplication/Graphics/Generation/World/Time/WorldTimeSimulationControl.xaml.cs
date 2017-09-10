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
using RSL.World.Time;

namespace RSL.Graphics.Generation.World.Time
{
    /// <summary>
    /// Логика взаимодействия для WorldTimeSimulationControl.xaml
    /// </summary>
    public partial class WorldTimeSimulationControl : UserControl, IWorldTimeControl
    {
        public double Speed
        {
            get { return double.Parse(SpeedControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { SpeedControl.TextBox.Text = value.ToString(); }
        }
        public WorldTimeSimulationControl()
        {
            InitializeComponent();
        }

        public IWorldTime Generate()
        {
            return new WorldTimeSimulation(Speed);
        }
    }
}
