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
    /// Логика взаимодействия для CognitiveAcceleration2PurposeSillyControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2PurposeSillyControl : UserControl, ICognitiveAcceleration2Control
    {
        public double Time
        {
            get { return double.Parse(TimeControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { TimeControl.TextBox.Text = value.ToString(); }
        }
        public double MaxVisibleRange
        {
            get { return double.Parse(MaxVisibleRangeControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { MaxVisibleRangeControl.TextBox.Text = value.ToString(); }
        }

        public CognitiveAcceleration2PurposeSillyControl()
        {
            InitializeComponent();
        }

        public ICognitiveAcceleration2 Generate()
        {
            return new CA2PurposeSilly
            {
                ParameterTime = Time,
                 MaxVisibleRange = MaxVisibleRange
            };
        }
    }
}
