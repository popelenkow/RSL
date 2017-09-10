using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.Space
{
    public interface ISpace2
    {
        Vector2 Position { get; set; }
        Direction2 Direction { get; set; }
        bool IsInsidePoint(Vector2 point);
    }
}
