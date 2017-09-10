using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.LogicalCharacteristics
{
    public interface IGoalPosition2
    {
        Vector2 ComputeDestination();
    }
}