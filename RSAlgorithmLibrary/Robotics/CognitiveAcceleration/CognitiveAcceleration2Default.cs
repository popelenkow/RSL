using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.CognitiveAcceleration
{
    public sealed class CognitiveAcceleration2Default : ICognitiveAcceleration2
    {
        //methods
        public Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics)
        {
            return new Vector2();
        }
    }
}
