using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.CognitiveAcceleration.MaximizationFunction
{
    public sealed class MaximizationFunction2Same : IMaximizationFunction2
    {
        public double ComputeValue(double distanceColision, double distanceMax, Direction2 devationGoal)
        {
            return distanceColision;
        }
    }
}
