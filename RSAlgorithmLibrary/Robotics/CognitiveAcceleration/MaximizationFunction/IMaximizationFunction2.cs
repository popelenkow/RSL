using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.CognitiveAcceleration
{
    public interface IMaximizationFunction2
    {
        double ComputeValue(double distanceColision, double distanceMax, Direction2 devationGoal);
    }
}
