using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.CognitiveAcceleration;

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration.MaximizationFunction
{
    public interface IMaximizationFunction2Control
    {
        IMaximizationFunction2 Generate();
    }
}
