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
    public sealed class CA2PurposeMaximizationFunction : ICognitiveAcceleration2
    {
        //special data
        private struct DataDesired
        {
            public double DistanceCollision;
            public Direction2 DevationGoal;
            public double ValueFunction;
        }

        //variables
        private double _parameterTime;
        private IMaximizationFunction2 _maximizationFunction;
        private double _angleVisibility;
        private double _samplingAngleVisibility;
        public double MaxVisibleRange { get; set; }
        public double MaxCollisionRange { get; set; }

        //constructors
        public CA2PurposeMaximizationFunction(double patameterTime, IMaximizationFunction2 maximizationFunction, double angleVisibility, double samplingAngleVisibility)
        {
            _parameterTime = patameterTime;
            _maximizationFunction = maximizationFunction;
            _angleVisibility = angleVisibility;
            _samplingAngleVisibility = samplingAngleVisibility;
        }

        //methods
        public Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics)
        {
            //preparation
            Vector2 posGoalVec = logics.GoalPosition.ComputeDestination();
            //temporary
            INavigationMap2 navigationMap = logics.NavigationMap;
            ITactic2 tactic = logics.Tactic;
            SphericalVector2 posGoal = new SphericalVector2(posGoalVec);
            //resultant
            Vector2 velCur = physics.Velocity;
            Vector2 posDes = ComputePositionDesired(posGoal, tactic, navigationMap);

            Vector2 res = DifferentiateAcceleration(posDes, velCur);
            return res;
        }


        Vector2 ComputePositionDesired(SphericalVector2 posGoal, ITactic2 tactic, INavigationMap2 navigationMap)
        {
            double angleVisibility = _angleVisibility;
            double samplingAngle = _samplingAngleVisibility;
            int countAngularSteps = (int)(angleVisibility / samplingAngle);
            int halfAngularSteps = countAngularSteps / 2;

            Direction2 devationGoal = new Direction2();
            DataDesired desired = ComputeDataDesired(devationGoal, posGoal, tactic, navigationMap);
            DataDesired buf;

            for (int i = 1; i < halfAngularSteps; i++)
            {
                devationGoal = new Direction2(i * samplingAngle);
                buf = ComputeDataDesired(devationGoal, posGoal, tactic, navigationMap);
                if (buf.ValueFunction * 0.999 > desired.ValueFunction)
                {
                    desired = buf;
                }

                devationGoal = new Direction2(-i * samplingAngle);
                buf = ComputeDataDesired(devationGoal, posGoal, tactic, navigationMap);
                if (buf.ValueFunction * 0.999 > desired.ValueFunction)
                {
                    desired = buf;
                }
            }

            return (desired.DevationGoal+posGoal.Direction).CreateVector2(desired.DistanceCollision);
        }

        DataDesired ComputeDataDesired(Direction2 devationGoal, SphericalVector2 posGoal, ITactic2 tactic, INavigationMap2 navigationMap)
        {
            var distColReal = tactic.СomputeDistance(posGoal.Direction + devationGoal, navigationMap).CleanRange;
            var distMax = Math.Min(posGoal.Radius, MaxVisibleRange);
            var distCol = distColReal - MaxCollisionRange;
            distCol = Math.Min(distCol, distMax);
            if (distCol < 0) distCol = 0;

            var F = _maximizationFunction.ComputeValue(distCol, distMax, devationGoal);
            
            return new DataDesired()
            {
                DevationGoal = devationGoal,
                DistanceCollision = distCol,
                ValueFunction = F
            };
        }


        private Vector2 DifferentiateAcceleration(Vector2 posDes, Vector2 velCur)
        {
            double time = _parameterTime;
            Vector2 velDes = posDes / time;
            Vector2 acceleretion = (velDes - velCur)*4 / time;
            return acceleretion;
        }
    }
}
