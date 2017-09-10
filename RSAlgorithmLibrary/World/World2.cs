using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.World.Map;
using RSL.World.Time;
using RSL.Robotics;

namespace RSL.World
{
    public sealed class World2 : IWorld2
    {
        //variables
        private IWorldMap2 _map;
        private IWorldTime _time;

        //get set variables
        public IWorldMap2 Map
        {
            get { return _map; }
            set { _map = value; }
        }

        public IWorldTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        //constructors
        public World2()
        {
            Map = new WorldMap2();
            Time = new WorldTimeSimulation();
        }
        public World2(IWorldMap2 map, IWorldTime time)
        {
            Map = map;
            Time = time;
        }

        //method
        public void Update()
        {
            _time.Update();
            foreach (IRobot2 robot in _map.Robots)
            {
                robot.ComputeCognitive();
            }
            foreach (IRobot2 robot in _map.Robots)
            {
                robot.ComputeMechanical();
            }
        }
    }
}
