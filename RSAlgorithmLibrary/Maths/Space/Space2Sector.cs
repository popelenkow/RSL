using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.Space
{
    public class Space2Sector : ISpace2
    {
        public Vector2 Position { get; set; }
        public Direction2 Direction { get; set; }
        public double Radius { get; set; }
        public double DeltaAngle { get; set; }
        

        public bool IsInsidePoint(Vector2 point)
        {
            Direction2 d = new Direction2(point - Position);
            d = Direction - d;
            d = d.Standardized();
            double angle = Modulus.Absolute(d.Azimuthal);
            if (angle <= DeltaAngle) return true;
            return false;
        }
        
    }
}
