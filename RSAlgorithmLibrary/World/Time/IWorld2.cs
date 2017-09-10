using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.World.Map;
using RSL.World.Time;
namespace RSL.World
{
    public interface IWorld2
    {
        IWorldMap2 Map { get; set; }
        IWorldTime Time { get; set; }
        void Update();
    }
}
