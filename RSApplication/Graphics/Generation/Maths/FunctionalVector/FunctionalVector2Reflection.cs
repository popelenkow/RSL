using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSL.Graphics.Generation.Maths.FunctionalVector
{
    public static class FunctionalVector2Reflection
    {
        private static UIReflector _reflector = new UIReflector(typeof(IFunctionalVector2Control));
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
