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

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration
{
    
    /// <summary>
    /// Логика взаимодействия для CognitiveAcceleration2ManagerControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2ManagerControl : UserControl
    {
        public CognitiveAcceleration2ManagerControl()
        {
            InitializeComponent();

        }
        public ICognitiveAcceleration2Manager Generate()
        {
            List<ICognitiveAcceleration2> arr = CognitiveAcceleration2Stack.Generate();
            var adder = (AdderAcceleration.ContentValue as FunctionalVector2ReflectionControl).Generate();
            return new CognitiveManager2
            {
                Array = arr,
                AdderAcceleration = adder
            };
        }
    }
}
