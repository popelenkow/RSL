using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Maths.Space;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class Tactic2Static : ITactic2
    {
        public RangeData СomputeDistance(Direction2 direction, INavigationMap2 navigationMap)
        {
            IPhysics2 myRobot = navigationMap.MyRobot;
            double res = double.PositiveInfinity;
            foreach (IPhysics2 robot in navigationMap.Robots)
            {
                if (DetectCollision(direction, myRobot, robot))
                {
                    Vector2 pos = robot.Position - myRobot.Position;
                    double proportions = myRobot.Proportions + robot.Proportions;
                    double buf = CalculateDistance(direction, pos, proportions);
                    res = Math.Min(res, buf);
                }
                
            }
            return new RangeData
            {
                CleanRange = res,
                VisibleRange = res
            };

        }
        private double CalculateDistance(Direction2 direction, Vector2 posRobot, double proportions)
        {
            Direction2 devation = direction - new Direction2(posRobot);
            double angle = devation.Azimuthal;
            double adjacentSide = posRobot.Magnitude();
            double oppositeSide = proportions*1.2;
            List<double> res = CosineRule.AdjacentSide(angle, adjacentSide, oppositeSide);
            if (res.Count == 2)
            {
                return Math.Min(res[0], res[1]);
            }
            else if (res.Count == 1)
            {
                return res[0];
            }
            else
            {
                return 0.0;
            }
        }
        private bool DetectCollision(Direction2 direction, IPhysics2 myRobot, IPhysics2 otherRobot)
        {
            ISpace2 front = new Space2Half(myRobot.Position, direction);
            if (!front.IsInsidePoint(otherRobot.Position)) return false;

            Direction2 leftDirection = direction + new Direction2(90);
            ISpace2 left = new Space2Half(myRobot.Position, leftDirection);
             
            double sign = 1;
            if (left.IsInsidePoint(otherRobot.Position))
            {
                sign = -1;
            }

            Vector2 pos = otherRobot.Position + leftDirection.CreateVector2(sign * 1.1*(otherRobot.Proportions + myRobot.Proportions));

            if (left.IsInsidePoint(pos) == (sign == -1)) return false;
            return true;
        }
    }
}
