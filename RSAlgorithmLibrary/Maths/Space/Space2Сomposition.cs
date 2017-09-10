using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.Space
{
    public class Space2Сomposition : ISpace2
    {
        public Vector2 Position { get; set; }
        public Direction2 Direction { get; set; }

        public List<ISpace2> ArraySpace { get; set; }

        public Space2Сomposition()
        {
            ArraySpace = new List<ISpace2>();
        }
        public bool IsInsidePoint(Vector2 point)
        {
            point += Position;
            SphericalVector2 v = new SphericalVector2(point);
            v.Direction += Direction;
            point = v.CreateVector2();
            foreach (var space in ArraySpace)
            {
                if (space.IsInsidePoint(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
