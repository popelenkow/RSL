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
using RSL.Robotics.CognitiveAcceleration.MaximizationFunction;


namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration.MaximizationFunction
{
    /// <summary>
    /// Логика взаимодействия для MaximizationFunction2SameControl.xaml
    /// </summary>
    public partial class MaximizationFunction2SameControl : UserControl, IMaximizationFunction2Control
    {
        public MaximizationFunction2SameControl()
        {
            InitializeComponent();
        }

        public IMaximizationFunction2 Generate()
        {
            return new MaximizationFunction2Same();
        }
    }
}
