using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;
using RSL.Maths.Space;

namespace RSL.Robotics.LogicalCharacteristics
{
    public interface INavigationMap2
    {
        IPhysics2 MyRobot { get; }
        List<IPhysics2> Robots { get; }
        ISpace2 VisibleSpace { get; set; }
        ISpace2 CleanSpace { get; set; }
    }
}
