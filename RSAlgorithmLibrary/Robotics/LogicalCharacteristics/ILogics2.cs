using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.LogicalCharacteristics
{
    public interface ILogics2
    {
        Vector2 GoalAcceleration { get; set; }
        IGoalPosition2 GoalPosition { get; set; }
        ITactic2 Tactic { get; set; }
        INavigationMap2 NavigationMap { get; set; }
        INavigator2 Navigator { get; set; }
    }
}
