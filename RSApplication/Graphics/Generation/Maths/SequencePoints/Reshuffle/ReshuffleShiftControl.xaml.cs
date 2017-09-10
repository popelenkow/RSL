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
using RSL.Maths.Algebra;
using RSL.Maths.SequencePoints.Reshuffle;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle
{
    /// <summary>
    /// Логика взаимодействия для ReshuffleShiftControl.xaml
    /// </summary>
    public partial class ReshuffleShiftControl : UserControl, IReshuffleControl
    {
        public int Position
        {
            get { return int.Parse(PositionControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { PositionControl.TextBox.Text = value.ToString(); }
        }
        public ReshuffleShiftControl()
        {
            InitializeComponent();
        }

        public IReshuffle<Vector2> Generate()
        {
            return new ReshuffleShift<Vector2>(Position);
        }
    }
}
