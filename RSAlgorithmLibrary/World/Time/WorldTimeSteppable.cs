using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public sealed class WorldTimeSteppable : IWorldTime
    {
        //variables
        private double _timeCur;
        private bool _isFrozen;
        private double _samplingTime;
        private double _speedWorld;
        //get set variables
        public double CurrentTime
        {
            get
            {
                return _timeCur;
            }
        }

        public double SpeedWorld
        {
            get
            {
                return _speedWorld;
            }
            set
            {
                if (value < 0)
                {
                    _speedWorld = 0;
                }
                else
                {
                    _speedWorld = value;
                }
            }
        }
        public bool Frozen
        {
            get
            {
                return _isFrozen;
            }
            set
            {
                _isFrozen = value;
            }
        }


        //constructors
        public WorldTimeSteppable(double samplingTime)
        {
            _isFrozen = true;
            _timeCur = 0.0;
            _speedWorld = 1.0;
            _samplingTime = samplingTime;
        }

        //methods
        public void Update()
        {
            if (!Frozen)
            {
                UpdateCurrentTime();
            }
        }

        private void UpdateCurrentTime()
        {
            double delta = _samplingTime;
            _timeCur += delta * _speedWorld;
        }
    }
}
