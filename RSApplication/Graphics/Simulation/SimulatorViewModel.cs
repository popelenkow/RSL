using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RSL.World;
using System.Windows.Threading;

namespace RSL.Graphics.Simulation
{
    public class SimulatorViewModel : ViewModelBase
    {
        private IWorld2 _world;
        private DispatcherTimer _dispatcher;
        private double _speedSimulation;
        private double _samplingTime;
        public double SamplingTime
        {
            get { return _samplingTime; }
            set
            {
                Set(ref _samplingTime, value);
                _dispatcher.Interval = TimeSpan.FromSeconds(_samplingTime);
            }
        }

        public SimulatorViewModel()
        {
            _dispatcher = new DispatcherTimer();
        }
        private void Simulate_Tick(object sender, EventArgs e)
        {
            var w = _world;
            w.Time.Update();
            foreach (var r in w.Map.Robots)
            {
                r.ComputeCognitive();
                r.ComputeMechanical();
            }
        }
    }
}
