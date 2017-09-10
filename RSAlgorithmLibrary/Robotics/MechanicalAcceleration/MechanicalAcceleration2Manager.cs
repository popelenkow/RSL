using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Maths.FunctionalVector;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.MechanicalAcceleration
{
    public sealed class MechanicalAcceleration2Manager : IMechanicalManager2
    {
        //variables
        private List<IMechanicalAcceleration2> _array;
        private IFunctionalVector2 _adderPosition;
        private IFunctionalVector2 _adderVelocity;
        private IFunctionalVector2 _adderCourse;

        //get set variables
        public List<IMechanicalAcceleration2> Array
        {
            get { return _array; }
            set { _array = value; }
        }
        public IFunctionalVector2 AdderPosition
        {
            get { return _adderPosition; }
            set { _adderPosition = value; }
        }
        public IFunctionalVector2 AdderVelocity
        {
            get { return _adderVelocity; }
            set { _adderVelocity = value; }
        }
        public IFunctionalVector2 AdderCourse
        {
            get { return _adderCourse; }
            set { _adderCourse = value; }
        }
        //constructors
        public MechanicalAcceleration2Manager()
        {
            Array = new List<IMechanicalAcceleration2>();
            AdderPosition = new FunctionalVector2Default();
            AdderVelocity = new FunctionalVector2Default();
            AdderCourse = new FunctionalVector2Default();
        }
        public MechanicalAcceleration2Manager(List<IMechanicalAcceleration2> array,
            IFunctionalVector2 adderPosition, IFunctionalVector2 adderVelocity, IFunctionalVector2 adderCourse)
        {
            Array = array;
            AdderPosition = adderPosition;
            AdderVelocity = adderVelocity;
            AdderCourse = adderCourse;
        }

        //methods
        public Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            List<Vector2> arrValue = new List<Vector2>(_array.Count);

            for (int i = 0; i < _array.Count; i++)
            {
                arrValue.Add(_array[i].ComputePosition(deltaTime, logics, physics));
            }

            Vector2 res = _adderPosition.Compute(arrValue);

            return res;
        }
        public Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            List<Vector2> arrValue = new List<Vector2>(_array.Count);

            for (int i = 0; i < _array.Count; i++)
            {
                arrValue.Add(_array[i].ComputeVelocity(deltaTime, logics, physics));
            }

            Vector2 res = _adderVelocity.Compute(arrValue);

            return res;
        }
        public Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            List<Vector2> arrValue = new List<Vector2>(_array.Count);

            for (int i = 0; i < _array.Count; i++)
            {
                Direction2 val = _array[i].ComputeCourse(deltaTime, logics, physics);
                arrValue.Add(val.CreateVector2());
            }

            Vector2 res = _adderCourse.Compute(arrValue);

            return new Direction2(res);
        }
    }
}
