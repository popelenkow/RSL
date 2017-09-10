using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Set
{
    public sealed class SetPoints2Line : ISetPoints2
    {
        //variables
        public Vector2 Begin;
        public Vector2 End;

        //constructors
        public SetPoints2Line(Vector2 begin, Vector2 end)
        {
            Begin = begin;
            End = end;
        }

        //methods
        public List<Vector2> Create(int count)
        {
            if (count < 0)
            {
                throw new Exception("count less than 0");
            }

            List<Vector2> res = new List<Vector2>(count);

            Vector2 dir = End - Begin;
            if (count == 1)
            {
                res.Add(Begin);
                return res;
            }
            for (int i = 0; i < count; i++)
            {
                double numerator = i;
                double denominator = count - 1;
                double ratio = numerator / denominator;
                Vector2 val = Begin + (dir * ratio);
                res.Add(val);
            }

            return res;
        }
    }
}
