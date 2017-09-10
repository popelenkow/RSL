using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Algebra
{
    [Serializable]
    public struct SphericalVector3
    {
        //variables
        private double _radius;
        private Direction3 _direction;


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
        public Direction3 Direction
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
        public SphericalVector3(double radius = 0.0, Direction3 direction = new Direction3())
        {
            _radius = radius;
            _direction = direction;
        }
        public SphericalVector3(Vector3 vector)
        {
            _radius = vector.Magnitude();
            _direction = new Direction3(vector);
        }
        public SphericalVector3(double x, double y, double z)
        {
            Vector3 vector = new Vector3(x, y, z);
            _radius = vector.Magnitude();
            _direction = new Direction3(vector);
        }  


        //methods
        public Vector3 CreateVector3()
        {
            return Direction.CreateVector3(Radius);
        }
        public SphericalVector3 Normalized()
        {
            return new SphericalVector3(1.0, Direction);
        }

        //operators
        public static SphericalVector3 operator +(SphericalVector3 value1, SphericalVector3 value2)
        {
            Vector3 v = value1.CreateVector3() + value2.CreateVector3();
            SphericalVector3 res = new SphericalVector3(v);
            return res;
        }
        public static SphericalVector3 operator -(SphericalVector3 value1, SphericalVector3 value2)
        {
            Vector3 v = value1.CreateVector3() - value2.CreateVector3();
            SphericalVector3 res = new SphericalVector3(v);
            return res;
        }
        public static SphericalVector3 operator *(SphericalVector3 value1, double value2)
        {
            SphericalVector3 res = new SphericalVector3();
            res.Radius = value1.Radius * value2;
            res.Direction = value1.Direction;
            return res;
        }
        public static SphericalVector3 operator /(SphericalVector3 value1, double value2)
        {
            SphericalVector3 res = new SphericalVector3();
            res.Radius = value1.Radius / value2;
            res.Direction = value1.Direction;
            return res;
        }
    }
}
