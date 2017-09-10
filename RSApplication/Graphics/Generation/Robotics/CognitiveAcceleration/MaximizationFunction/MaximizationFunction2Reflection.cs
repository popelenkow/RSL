using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration.MaximizationFunction
{
    public static class MaximizationFunction2Reflection
    {
        private static UIReflector _reflector = new UIReflector(typeof(IMaximizationFunction2Control));
        public static UIReflector Reflector
        {
            get { return _reflector; }
        }
        public static IEnumerable<UIReflectorData> Controls
        {
            get { return _reflector.Controls; }
        }
        public static UIElement GetControl(string name)
        {
            return _reflector.GetControl(name);
        }
    }
}
