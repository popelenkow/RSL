using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Space;
using RSL.World.Map;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;

namespace RSL.Robotics.LogicalCharacteristics
{
    public class RangeFinder
    {
        private Space2Sector LocalVisibleSector { get; set; }
        public Space2Sector VisibleSector
        {
            get
            {
                var course = MyRobot.Course + new Direction2(LocalVisibleSector.Position);
                var pos = MyRobot.Position + course.CreateVector2(LocalVisibleSector.Position.Magnitude());
                return new Space2Sector
                {
                    Direction = LocalVisibleSector.Direction + MyRobot.Course,
                    DeltaAngle = LocalVisibleSector.DeltaAngle,
                    Radius = LocalVisibleSector.Radius,
                    Position = pos
                };
            }
        }
        public double CleanRange { get; set; }

        public List<IPhysics2> Robots { get; set; }
        public IPhysics2 MyRobot { get; set; }


        public void Update()
        {
            foreach (var r in Robots)
            {
                var s = VisibleSector;
                var v = r.Position - s.Position;
                var da = Modulus.Absolute((s.Direction - new Direction2(v)).Standardized().Azimuthal);
                if (da <= s.DeltaAngle)
                {
                    
                }
                else if (da <= s.DeltaAngle*2)
                {

                }

            }
           
        }
        /*
        public bool IsMyDirection(Direction2 direction)
        {

            Direction2 devation = direction - new Direction2(posRobot);
            double angle = devation.Azimuthal;
            double adjacentSide = posRobot.Magnitude();
            double oppositeSide = proportions;
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
        */
    }
}
