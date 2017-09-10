using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RSL.Maths.Algebra;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.MechanicalAcceleration
{
    public interface IMechanicalAcceleration2
    {
        Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics);
        Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics);
        Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics);
    }
}
