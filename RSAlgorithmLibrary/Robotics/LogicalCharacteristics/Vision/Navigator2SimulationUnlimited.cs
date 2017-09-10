using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.World.Map;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Space;

namespace RSL.Robotics.LogicalCharacteristics
{
    public class Navigator2SimulationUnlimited : INavigator2
    {
        private IWorldMap2 _worldMap;
        private IPhysics2 _myPhysicsRobot;
        public IWorldMap2 WorldMap
        {
            get { return _worldMap; }
            set { _worldMap = value; }
        }
        public IPhysics2 MyPhysicsRobot
        {
            get { return _myPhysicsRobot; }
            set { _myPhysicsRobot = value; }
        }

        public Navigator2SimulationUnlimited()
        {
            _worldMap = new WorldMap2(new Maths.Algebra.Vector2());
            _myPhysicsRobot = new Physics2();
        }
        public Navigator2SimulationUnlimited(IWorldMap2 worldMap, IPhysics2 myPhysicsRobot)
        {
            _worldMap = worldMap;
            _myPhysicsRobot = myPhysicsRobot;
        }

        public INavigationMap2 CreateMap()
        {
            List<IPhysics2> physicsRobots = new List<IPhysics2>();
            List<IRobot2> robots = _worldMap.Robots;

            foreach (IRobot2 robot in robots)
            {
                IPhysics2 physicsRobot = robot.Physics;
                if (physicsRobot != _myPhysicsRobot)
                {
                    physicsRobots.Add(physicsRobot);
                }
            }

            INavigationMap2 map = new NavigationMap2
            {
                Robots = physicsRobots,
                MyRobot = _myPhysicsRobot,
                CleanSpace = new Space2Full(),
                VisibleSpace = new Space2Full()
            };
            return map;
        }
    }
}
