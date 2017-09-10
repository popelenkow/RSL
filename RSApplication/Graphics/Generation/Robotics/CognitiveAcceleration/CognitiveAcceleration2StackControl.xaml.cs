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
using RSL.Graphics.Generation.Maths.FunctionalVector;
using RSL.Controls;

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration
{
    /// <summary>
    /// Логика взаимодействия для CognitiveAcceleration2StackControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2StackControl : UserControl
    {
        public CognitiveAcceleration2StackControl()
        {
            InitializeComponent();
            Stack.TypeNewItem = typeof(CognitiveAcceleration2ReflectionControl);
            Stack.AddNewItem();
        }
        public List<ICognitiveAcceleration2> Generate()
        {
            List<ICognitiveAcceleration2> arr = new List<ICognitiveAcceleration2>();
            foreach (var r in Stack.ItemsStackControl.Children)
            {
                var rr = (r as RSStackItem).ContentValue;
                var refl = rr as CognitiveAcceleration2ReflectionControl;
                arr.Add(refl.Generate());
            }
            return arr;
        }
    }
}
