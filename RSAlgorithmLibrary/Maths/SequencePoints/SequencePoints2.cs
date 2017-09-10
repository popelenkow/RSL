using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Maths.SequencePoints.Reshuffle;
using RSL.Maths.SequencePoints.Set;

namespace RSL.Maths.SequencePoints
{
    public class SequencePoints2 : ISequencePoints2
    {
        private ISetPoints2 _setPoints;
        private IEnumerable<IReshuffle<Vector2>> _arrReshuffle;
        
        public ISetPoints2 SetPoints
        {
            get { return _setPoints; }
            set { _setPoints = value; }
        }
        public IEnumerable<IReshuffle<Vector2>> ArrayReshuffle
        {
            get { return _arrReshuffle; }
            set { _arrReshuffle = value; }
        }

        public SequencePoints2()
        {
            SetPoints = new SetPoints2Default();
            ArrayReshuffle = new List<IReshuffle<Vector2>>();
        }
        public SequencePoints2(ISetPoints2 set, IEnumerable<IReshuffle<Vector2>> arrReshuffle)
        {
            SetPoints = set;
            ArrayReshuffle = arrReshuffle;
        }

        public List<Vector2> Create(int count)
        {
            List<Vector2> seq = SetPoints.Create(count);

            foreach (var reshuffle in ArrayReshuffle)
            {
                seq = reshuffle.Shuffle(seq);
            }

            return seq;
        }
    }
}
