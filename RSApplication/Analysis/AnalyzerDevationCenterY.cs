using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RSL.World;
using RSL.Maths.Algebra;

namespace RSL.Analysis
{
    class AnalyzerDevationCenterY : IAnalyzer
    {
        private List<DataPoint> _points = new List<DataPoint>();
        public string Name
        {
            get { return "Отклонение от Y"; }
        }

        public List<DataPoint> Points
        {
            get { return _points; }
        }
        public void Compute(IWorld2 world)
        {
            var robots = world.Map.Robots;
            var x = world.Time.CurrentTime;
            double center = 0;
            foreach (var r in robots)
            {
                center += r.Physics.Position.Y;
            }
            center /= robots.Count;
            double y = 0;
            foreach (var r in robots)
            {
                y += Modulus.Absolute(center - r.Physics.Position.Y);
            }
            y /= robots.Count;
            var p = new DataPoint(x, y);
            Points.Add(p);
        }
    }
}
