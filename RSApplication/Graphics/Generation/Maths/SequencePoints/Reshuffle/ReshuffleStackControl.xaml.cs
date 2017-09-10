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
using RSL.Maths.SequencePoints.Reshuffle;
using RSL.Maths.Algebra;
using RSL.Controls;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle
{
    /// <summary>
    /// Логика взаимодействия для ReshuffleStackControl.xaml
    /// </summary>
    public partial class ReshuffleStackControl : UserControl
    {
        public ReshuffleStackControl()
        {
            InitializeComponent();
            Stack.TypeNewItem = typeof(ReshuffleReflectionControl);
            Stack.AddNewItem();
        }
        public IEnumerable<IReshuffle<Vector2>> Generate()
        {
            var res = new List<IReshuffle<Vector2>>();
            foreach (var r in Stack.ItemsStackControl.Children)
            {
                var rr = (r as RSStackItem).ContentValue;
                var refl = rr as ReshuffleReflectionControl;
                res.Add(refl.Generate());
            }
            return res;
        }
    }
}
