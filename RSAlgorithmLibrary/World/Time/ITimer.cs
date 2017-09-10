using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public interface ITimer
    {
        double SamplingRate { get; }
        int Reset();
        int Reset(double samplingRate);
        int CountTick();
        double CountDeltaTime();
        IDataSamplingRate DataSamplingRate { get; set; }
    }
}
