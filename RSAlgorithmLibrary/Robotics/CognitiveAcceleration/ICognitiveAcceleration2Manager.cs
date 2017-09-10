using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.FunctionalVector;
using RSL.Maths.Algebra;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.CognitiveAcceleration
{
    public interface ICognitiveAcceleration2Manager
    {
        //Manager
        List<ICognitiveAcceleration2> Array { get; set; }
        
        //Acceleration
        Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics);
    }
}
