using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class Logics2 : ILogics2
    {
        //variables
        private Vector2 _goalAcceleration;
        private IGoalPosition2 _goalPosition;
        private ITactic2 _tactic;
        private INavigationMap2 _navigationMap;
        private INavigator2 _navigator;

        //get set variables
        public Vector2 GoalAcceleration
        {
            get { return _goalAcceleration; }
            set { _goalAcceleration = value; }
        }
        public IGoalPosition2 GoalPosition
        {
            get { return _goalPosition; }
            set { _goalPosition = value; }
        }
        public ITactic2 Tactic
        {
            get { return _tactic; }
            set { _tactic = value; }
        }
        public INavigationMap2 NavigationMap
        {
            get { return _navigationMap; }
            set { _navigationMap = value; }
        }
        public INavigator2 Navigator
        {
            get { return _navigator; }
            set { _navigator = value; }
        }

        //constructors
        public Logics2()
        {
            GoalPosition = new GoalPosition2Point();
            Tactic = new Tactic2Default();
            Navigator = new Navigator2Default();
            GoalAcceleration = new Vector2();
        }
        public Logics2(IGoalPosition2 goalPosition, ITactic2 tactic, INavigator2 navigator)
        {
            _goalPosition = goalPosition;
            _tactic = tactic;
            _navigator = navigator;
            _goalAcceleration = new Vector2();
        }
    }
}
