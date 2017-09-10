using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.Space
{
    public class Space2Full : ISpace2
    {
        //variables
        public Vector2 Position { get; set; }
        public Direction2 Direction { get; set; }

       
        //methods
        public bool IsInsidePoint(Vector2 point)
        {
            return true;
        }
    }
}
