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
    class AnalyzerAreaConvexHull : IAnalyzer
    {
        private List<DataPoint> _points = new List<DataPoint>();
        public string Name
        {
            get { return "Площадь оболочки"; }
        }

        public List<DataPoint> Points
        {
            get { return _points; }
        }
        public void Compute(IWorld2 world)
        {
            var x = world.Time.CurrentTime;
            double y = 0;
            if (world.Map.Robots.Count > 2)
            {
                List<Vector2> points = new List<Vector2>();
                foreach (var r in world.Map.Robots)
                {
                    points.Add(r.Physics.Position);
                }
                DoPart1(points);
                DoPart2(points);
                DoPart3(points);
                y = ComputeArea(points);
            }
            y = Math.Sqrt(y);
            var p = new DataPoint(x, y);
            Points.Add(p);
        }
        class CmpLeft : IComparer<Vector2>
        {
            public int Compare(Vector2 x, Vector2 y)
            {
                if (x.X < y.X) return -1;
                if (x.X == y.X) return 0;
                return 1;
            }
        }
        private void DoPart1(List<Vector2> points)
        {
            points.Sort(new CmpLeft());
        }
        class CmpRotLeft : IComparer<Vector2>
        {
            public Vector2 PointRot { get; set; }
            public int Compare(Vector2 x, Vector2 y)
            {
                x -= PointRot;
                y -= PointRot;
                Direction2 dx = new Direction2(x);
                Direction2 dy = new Direction2(y);
                Direction2 d = dy - dx;
                d = d.Standardized();
                if (d.Azimuthal > 0) return -1;
                if (d.Azimuthal == 0) return 0;
                return 1;
            }
        }
        private void DoPart2(List<Vector2> points)
        {
            CmpRotLeft cmp = new CmpRotLeft
            {
                PointRot = points[0]
            };
            points.Sort(1, points.Count - 1, cmp);
        }
        private void DoPart3(List<Vector2> points)
        {
            int i = 0;
            for (;;)
            {
                i++;
                if (i == points.Count) return;
                int k = i - 1;
                int j = i + 1;
                if (j == points.Count) j = 0;
                Direction2 d1 = new Direction2(points[i] - points[k]);
                Direction2 d2 = new Direction2(points[j] - points[i]);
                Direction2 d = d2 - d1;
                d = d.Standardized();
                if (d.Azimuthal <= 0)
                {
                    points.RemoveAt(i);
                    i--;
                }
            }
        }
        private double ComputeArea(List<Vector2> points)
        {
            int cnt = points.Count;
            
            Vector2 p1, p2;
            p1 = points[cnt-1];
            p2 = points[0];
            double res = CalcArea(p1, p2);
            for (int i = 0; i < cnt -1; i++)
            {
                p1 = points[i];
                p2 = points[i+1];
                res += CalcArea(p1, p2);
            }
            return Modulus.Absolute( res/2);
        }
        private double CalcArea(Vector2 p1, Vector2 p2)
        {
            double x = p1.X + p2.X;
            double y = p1.Y - p2.Y;
            return x * y;
        }
    }
}
