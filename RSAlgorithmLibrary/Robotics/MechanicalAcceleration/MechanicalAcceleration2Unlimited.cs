using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;

namespace RSL.Robotics.MechanicalAcceleration
{
    public sealed class MechanicalAcceleration2Unlimited : IMechanicalAcceleration2
    {
        //methods
        public Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            Vector2 res;
            Vector2 v = physics.Velocity;
            Vector2 a = logics.GoalAcceleration;
            double t = deltaTime;
            res = v + a * t;
            return new Direction2(res);
        }

        public Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            Vector2 res;
            Vector2 p = physics.Position;
            Vector2 v = physics.Velocity;
            Vector2 a = logics.GoalAcceleration;
            double t = deltaTime;
            res = p + v * t + (a * t * t)/2;
            return res;
        }

        public Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            Vector2 res;
            Vector2 v = physics.Velocity;
            Vector2 a = logics.GoalAcceleration;
            double t = deltaTime;
            res = v + a * t;
            return res;
        }
    }
}
