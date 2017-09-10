using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Set
{
    public sealed class SetPoints2Default : ISetPoints2
    {
        public List<Vector2> Create(int count)
        {
            var res = new List<Vector2>();
            for (int i = 0; i < count; i++)
            {
                res.Add(new Vector2());
            }
            return res;
        }
    }
}

