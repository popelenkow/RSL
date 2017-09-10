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
using RSL.Maths.SequencePoints.Set;
using RSL.Maths.Algebra;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Set
{
    /// <summary>
    /// Логика взаимодействия для SP2LineControl.xaml
    /// </summary>
    public partial class SetPoints2LineControl : UserControl, ISetPoints2Control
    {
        public Vector2 Point1
        {
            get
            {
                Vector2 p = new Vector2()
                {
                    X = double.Parse(Point1XControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture),
                    Y = double.Parse(Point1YControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture)
                };
                return p;
            }
            set
            {
                Point1XControl.TextBox.Text = value.X.ToString();
                Point1YControl.TextBox.Text = value.Y.ToString();
            }
        }
        public Vector2 Point2
        {
            get
            {
                Vector2 p = new Vector2()
                {
                    X = double.Parse(Point2XControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture),
                    Y = double.Parse(Point2YControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture)
                };
                return p;
            }
            set
            {
                Point2XControl.TextBox.Text = value.X.ToString();
                Point2YControl.TextBox.Text = value.Y.ToString();
            }
        }
        public SetPoints2LineControl()
        {
            InitializeComponent();
        }

        public ISetPoints2 Generate()
        {
            return new SetPoints2Line(Point1, Point2);
        }
    }
}
