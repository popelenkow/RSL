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

namespace RSL.Graphics.Generation.Robotics.LogicalCharacteristics
{
    /// <summary>
    /// Логика взаимодействия для GoalPosition2Control.xaml
    /// </summary>
    public partial class GoalPosition2Control : UserControl
    {
        public GoalPosition2Control()
        {
            InitializeComponent();
        }
        public List<Vector2> Generate(int count)
        {
            return SequencePoints.Generate().Create(count);
        }
    }
}
