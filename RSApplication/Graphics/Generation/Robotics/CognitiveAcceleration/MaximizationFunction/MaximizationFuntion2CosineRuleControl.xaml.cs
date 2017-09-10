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

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration.MaximizationFunction
{
    /// <summary>
    /// Логика взаимодействия для MaximizationFuntion2CosineRuleControl.xaml
    /// </summary>
    public partial class MaximizationFuntion2CosineRuleControl : UserControl, IMaximizationFunction2Control
    {
        public MaximizationFuntion2CosineRuleControl()
        {
            InitializeComponent();
        }

        public IMaximizationFunction2 Generate()
        {
            return new MaximizationFunction2CosineRule();
        }
    }
}
