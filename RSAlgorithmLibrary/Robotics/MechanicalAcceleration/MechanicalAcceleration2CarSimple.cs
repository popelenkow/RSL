using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;
using RSL.Robotics.LogicalCharacteristics;
using RSL.Robotics.PhysicalCharacteristics;

namespace RSL.Robotics.MechanicalAcceleration
{
    public sealed class MechanicalAcceleration2CarSimple : IMechanicalAcceleration2
    {
        //variables
        private double _maxAngularVelocity;
        private double _maxSpeedVelocity;
        private double _maxSpeed = 50;
        private double _maxAngle = 90;
        //get set variables
        public double MaxAngularVelocity
        {
            get { return _maxAngularVelocity; }
            set { _maxAngularVelocity = value; }
        }
        public double MaxSpeedVelocity
        {
            get { return _maxSpeedVelocity; }
            set { _maxSpeedVelocity = value; }
        }
        public double MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
        public double MaxAngle
        {
            get { return _maxAngle; }
            set { _maxAngle = value; }
        }
        //methods
        /*
        public Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            var vNew = ComputeVelocity(deltaTime, logics, physics);
            return new Direction2(vNew);
        }

        public Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            var vOld = physics.Vector2;
            var vNew = ComputeVelocity(deltaTime, logics, physics);
            return physics.Position + (vNew + vOld) / 2;
        }

        public Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {

            var vCur = new SphericalVector2(physics.Vector2);
            var vGoal = new SphericalVector2(logics.GoalAcceleration* deltaTime) + vCur;
            SphericalVector2 res = new SphericalVector2();
            {
                double sign = Modulus.Sign(Multiplier.Dot2(vGoal, vCur));
                double deltaSpeed = Modulus.Absolute(vGoal.Radius - sign * vCur.Radius);
                double speedVelocity = Math.Min((deltaSpeed / deltaTime), MaxSpeedVelocity);
                res.Radius = speedVelocity * sign + vCur.Radius;
            }
            {
                double deltaAngle = (vGoal.Direction - vCur.Direction).Standardized().Azimuthal;
                double sign = Modulus.Sign(deltaAngle);
                deltaAngle *= sign;
                double angularVelocity = Math.Min((deltaAngle / deltaTime), MaxAngularVelocity);
                res.Direction = vCur.Direction + new Direction2(angularVelocity * deltaTime);
            }
            
            return res.CreateVector2();
        }
        */
        public Direction2 ComputeCourse(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            Direction2 aV = CalculateAngularVelocity(deltaTime, logics, physics);
            var c = physics.Course + aV * deltaTime;
            return c.Standardized();
        }

        public Vector2 ComputePosition(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            var vOld = physics.Velocity;
            var vNew = ComputeVelocity(deltaTime, logics, physics);
            return physics.Position + (vNew + vOld)*deltaTime / 2;
        }
        

        public Vector2 ComputeVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            Direction2 aV = CalculateAngularVelocity(deltaTime, logics, physics);
            double sV = CalculateSpeedVelocity(deltaTime, logics, physics);
            SphericalVector2 v = new SphericalVector2(physics.Velocity);
            v.Radius = CalculateSmartSpeed(deltaTime, sV, v.Radius);
            v.Direction = physics.Course + aV * deltaTime;
            return v.CreateVector2();
        }
        Direction2 CalculateAngularVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            var goalAcceleration = logics.GoalAcceleration;
            var curDir = physics.Course;
            var goalDir = new Direction2(goalAcceleration);
            var rot = (goalDir - curDir).Standardized() / deltaTime;
            var rotAbs = new Direction2(Modulus.Absolute(rot.Azimuthal));
            var rotSign = Modulus.Sign(rot.Azimuthal);
            var rotAbsMin = new Direction2(Math.Min(_maxAngularVelocity, rotAbs.Azimuthal));
            return rotAbsMin * rotSign;
        }
        double CalculateSpeedVelocity(double deltaTime, ILogics2 logics, IPhysics2 physics)
        {
            var goalAcceleration = logics.GoalAcceleration;
            var cos = CalculateCosSpeed(logics, physics);
            var speedVelocity = goalAcceleration.Magnitude() * cos;
            var sign = Modulus.Sign(speedVelocity);
            var speedVelocityAbsolute = Math.Min(speedVelocity * sign, _maxSpeedVelocity);
            return speedVelocityAbsolute * sign;
        }
        double CalculateCosSpeed(ILogics2 logics, IPhysics2 physics)
        {
            var curDir = physics.Course;
            var goalAcceleration = new SphericalVector2(logics.GoalAcceleration);
            var angle = (goalAcceleration.Direction - curDir).Standardized();
            var angleAbs = Modulus.Absolute(angle.Azimuthal);
            if (angleAbs > _maxAngle) angleAbs = _maxAngle;
            angleAbs = angleAbs / _maxAngle * Constants.PI;
            var cos = Math.Cos(angleAbs);
            return cos;
        }
        double CalculateSmartSpeed(double deltaTime, double speedVelocity, double speed)
        {
            if (speedVelocity < 0)
            {
                speed += speedVelocity * deltaTime * _maxSpeed * 1.3 / (_maxSpeed * 0.3 + speed);
                if (speed < 0) speed = 0;                
            }
            else
            {
                speed += speedVelocity * deltaTime * (_maxSpeed -speed) / _maxSpeed;
            }
            return speed;
        }
    }
}
