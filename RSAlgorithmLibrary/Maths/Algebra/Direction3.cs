using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct Direction3
    {
        //variables
        private double _a; //Azimuthal
        private double _p; //Polar

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
        public double Polar
        {
            get
            {
                return _p;
            }
            set
            {
                _p = value;
            }
        }

        //constructors
        public Direction3(double azimuthal = 0.0, double polar = 0.0)
        {
            _a = azimuthal;
            _p = polar;
        }

        public Direction3(Vector3 value)
        {
            double a = CalculateAzimuthal(value);
            double p = CalculatePolar(value);

            _a = a;
            _p = p;
        }

        //methods
        public Vector3 CreateVector3(double Magnitude = 1.0)
        {
            Vector3 res = new Vector3();
            double p = _p * Constants.DegToRad;
            double a = _a * Constants.DegToRad;
            res.X = Math.Cos(p) * Math.Cos(a);
            res.Y = Math.Cos(p) * Math.Sin(a);
            res.Z = Math.Sin(p);
            res *= Magnitude;
            return res;
        }
        /// <summary>
        ///  Polar [-90; 90]
        ///  Azimuthal [-180; 180)
        /// </summary>
        public Direction3 Standardized()
        {
            double a = Period.Calculate(Azimuthal, -180.0, 180.0);
            double p = Period.Calculate(Polar, -180.0, 180.0);

            double quotient = GetOverflowPolar(p);
            bool isOverflow = (quotient != 0.0);

            if (isOverflow)
            {
                p = quotient * 180.0 - p;
                a = 180.0 - a;
                a = Period.Calculate(a, -180.0, 180.0);
            }

            Direction3 res = new Direction3(a, p);
            return res;
        }
        private double GetOverflowPolar(double p)
        {
            double quotient;
            quotient = p / 180.0;
            if (quotient != 0.5)
            {
                quotient = Math.Round(quotient);
            }
            else
            {
                quotient = 0.0;
            }
            return quotient;
        }

        //static methods
        public static double CalculateAzimuthal(Vector3 value)
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
        public static double CalculatePolar(Vector3 value)
        {
            double res = 0.0;

            bool isNullZ = (value.Z == 0.0);

            if (!isNullZ)
            {
                double Magnitude = value.Magnitude();
                double x = value.Z / Magnitude;
                res = Math.Acos(x) * Constants.RadToDeg;
                res *= Modulus.Sign(value.Z);
            }

            return res;
        }

        //operators
        public static Direction3 operator +(Direction3 value1, Direction3 value2)
        {
            Direction3 res = new Direction3();
            res.Azimuthal = value1.Azimuthal + value2.Azimuthal;
            res.Polar = value1.Polar + value2.Polar;
            return res;
        }
        public static Direction3 operator -(Direction3 value1, Direction3 value2)
        {
            Direction3 res = new Direction3();
            res.Azimuthal = value1.Azimuthal - value2.Azimuthal;
            res.Polar = value1.Polar - value2.Polar;
            return res;
        }

        public static Direction3 operator *(Direction3 value1, double value2)
        {
            Direction3 res = new Direction3();
            res.Azimuthal = value1.Azimuthal * value2;
            res.Polar = value1.Polar * value2;
            return res;
        }
        public static Direction3 operator /(Direction3 value1, double value2)
        {
            Direction3 res = new Direction3();
            res.Azimuthal = value1.Azimuthal / value2;
            res.Polar = value1.Polar / value2;
            return res;
        }
    }
}
