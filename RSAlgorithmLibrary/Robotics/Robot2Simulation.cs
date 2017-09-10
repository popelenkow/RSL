using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.CognitiveAcceleration;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.MechanicalAcceleration;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;
using RSL.Maths.FunctionalVector;
using RSL.World.Time;
using System.ComponentModel;

namespace RSL.Robotics
{
    
    public sealed class Robot2Simulation : IRobot2
    {
        //variables
        private ICognitiveAcceleration2Manager _cognitive;
        private IMechanicalManager2 _mechanical;
        private IPhysics2 _physics;
        private ILogics2 _logics;
        private ITimer _cognitiveTimer;
        private ITimer _mechanicalTimer;

        //get set variables
        public ICognitiveAcceleration2Manager CognitiveManager
        {
            get { return _cognitive; }
            set { _cognitive = value; }
        }
        public ILogics2 Logics
        {
            get { return _logics; }
            set { _logics = value; }
        }
        public IMechanicalManager2 MechanicalManager
        {
            get { return _mechanical; }
            set { _mechanical = value; }
        }
        public IPhysics2 Physics
        {
            get { return _physics; }
            set { _physics = value; }
        }
        public ITimer CognitiveTimer
        {
            get { return _cognitiveTimer; }
            set { _cognitiveTimer = value; }
        }
        public ITimer MechanicalTimer
        {
            get { return _mechanicalTimer; }
            set { _mechanicalTimer = value; }
        }

        //constructors
        public Robot2Simulation()
        {
            CognitiveManager = new CognitiveManager2();
            MechanicalManager = new MechanicalAcceleration2Manager();
            Physics = new Physics2();
            Logics = new Logics2();
        }
        public Robot2Simulation(IPhysics2 physics, ILogics2 logics, ICognitiveAcceleration2Manager cognitive, IMechanicalManager2 mechanical, ITimer cognitiveTimer, ITimer mechanicalTimer)
        {
            CognitiveManager = cognitive;
            MechanicalManager = mechanical;
            Physics = physics;
            Logics = logics;
            _mechanicalTimer = mechanicalTimer;
            _cognitiveTimer = cognitiveTimer;
        }

        //methods
        public void ComputeCognitive()
        {
            int tick = _cognitiveTimer.CountTick();
            if (tick == 0) return;

            Logics.NavigationMap = Logics.Navigator.CreateMap();
            Vector2 goalAcceleration = CognitiveManager.ComputeAcceleration(Logics, Physics);
            Logics.GoalAcceleration = goalAcceleration;
        }

        public void ComputeMechanical()
        {
            double deltaTime = _mechanicalTimer.CountDeltaTime();
            if (deltaTime == 0) return;


            Vector2 position = MechanicalManager.ComputePosition(deltaTime, Logics, Physics);
            Vector2 velocity = MechanicalManager.ComputeVelocity(deltaTime, Logics, Physics);
            Direction2 course = MechanicalManager.ComputeCourse(deltaTime, Logics, Physics);
            Physics.Position = position;
            Physics.Velocity = velocity;
            Physics.Course = course;
        }
    }
}
