using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RSL.Graphics.Generation.Robotics.CognitiveAcceleration;
using RSL.Graphics.Generation.Robotics.MechanicalAcceleration;
using RSL.Robotics;
using RSL.Graphics.Generation.Robotics.PhysicalCharacteristics;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;
using RSL.Maths.Algebra;
using RSL.World;

namespace RSL.Graphics.Generation.Robotics
{
    /// <summary>
    /// Логика взаимодействия для RoboticsControl.xaml
    /// </summary>
    public partial class RoboticsControl : UserControl
    {

        public RoboticsControl()
        {
            InitializeComponent();
        }
        public List<IRobot2> Generate(IWorld2 world)
        {
            var res = new List<IRobot2>();
            var count = NumberRobot.Generate();

            var curPos = CurrentPosition.Generate(count);
            var goalPos = GoalPosition.Generate(count);
            for (int i = 0; i < count; i++)
            {
                var physics = new Physics2
                {
                    Course = new Direction2(),
                    Name = i.ToString(),
                    Position = curPos[i],
                    Proportions = RobotPropotions.Generate(),
                    Velocity = new Vector2()
                };
                
                var goalP = new GoalPosition2Point
                {
                    GoalPoint = goalPos[i],
                    Physics = physics
                };
                var navigator = new Navigator2SimulationUnlimited
                {
                    MyPhysicsRobot = physics,
                    WorldMap = world.Map
                };
                var logics = new Logics2
                {
                    GoalPosition = goalP,
                    Navigator = navigator,
                    Tactic = new Tactic2Static()
                };
                var robot = new Robot2Simulation
                {
                    CognitiveManager = CognitiveAcceleration2Manager.Generate(),
                    MechanicalManager = MechanicalAcceleration2Manager.Generate(),
                    Logics = logics,
                    Physics = physics,
                    CognitiveTimer = CognitiveTimer.Generate(world.Time),
                    MechanicalTimer = MechanicalTimer.Generate(world.Time)
                };
                res.Add(robot);
            }
            return res;
            
        }
    }
}
