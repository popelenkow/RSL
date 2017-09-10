using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct SphericalVector2
    {
        //variables
        private double _radius;
        private Direction2 _direction;


        //get set variables
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Direction2 Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }


        //constructors
        public SphericalVector2(double radius = 0.0, Direction2 direction = new Direction2())
        {
            _radius = radius;
            _direction = direction;
        }
        public SphericalVector2(Vector2 vector)
        {
            _radius = vector.Magnitude();
            _direction = new Direction2(vector);
        }
        public SphericalVector2(double x, double y)
        {
            Vector2 vector = new Vector2(x, y);
            _radius = vector.Magnitude();
            _direction = new Direction2(vector);
        }


        //methods
        public Vector2 CreateVector2()
        {
            return Direction.CreateVector2(Radius);
        }
        public SphericalVector2 Normalized()
        {
            return new SphericalVector2(1.0, Direction);
        }

        //operators
        public static SphericalVector2 operator +(SphericalVector2 value1, SphericalVector2 value2)
        {
            Vector2 v = value1.CreateVector2() + value2.CreateVector2();
            SphericalVector2 res = new SphericalVector2(v);
            return res;
        }
        public static SphericalVector2 operator -(SphericalVector2 value1, SphericalVector2 value2)
        {
            Vector2 v = value1.CreateVector2() - value2.CreateVector2();
            SphericalVector2 res = new SphericalVector2(v);
            return res;
        }
        public static SphericalVector2 operator *(SphericalVector2 value1, double value2)
        {
            SphericalVector2 res = new SphericalVector2();
            res.Radius = value1.Radius * value2;
            res.Direction = value1.Direction;
            return res;
        }
        public static SphericalVector2 operator /(SphericalVector2 value1, double value2)
        {
            SphericalVector2 res = new SphericalVector2();
            res.Radius = value1.Radius / value2;
            res.Direction = value1.Direction;
            return res;
        }
    }
}
