using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.PhysicalCharacteristics
{
    public interface IPhysics2
    {
        string Name { get; set; }
        Direction2 Course { get; set; }
        Vector2 Velocity { get; set; }
        Vector2 Position { get; set; }
        double Proportions { get; set; }
    }
}
