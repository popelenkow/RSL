using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.SequencePoints;
using RSL.Maths.Algebra;
using RSL.Maths.SequencePoints.Reshuffle;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle
{
    public interface IReshuffleControl
    {
        IReshuffle<Vector2> Generate();
    }
}
