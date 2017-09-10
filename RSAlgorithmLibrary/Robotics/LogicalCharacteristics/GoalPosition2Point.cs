using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class GoalPosition2Point : IGoalPosition2
    {
        //variables
        private Vector2 _goalPoint;
        private IPhysics2 _physics;
        //get set variables
        public Vector2 GoalPoint
        {
            get { return _goalPoint; }
            set { _goalPoint = value; }
        }
        public IPhysics2 Physics
        {
            get { return _physics; }
            set { _physics = value; }
        }

        //constructors
        public GoalPosition2Point()
        {
            GoalPoint = new Vector2();
            Physics = new Physics2();
        }
        public GoalPosition2Point(Vector2 destination, IPhysics2 physics)
        {
            GoalPoint = destination;
            Physics = physics;
        }

        //methods
        public Vector2 ComputeDestination()
        {
            var err = Physics.Proportions*0.05;
            var v = _goalPoint - _physics.Position;
            var s = new SphericalVector2(v);
            s.Radius -= err;
            
            if (s.Radius < 0)
            {
                s.Radius = 0;
            }
            return s.CreateVector2();
        }
    }
}
