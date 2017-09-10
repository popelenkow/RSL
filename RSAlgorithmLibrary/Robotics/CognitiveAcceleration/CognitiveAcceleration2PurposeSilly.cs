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
    public sealed class CA2PurposeSilly : ICognitiveAcceleration2
    {
        //variables
        private double _parameterTime;
     
        public double MaxVisibleRange { get; set; }


        public double ParameterTime
        {
            get { return _parameterTime; }
            set { _parameterTime = value; }
        }
        public double ParameterLength { get; set; }
        
        //constructors
        public CA2PurposeSilly()
        {
           
        }

        //methods
        public Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics)
        {

            Vector2 velCur = physics.Velocity;
            var dir = new Direction2(logics.GoalPosition.ComputeDestination());
            var speed = Math.Min(logics.GoalPosition.ComputeDestination().Magnitude(), MaxVisibleRange);
            Vector2 res = DifferentiateAcceleration(dir.CreateVector2(speed), velCur);
            return res;
        }
        private Vector2 DifferentiateAcceleration(Vector2 posDes, Vector2 velCur)
        {
            double time = _parameterTime;
            double d = Math.Min(ParameterLength, posDes.Magnitude());

            Vector2 velDes = posDes.Normalized() *d / time;
            Vector2 acceleretion = (velDes - velCur) * 4 / time;
            return acceleretion;
        }
    }
}
