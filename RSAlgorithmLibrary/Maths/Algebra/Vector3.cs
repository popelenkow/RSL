using System;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct Vector3
    {
        //variables
        private double _x;
        private double _y;
        private double _z;

        //get set variables
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public double Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        //constructors
        public Vector3(double x = 0, double y = 0, double z = 0)
        {
            _x = x;
            _y = y;
            _z = z;

        }


        //methods
        public double Magnitude()
        {
            double value;
            value = X * X + Y * Y + Z * Z;
            value = Math.Sqrt(value);
            return value;
        }
        public Vector3 Normalized()
        {
            Vector3 res = new Vector3();
            double m = Magnitude();
            res.X = X / m;
            res.Y = Y / m;
            res.Z = Z / m;
            return res;
        }

        //operators
        public static Vector3 operator +(Vector3 value1, Vector3 value2)
        {
            Vector3 res = new Vector3();
            res.X = value1.X + value2.X;
            res.Y = value1.Y + value2.Y;
            res.Z = value1.Z + value2.Z;
            return res;
        }
        public static Vector3 operator -(Vector3 value1, Vector3 value2)
        {
            Vector3 res = new Vector3();
            res.X = value1.X - value2.X;
            res.Y = value1.Y - value2.Y;
            res.Z = value1.Z - value2.Z;
            return res;
        }
        public static Vector3 operator *(Vector3 value1, double value2)
        {
            Vector3 res = new Vector3();
            res.X = value1.X * value2;
            res.Y = value1.Y * value2;
            res.Z = value1.Z * value2;
            return res;
        }
        public static Vector3 operator /(Vector3 value1, double value2)
        {
            Vector3 res = new Vector3();
            res.X = value1.X / value2;
            res.Y = value1.Y / value2;
            res.Z = value1.Z / value2;
            return res;
        }
    }
}
