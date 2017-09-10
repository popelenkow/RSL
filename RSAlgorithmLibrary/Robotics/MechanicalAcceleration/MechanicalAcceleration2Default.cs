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
    public sealed class MechanicalAcceleration2Default : IMechanicalAcceleration2
    {
        public Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            return physics.Course;
        }

        public Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            return physics.Position;
        }

        public Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            return physics.Velocity;
        }
    }
}
