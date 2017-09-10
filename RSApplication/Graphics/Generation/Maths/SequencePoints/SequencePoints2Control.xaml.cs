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
using RSL.Graphics.Generation.Maths.SequencePoints.Set;
using RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle;
using RSL.Maths.SequencePoints;

namespace RSL.Graphics.Generation.Maths.SequencePoints
{
    /// <summary>
    /// Логика взаимодействия для SequencePoints2Control.xaml
    /// </summary>
    public partial class SequencePoints2Control : UserControl
    {
        public SequencePoints2Control()
        {
            InitializeComponent();
            
        }

        public ISequencePoints2 Generate()
        {
            var set = SetPoints2Box.Generate();
            var shuffle = ReshuffleStack.Generate();
            var sh = shuffle.First();
            return new SequencePoints2(set, shuffle);
        }
    }
}
