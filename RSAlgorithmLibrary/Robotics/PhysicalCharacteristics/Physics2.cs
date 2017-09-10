using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSL.Maths.Algebra;

namespace RSL.Robotics.PhysicalCharacteristics
{
    public sealed class Physics2 : IPhysics2
    {
        //variables
        private double _proportions;
        private string _name;
        private Vector2 _position;
        private Vector2 _velocity;
        private Direction2 _course;

        //get set variables
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Direction2 Course
        {
            get { return _course; }
            set { _course = value; }
        }
        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }
        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public double Proportions
        {
            get { return _proportions; }
            set { _proportions = value; }
        }


        //constructors
        public Physics2()
        {
            Proportions = 1;
            Name = "Name";
            Position = new Vector2();
            Velocity = new Vector2();
            Course = new Direction2();
        }
        public Physics2(double proportions, string name, Vector2 position, Vector2 velocity, Direction2 course)
        {
            Proportions = proportions;
            Name = name;
            Position = position;
            Velocity = velocity;
            Course = course;
        }
    }
}
