using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Maths.FunctionalVector
{
    public class FunctionalVector2LinearNorm : IFunctionalVector2
    {
        //variables
        private double _dimension;

        //get set variables
        public double Dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }

        //constructors
        public FunctionalVector2LinearNorm()
        {
            Dimension = 1;
        }
        public FunctionalVector2LinearNorm(double dimension)
        {
            Dimension = dimension;
        }


        //methods
        public Vector2 Compute(List<Vector2> array)
        {
           
            double dimension = Dimension;

            double x = 0;
            foreach (Vector2 v in array)
            {
                x += Math.Pow(v.X, dimension);
            }
            x = Math.Pow(x, 1.0 / dimension);

            double y = 0;
            foreach (Vector2 v in array)
            {
                y += Math.Pow(v.Y, dimension);
            }
            y = Math.Pow(y, 1.0 / dimension);

            Vector2 res = new Vector2(x, y);
            return res;
        }
    }
}
