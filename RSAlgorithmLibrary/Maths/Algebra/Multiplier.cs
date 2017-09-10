using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    public static class Multiplier
    {
        public static double Dot2(Vector2 value1, Vector2 value2)
        {
            double x = value1.X * value2.X;
            double y = value1.Y * value2.Y;
            return x + y;
        }
        public static double Cos2(Vector2 value1, Vector2 value2)
        {
            return Cos2(new SphericalVector2(value1), new SphericalVector2(value2));
        }
        public static double Dot3(Vector3 value1, Vector3 value2)
        {
            double x = value1.X * value2.X;
            double y = value1.Y * value2.Y;
            double z = value1.Z * value2.Z;
            return x + y + z;
        }
       
        public static double Dot2(SphericalVector2 value1, SphericalVector2 value2)
        {
            return Dot2(value1.CreateVector2(), value2.CreateVector2());
        }
        public static double Cos2(SphericalVector2 value1, SphericalVector2 value2)
        {
            var a1 = value1.Direction.Azimuthal;
            var a2 = value2.Direction.Azimuthal;
            return Math.Cos(Constants.DegToRad*(a1-a2));
        }
        public static double Dot3(SphericalVector3 value1, SphericalVector3 value2)
        {
            return Dot3(value1.CreateVector3(), value2.CreateVector3());
        }

        public static double Cross2(Vector2 value1, Vector2 value2)
        {
            double z = value1.X * value2.Y - value1.Y * value2.X;
            return z;
        }
        public static Vector3 Cross3(Vector3 value1, Vector3 value2)
        {
            double x = value1.Y * value2.Z - value1.Z * value2.Y;
            double y = value1.Z * value2.X - value1.X * value2.Z;
            double z = value1.X * value2.Y - value1.Y * value2.X;
            return new Vector3(x, y, z);
        }
        public static Vector2 Direction2ToVector2(Direction2 value1, Vector2 value2)
        {
            Vector2 res;
            Direction2 direction;
            double Magnitude = value2.Magnitude();
            direction = value1 + new Direction2(value2);
            res = direction.CreateVector2(Magnitude);
            return res;
        }
        public static Vector3 Direction3ToVector3(Direction3 value1, Vector3 value2)
        {
            Vector3 res;
            Direction3 direction;
            double Magnitude = value2.Magnitude();
            direction = value1 + new Direction3(value2);
            res = direction.CreateVector3(Magnitude);
            return res;
        }
    }
}
