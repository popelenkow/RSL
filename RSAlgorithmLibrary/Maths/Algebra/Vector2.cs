using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct Vector2
    {
        //variables
        private double _x;
        private double _y;

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


        //constructors
        public Vector2(double x = 0, double y = 0)
        {
            _x = x;
            _y = y;
        }


        //methods
        public double Magnitude()
        {
            double value;
            value = X * X + Y * Y;
            value = Math.Sqrt(value);
            return value;
        }
        public Vector2 Normalized()
        {
            Vector2 res = new Vector2();
            double m = Magnitude();
            res.X = X / m;
            res.Y = Y / m;
            return res;
        }

        //operators
        public static Vector2 operator +(Vector2 value1, Vector2 value2)
        {
            Vector2 res = new Vector2()
            {
                X = value1.X + value2.X,
                Y = value1.Y + value2.Y
            };
            return res;
        }
        public static Vector2 operator -(Vector2 value1, Vector2 value2)
        {
            Vector2 res = new Vector2
            {
                X = value1.X - value2.X,
                Y = value1.Y - value2.Y
            };
            return res;
        }
        public static Vector2 operator *(Vector2 value1, double value2)
        {
            Vector2 res = new Vector2
            {
                X = value1.X * value2,
                Y = value1.Y * value2
            };
            return res;
        }
        public static Vector2 operator /(Vector2 value1, double value2)
        {
            Vector2 res = new Vector2()
            {
                X = value1.X / value2,
                Y = value1.Y / value2
            };
            return res;
        }
    }
}
