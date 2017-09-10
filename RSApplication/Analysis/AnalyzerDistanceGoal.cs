using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RSL.World;

namespace RSL.Analysis
{
    class AnalyzerDistanceGoal : IAnalyzer
    {
        private List<DataPoint> _points = new List<DataPoint>();
        public string Name
        {
            get { return "Расстояние до цели";  }
        }

        public List<DataPoint> Points
        {
            get { return _points; }
        }
        public void Compute(IWorld2 world)
        {
            var robots = world.Map.Robots;
            var x = world.Time.CurrentTime;
            double y = 0;
            foreach (var r in robots)
            {
                y += r.Logics.GoalPosition.ComputeDestination().Magnitude();
            }
            y /= robots.Count;
            var p = new DataPoint(x, y);
            Points.Add(p);
        }
    }
}
