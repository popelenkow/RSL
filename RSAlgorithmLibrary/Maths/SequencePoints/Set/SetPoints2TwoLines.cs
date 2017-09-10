using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Set
{

    public sealed class SetPoints2TwoLines : ISetPoints2
    {
        //variables
        public Vector2 Begin { get; set; }
        public Vector2 End { get; set; }

        //methods
        public List<Vector2> Create(int count)
        {
            if (count < 0)
            {
                throw new Exception("count less than 0");
            }

            List<Vector2> res = new List<Vector2>(count);

            int sh = count / 2;
            int fh = count - sh;

            Vector2 end, begin, dir;

            end = End;
            begin = Begin;
            end.Y = begin.Y;
            dir = end - begin;
            DrawLine(res, dir, fh, begin);

            end = End;
            begin = Begin;
            begin.Y = end.Y;
            dir = end - begin;
            DrawLine(res, dir, sh, begin);

            return res;
        }
        private void DrawLine(List<Vector2> arr, Vector2 dir, int count, Vector2 begin)
        {
            if (count == 0) return;
            if (count == 1)
            {
                arr.Add(begin);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                double numerator = i;
                double denominator = count - 1;
                double ratio = numerator / denominator;
                Vector2 val = begin + (dir * ratio);
                arr.Add(val);
            }
        }
    }
}
