using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.SequencePoints.Reshuffle
{
    public sealed class ReshuffleDefault<T> : IReshuffle<T>
    {
        public List<T> Shuffle(List<T> array)
        {
            return array;
        }
    }
}
