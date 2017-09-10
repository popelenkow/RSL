using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.CognitiveAcceleration
{
    public class CognitiveAcceleration2RepulsionSimple : ICognitiveAcceleration2
    {
        public double Range { get; set; }
        public double SamplingAngle { get; set; }
        public double Force { get; set; }
        public double DisableGoalRange { get; set; }

        public Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics)
        {
            double a = SamplingAngle;
            int aa = (int)Math.Ceiling( 360.0 / a);

            List<Vector2> acc = new List<Vector2>();
            for (int i = 0; i < aa; i++)
            {
                var dir = new Direction2(i * a);
                var dis = logics.Tactic.СomputeDistance(dir, logics.NavigationMap);
                
                //if (double.IsInfinity(dis.CleanRange)) continue;

                if (dis.CleanRange < Range)
                {
                    dis.CleanRange = Math.Max(dis.CleanRange, Range * 0.01);
                    var m = 1 - Range / dis.CleanRange;
                    acc.Add(dir.CreateVector2(m*Force));
                }
            }
            Vector2 res = new Vector2();

            if (logics.GoalPosition.ComputeDestination().Magnitude() < DisableGoalRange) return res;
            if (acc.Count == 0) return res;

            foreach (var v in acc)
            {
                res += v;
            }
            res /= acc.Count;
            return res;
        }
    }
}
