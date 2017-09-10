using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.World.Time;

namespace RSL.Graphics.Generation.World.Time
{
    public interface IWorldTimeControl
    {
        IWorldTime Generate();
    }
}
