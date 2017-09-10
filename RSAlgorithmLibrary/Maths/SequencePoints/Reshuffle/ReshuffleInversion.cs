using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Reshuffle
{
    public class ReshuffleInversion<T> : IReshuffle<T>
    {
     
        //methods
        public List<T> Shuffle(List<T> array)
        {
            int cnt = array.Count;

            List<T> res = new List<T>(new T[array.Count]);

            for (int i = 0; i < cnt; i++)
            {
                res[i] = array[cnt - 1 - i];
            }

            return res;
        }
    }
}
