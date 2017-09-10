using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.FunctionalVector;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;

namespace RSL.Robotics.MechanicalAcceleration
{
    public interface IMechanicalManager2
    {
        //Manager
        List<IMechanicalAcceleration2> Array { get; set; }
        //Acceleration
        Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics);
        Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics);
        Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics);
    }
}
