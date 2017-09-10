using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics;
using RSL.Maths.Algebra;

namespace RSL.World.Map
{
    public interface IWorldMap2
    {
        Vector2 Dimension { get; set; }
        List<IRobot2> Robots { get; set; }
    }
}
