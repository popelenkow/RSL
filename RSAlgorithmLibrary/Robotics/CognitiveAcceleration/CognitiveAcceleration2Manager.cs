using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Maths.FunctionalVector;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.CognitiveAcceleration
{
    public sealed class CognitiveManager2 : ICognitiveAcceleration2Manager
    {
        //variables
        private List<ICognitiveAcceleration2> _array;
        private IFunctionalVector2 _adderAcceleration;

        //get set variables
        public List<ICognitiveAcceleration2> Array
        {
            get{ return _array; }
            set { _array = value; }
        }
        public IFunctionalVector2 AdderAcceleration
        {
            get { return _adderAcceleration; }
            set { _adderAcceleration = value; }
        }
        //constructors
        public CognitiveManager2()
        {
            Array = new List<ICognitiveAcceleration2>();
            AdderAcceleration = new FunctionalVector2Default();
        }
        public CognitiveManager2(List<ICognitiveAcceleration2> array, IFunctionalVector2 adderAcceleration)
        {
            Array = array;
            AdderAcceleration = adderAcceleration;
        }

        //methods
        public Vector2 ComputeAcceleration(ILogics2 logics, IPhysics2 physics)
        {
            List<Vector2> arrValue = new List<Vector2>(_array.Count);

            for (int i = 0; i < _array.Count; i++)
            {
                arrValue.Add(_array[i].ComputeAcceleration(logics, physics));
            }

            Vector2 res = _adderAcceleration.Compute(arrValue);

            return res;
        }
    }
}
