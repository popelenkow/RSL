using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.SequencePoints.Reshuffle
{
    public sealed class ReshuffleShift<T> : IReshuffle<T>
    {
        //variables
        public int PosShift;

        //constructors
        public ReshuffleShift(int posShift = 1)
        {
            PosShift = posShift;
        }

        //methods
        public List<T> Shuffle(List<T> array)
        {
            int shift = PosShift;

            List<T> res = new List<T>(new T[array.Count]);

            int newPos, oldPos;
            for (int i = 0; i < array.Count; i++)
            {
                oldPos = i;
                newPos = i + shift;
                newPos = Periodised(newPos, array.Count);
                res[newPos] = array[oldPos];
            }

            return res;
        }
        private int Periodised(int value, int maxCount)
        {
            double res = Period.Calculate(value, 0.0, maxCount);
            return (int)Math.Round(res);
        }
    }
}
