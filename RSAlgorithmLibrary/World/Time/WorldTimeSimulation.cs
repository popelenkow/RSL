using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace RSL.World.Time
{
    public sealed class WorldTimeSimulation : IWorldTime
    {
        //variables
        private double _timeCur;
        private double _speedWorld;
        private bool _isFrozen;
        private Stopwatch _watch;
        private double _oldWatch;

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
                if (_isFrozen == value) return;

                if (value == true)
                {
                    Stop();
                }
                else
                {
                    Start();
                }
                _isFrozen = value;
            }
        }

        

        //constructors
        public WorldTimeSimulation(double speedWorld = 1.0)
        {
            _speedWorld = speedWorld;
            _isFrozen = true;
            _timeCur = 0.0;
            _watch = new Stopwatch();
        }

        //methods
        public void Update()
        {
            if (!Frozen)
            {
                UpdateCurrentTime();
            }
        }
        private void Stop()
        {
            UpdateCurrentTime();
            _watch.Reset();
        }
        private void Start()
        {
            _watch.Start();
            ComputeDeltaTime();
        }

        private void UpdateCurrentTime()
        {
            double delta = ComputeDeltaTime();
            _timeCur += delta * _speedWorld;
        }
        private double ComputeDeltaTime()
        {
            double old = _oldWatch;
            TimeSpan elapsed = _watch.Elapsed;
            _oldWatch = elapsed.TotalSeconds;
            return _oldWatch - old;
        }
    }
}
