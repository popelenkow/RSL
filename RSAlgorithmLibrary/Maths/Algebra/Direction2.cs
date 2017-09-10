using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct Direction2
    {
        //variables
        private double _a; // Azimuthal

        //get set variables
        public double Azimuthal
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        //constructors
        public Direction2(double azimuthal = 0.0)
        {
            _a = azimuthal;
        }

        public Direction2(Vector2 value)
        {
            double a = CalculateAzimuthal(value);

            _a = a;
        }

        //methods
        public Vector2 CreateVector2(double Magnitude = 1.0)
        {
            Vector2 res = new Vector2();
            double a = _a * Constants.DegToRad;
            res.X = Math.Cos(a);
            res.Y = Math.Sin(a);
            res *= Magnitude;
            return res;
        }
        /// <summary>
        ///  Azimuthal [-180; 180)
        /// </summary>
        public Direction2 Standardized()
        {
            double a = Period.Calculate(Azimuthal, -180.0, 180.0);

            Direction2 res = new Direction2(a);
            return res;
        }

        //static methods
        public static double CalculateAzimuthal(Vector2 value)
        {

            double res = 0.0;

            bool isNullX = (value.X == 0.0);
            bool isNullY = (value.Y == 0.0);

            if (!isNullX || !isNullY)
            {
                double Magnitude = value.Magnitude();
                double x = value.X / Magnitude;
                res = Math.Acos(x) * Constants.RadToDeg;
                res *= Modulus.Sign(value.Y);
            }

            return res;
        }

        //operators
        public static Direction2 operator +(Direction2 value1, Direction2 value2)
        {
            Direction2 res = new Direction2();
            res.Azimuthal = value1.Azimuthal + value2.Azimuthal;
            return res;
        }
        public static Direction2 operator -(Direction2 value1, Direction2 value2)
        {
            Direction2 res = new Direction2();
            res.Azimuthal = value1.Azimuthal - value2.Azimuthal;
            return res;
        }

        public static Direction2 operator *(Direction2 value1, double value2)
        {
            Direction2 res = new Direction2();
            res.Azimuthal = value1.Azimuthal * value2;
            return res;
        }
        public static Direction2 operator /(Direction2 value1, double value2)
        {
            Direction2 res = new Direction2();
            res.Azimuthal = value1.Azimuthal / value2;
            return res;
        }
    }
}
