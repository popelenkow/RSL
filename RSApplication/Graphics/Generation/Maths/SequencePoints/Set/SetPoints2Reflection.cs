using System;
using System.Windows;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Set
{
    public static class SetPoints2Reflection
    {
        private static UIReflector _reflector = new UIReflector(typeof(ISetPoints2Control));
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
