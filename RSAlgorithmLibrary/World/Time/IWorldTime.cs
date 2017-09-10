using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public interface IWorldTime
    {
        double CurrentTime { get; }
        double SpeedWorld { get; set; }
        bool Frozen { get; set; }
        void Update();
    }
}
