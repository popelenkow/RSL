using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics;
using RSL.Maths.Algebra;

namespace RSL.World.Map
{
    public sealed class WorldMap2 : IWorldMap2
    {
        //variables
        private Vector2 _dimension;
        private List<IRobot2> _robots;

        //get set variables
        public List<IRobot2> Robots
        {
            get {      return _robots;   }
            set { _robots = value; }
        }

        public Vector2 Dimension
        {
            get    {    return _dimension;  }
            set        {         _dimension = value;       }
        }

        //constructors
        public WorldMap2()
        {
            Dimension = new Vector2();
            Robots = new List<IRobot2>();
        }
        public WorldMap2(Vector2 dimension)
        {
            Dimension = dimension;
            Robots = new List<IRobot2>();
        }
    }
}
