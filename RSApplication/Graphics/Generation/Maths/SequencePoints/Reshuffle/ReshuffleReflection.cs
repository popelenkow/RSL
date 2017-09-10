using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle
{
    public static class ReshuffleReflection
    {
        private static UIReflector _reflector = new UIReflector(typeof(IReshuffleControl));
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
