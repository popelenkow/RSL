using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.SequencePoints.Reshuffle
{
    public interface IReshuffle<T>
    {
        List<T> Shuffle(List<T> array);
    }
}
