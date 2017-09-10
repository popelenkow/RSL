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
    /// Логика взаимодействия для ReshuffleInversionControl.xaml
    /// </summary>
    public partial class ReshuffleInversionControl : UserControl, IReshuffleControl
    {
        public ReshuffleInversionControl()
        {
            InitializeComponent();
        }

        public IReshuffle<Vector2> Generate()
        {
            return new ReshuffleInversion<Vector2>();
        }
    }
}
