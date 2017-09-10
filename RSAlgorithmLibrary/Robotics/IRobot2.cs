using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.CognitiveAcceleration;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.MechanicalAcceleration;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics
{
    public interface IRobot2
    {
        ICognitiveAcceleration2Manager CognitiveManager { get; set; }
        IMechanicalManager2 MechanicalManager { get; set; }
        ILogics2 Logics { get; set; }
        IPhysics2 Physics { get; set; }

        void ComputeCognitive();
        void ComputeMechanical();
    }
}
