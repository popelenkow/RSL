using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Analysis;

namespace RSL.Graphics.Generation.Analysis
{
    public interface IAnalyzerControl
    {
        IAnalyzer Generate();
    }
}
