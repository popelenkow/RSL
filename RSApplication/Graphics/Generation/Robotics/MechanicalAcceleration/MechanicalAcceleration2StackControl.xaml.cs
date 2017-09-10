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
using RSL.Robotics.MechanicalAcceleration;
using RSL.Controls;

namespace RSL.Graphics.Generation.Robotics.MechanicalAcceleration
{
    /// <summary>
    /// Логика взаимодействия для MechanicalAcceleration2StackControl.xaml
    /// </summary>
    public partial class MechanicalAcceleration2StackControl : UserControl
    {
        public MechanicalAcceleration2StackControl()
        {
            InitializeComponent();
            Stack.TypeNewItem = typeof(MechanicalAcceleration2ReflectionControl);
            Stack.AddNewItem();
        }
        public List<IMechanicalAcceleration2> Generate()
        {
            List<IMechanicalAcceleration2> arr = new List<IMechanicalAcceleration2>();
            foreach (var r in Stack.ItemsStackControl.Children)
            {
                var rr = (r as RSStackItem).ContentValue;
                var refl = rr as MechanicalAcceleration2ReflectionControl;
                arr.Add(refl.Generate());
            }
            return arr;
        }
    }
}
