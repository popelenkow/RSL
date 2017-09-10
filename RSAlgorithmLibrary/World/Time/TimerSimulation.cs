using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.World.Time
{
    public sealed class TimerSimulation : ITimer
    {
        //variables
        private IWorldTime _worldTime;
        private double _timeCur;
        private double _deltaTime;
        private double _samplingRate;
        private IDataSamplingRate _dataSamplingRate;

        //get set variables
        public double CurrentTime
        {
            get
            {
                return _worldTime.CurrentTime;
            }

        }
        public double SamplingRate
        {
            get
            {
                return _samplingRate;
            }
        }
        public IDataSamplingRate DataSamplingRate
        {
            get
            {
                return _dataSamplingRate;
            }
            set
            {
                _dataSamplingRate = value;
            }
        }

        //constructors
        public TimerSimulation(IWorldTime worldTime, double samplingRate)
        {
            _worldTime = worldTime;
            _timeCur = _worldTime.CurrentTime;
            _samplingRate = samplingRate;
            _deltaTime = 0;
            _dataSamplingRate = new DataSamplingRateNone();
        }
        public TimerSimulation(IWorldTime worldTime, double samplingRate, IDataSamplingRate dataSamplingRate)
        {
            _worldTime = worldTime;
            _timeCur = _worldTime.CurrentTime;
            _samplingRate = samplingRate;
            _deltaTime = 0;
            _dataSamplingRate = dataSamplingRate;
        }

        //methods
        public int Reset()
        {
            return Reset(_samplingRate);
        }

        public int Reset(double samplingRate)
        {
            int res = CountTick();
            _samplingRate = samplingRate;
            _deltaTime = 0;
            return res;
        }
        public double CountDeltaTime()
        {
            int tick = CountTick();
            return tick * SamplingRate;
        }
        public int CountTick()
        {
            double old = _timeCur;
            _timeCur = _worldTime.CurrentTime;

            _deltaTime += _timeCur - old;
            double count = Math.Floor(_deltaTime / _samplingRate);
            _deltaTime -= count * _samplingRate;

            return (int)count;
        }
    }
}
