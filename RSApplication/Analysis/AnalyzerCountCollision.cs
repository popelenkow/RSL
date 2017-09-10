using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using RSL.World;
using RSL.Robotics;

namespace RSL.Analysis
{
    class AnalyzerCountCollision : IAnalyzer
    {
        struct PairCol
        {
            public int R1;
            public int R2;
            public static bool operator==(PairCol p1, PairCol p2)
            {
                if (p1.R1 == p2.R1 && p1.R2 == p2.R2) return true;
                return false;
            }
            public static bool operator!=(PairCol p1, PairCol p2)
            {
                return !(p1 == p2);
            }
        }
        private List<DataPoint> _points = new List<DataPoint>();
        public string Name
        {
            get { return "Количество столкновений"; }
        }

        public List<DataPoint> Points
        {
            get { return _points; }
        }

        public AnalyzerCountCollision()
        {
            Points.Add(new DataPoint(0, 0));
        }

        private List<PairCol> _pairs = new List<PairCol>();

        public void Compute(IWorld2 world)
        {
            var x = world.Time.CurrentTime;
            double y = _points.Last().Y;
            var rs = world.Map.Robots;
            var ps = new List<PairCol>();
            for (int i = 0; i < rs.Count; i++)
            {
                for (int j = i+1; j < rs.Count; j++)
                {
                    if (IsCollition(rs[i], rs[j]))
                    {
                        var pair = new PairCol
                        {
                            R1 = i,
                            R2 = j
                        };

                        bool isCol = true;
                        foreach (var oldPair in _pairs)
                        {
                            if (oldPair == pair)
                            {
                                isCol = false;
                                break;
                            }
                        }
                        ps.Add(pair);
                        if (isCol) y++;
                    }
                    
                }
            }
            _pairs = ps;
            var p = new DataPoint(x, y);
            Points.Add(p);
        }
        private bool IsCollition(IRobot2 r1, IRobot2 r2)
        {
            double dist = (r1.Physics.Position - r2.Physics.Position).Magnitude();
            double minDist = r1.Physics.Proportions + r2.Physics.Proportions;
            if (dist <= minDist) return true;
            return false;
        }
    }
}
