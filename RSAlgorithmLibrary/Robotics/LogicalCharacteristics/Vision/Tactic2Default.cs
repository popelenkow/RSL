using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class Tactic2Default : ITactic2
    {
        public RangeData СomputeDistance(Direction2 direction, INavigationMap2 navigationMap)
        {
            return new RangeData
            {
                CleanRange = 0,
                VisibleRange = 0
            };
        }
    }
}
