using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Set
{
    public sealed class SetPoints2Circle : ISetPoints2
    {
        //variables
        public Direction2 Direction;
        public double Radius;
        public Vector2 PositionCircle;

        //constructors
        public SetPoints2Circle(double radius, Vector2 positionCircle, Direction2 dir = new Direction2())
        {
            Radius = radius;
            Direction = dir;
            PositionCircle = positionCircle;
        }

        //methods
        public List<Vector2> Create(int count)
        {
            if (count < 1)
            {
                throw new Exception("count less than 1");
            }

            List<Vector2> res = new List<Vector2>(count);

            for (int i = 0; i < count; i++)
            {
                double numerator = i;
                double denominator = count;
                double ratio = numerator / denominator;
                Direction2 dir = Direction + new Direction2(360 * ratio);
                Vector2 val = PositionCircle + dir.CreateVector2(Radius);
                res.Add(val);
            }

            return res;
        }
    }
}
