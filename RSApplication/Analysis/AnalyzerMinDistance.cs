using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RSL.World;

namespace RSL.Analysis
{
    class AnalyzerMinDistance : IAnalyzer
    {
        private List<DataPoint> _points = new List<DataPoint>();
        public string Name
        {
            get { return "Расстояние между роботами"; }
        }

        public List<DataPoint> Points
        {
            get { return _points; }
        }
        public void Compute(IWorld2 world)
        {
            var robots = world.Map.Robots;
            var x = world.Time.CurrentTime;
            double y = world.Map.Dimension.Magnitude();
            foreach (var r1 in robots)
            {
                foreach (var r2 in robots)
                {
                    if (r1 != r2)
                    {
                        double yy = (r1.Physics.Position - r2.Physics.Position).Magnitude();
                        y = Math.Min(yy, y);
                    }
                    
                }
            }

            var p = new DataPoint(x, y);
            Points.Add(p);
        }
    }
}
