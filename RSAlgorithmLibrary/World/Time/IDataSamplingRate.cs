using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public interface IDataSamplingRate
    {
        void SetSamplingRate(int CountTick, double SamplingRate);
    }
}
