using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RSL.World;

namespace RSL.Analysis
{
    public interface IAnalyzer
    {
        string Name { get; }
        List<DataPoint> Points { get; }
        void Compute(IWorld2 world);
    }
}
