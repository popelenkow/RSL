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

namespace RSL.Graphics.Generation.Robotics.PhysicalCharacteristics
{
    /// <summary>
    /// Логика взаимодействия для CurrentPosition2Control.xaml
    /// </summary>
    public partial class CurrentPosition2Control : UserControl
    {
        public CurrentPosition2Control()
        {
            InitializeComponent();
        }
        public List<Vector2> Generate(int count)
        {
            return SequencePoints.Generate().Create(count);
        }
    }
}
