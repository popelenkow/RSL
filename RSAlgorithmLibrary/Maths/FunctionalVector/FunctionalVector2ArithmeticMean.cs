using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.FunctionalVector
{
    public class FunctionalVector2ArithmeticMean : IFunctionalVector2
    {
        public Vector2 Compute(List<Vector2> array)
        {
            Vector2 res = new Vector2();
            if (array.Count == 0) return res;
           
            foreach (var v in array)
            {
                res += v;
            }
            res /= array.Count;
            return res;
        }
    }
}
