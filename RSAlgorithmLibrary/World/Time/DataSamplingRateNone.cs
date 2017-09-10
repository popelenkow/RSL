using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public sealed class DataSamplingRateNone : IDataSamplingRate
    {
        public void SetSamplingRate(int CountTick, double SamplingRate)
        {
        }
    }
}
