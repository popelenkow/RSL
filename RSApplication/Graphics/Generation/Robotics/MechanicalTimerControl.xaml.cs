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

namespace RSL.Graphics.Generation.Robotics
{
    /// <summary>
    /// Логика взаимодействия для MechanicalTimerControl.xaml
    /// </summary>
    public partial class MechanicalTimerControl : UserControl
    {
        public double Sampling
        {
            get { return double.Parse(SamplingControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { SamplingControl.TextBox.Text = value.ToString(); }
        }
        public MechanicalTimerControl()
        {
            InitializeComponent();
            //todo
            Sampling = 0.01;
        }
        public ITimer Generate(IWorldTime time)
        {
            return new TimerSimulation(time, Sampling);
        }
    }
}
