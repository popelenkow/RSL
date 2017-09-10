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
using RSL.Maths.FunctionalVector;

namespace RSL.Graphics.Generation.Maths.FunctionalVector
{
    /// <summary>
    /// Логика взаимодействия для FunctionalVector2ArithmeticMeanControl.xaml
    /// </summary>
    public partial class FunctionalVector2ArithmeticMeanControl : UserControl, IFunctionalVector2Control
    {
        public FunctionalVector2ArithmeticMeanControl()
        {
            InitializeComponent();
        }

        public IFunctionalVector2 Generate()
        {
            return new FunctionalVector2ArithmeticMean();
        }
    }
}
