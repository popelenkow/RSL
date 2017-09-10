using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.Space
{
    public sealed class Space2Half : ISpace2
    {
        //variables
        public Vector2 Position { get; set; }
        public Direction2 Direction { get; set; }

        //constructors
        public Space2Half(Vector2 position, Direction2 direction)
        {
            Position = position;
            Direction = direction;
        }

        //methods
        public bool IsInsidePoint(Vector2 point)
        {
            Vector2 vec1 = point - Position;
            Vector2 vec2 = Direction.CreateVector2();
            double value = Multiplier.Dot2(vec1, vec2);
            if (value >= 0) return true;
            else return false;
        }
    }
}
