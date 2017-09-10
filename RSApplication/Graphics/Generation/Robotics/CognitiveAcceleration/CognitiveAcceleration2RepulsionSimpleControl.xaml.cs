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
using RSL.Robotics.CognitiveAcceleration;

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration
{
    /// <summary>
    /// Логика взаимодействия для CognitiveAcceleration2RepulsionSimpleControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2RepulsionSimpleControl : UserControl, ICognitiveAcceleration2Control
    {
        public double SamplingAngle
        {
            get { return double.Parse(SamplingAngleControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { SamplingAngleControl.TextBox.Text = value.ToString(); }
        }
        public double Range
        {
            get { return double.Parse(RangeControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { RangeControl.TextBox.Text = value.ToString(); }
        }
        public double Force
        {
            get { return double.Parse(ForceControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { ForceControl.TextBox.Text = value.ToString(); }
        }
        public double DisableGoalRange
        {
            get { return double.Parse(DisableGoalRangeControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { DisableGoalRangeControl.TextBox.Text = value.ToString(); }
        }

        public CognitiveAcceleration2RepulsionSimpleControl()
        {
            InitializeComponent();
        }

        public ICognitiveAcceleration2 Generate()
        {
            return new CognitiveAcceleration2RepulsionSimple
            {
                Range = Range,
                SamplingAngle = SamplingAngle,
                Force = Force,
                DisableGoalRange = DisableGoalRange
            };
        }
    }
}
