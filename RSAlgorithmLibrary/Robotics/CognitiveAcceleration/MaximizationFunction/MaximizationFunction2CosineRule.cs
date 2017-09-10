using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.CognitiveAcceleration
{
    public sealed class MaximizationFunction2CosineRule : IMaximizationFunction2
    {
        public double ComputeValue(double distanceColision, double distanceMax, Direction2 devationGoal)
        {
            double m = distanceMax;
            double c = distanceColision;
            double a = devationGoal.Azimuthal * Constants.DegToRad;
            return 2*m* c * Math.Cos(a) - c*c;
        }
    }
}
