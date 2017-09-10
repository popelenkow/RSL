using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Space;


namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class NavigationMap2 : INavigationMap2
    {
        //variables
        private List<IPhysics2> _robots;
        private IPhysics2 _myRobot;
        
        //get set variables
        public List<IPhysics2> Robots
        {
            get { return _robots; }
            set { _robots = value; }
        }

        public IPhysics2 MyRobot
        {
            get { return _myRobot; }
            set { _myRobot = value; }
        }
        public ISpace2 VisibleSpace { get; set; }
        public ISpace2 CleanSpace { get; set; }

        //constructors
        public NavigationMap2()
        {
            _robots = new List<IPhysics2>();
            _myRobot = new Physics2();
            VisibleSpace = new Space2Zero();
            CleanSpace = new Space2Zero();
        }
    }
}
