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
using RSL.Graphics.Generation.Maths.FunctionalVector;

namespace RSL.Graphics.Generation.Robotics.MechanicalAcceleration
{
    /// <summary>
    /// Логика взаимодействия для MechanicalAcceleration2ManagerControl.xaml
    /// </summary>
    public partial class MechanicalAcceleration2ManagerControl : UserControl
    {
        public MechanicalAcceleration2ManagerControl()
        {
            InitializeComponent();
        }
        public IMechanicalManager2 Generate()
        {
            List<IMechanicalAcceleration2> arr = MechanicalAcceleration2Stack.Generate();
            var v = (AdderVelocity.ContentValue as FunctionalVector2ReflectionControl).Generate();
            var c = (AdderCourse.ContentValue as FunctionalVector2ReflectionControl).Generate();
            var p = (AdderPosition.ContentValue as FunctionalVector2ReflectionControl).Generate();
            return new MechanicalAcceleration2Manager
            {
                Array = arr,
                AdderPosition = p,
                AdderCourse = c,
                AdderVelocity = v
            };
        }
    }
}
