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
    /// Логика взаимодействия для FunctionalVector2LinearNormControl.xaml
    /// </summary>
    public partial class FunctionalVector2LinearNormControl : UserControl, IFunctionalVector2Control
    {
        public double Dimension
        {
            get { return double.Parse(DimensionControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture); }
            set { DimensionControl.TextBox.Text = value.ToString(); }
        }
        public FunctionalVector2LinearNormControl()
        {
            InitializeComponent();
        }
        public IFunctionalVector2 Generate()
        {
            return new FunctionalVector2LinearNorm(Dimension);
        }
    }
}
