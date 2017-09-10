using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace RSL.Graphics.Simulation
{
    class DoTick
    {
        private DispatcherTimer _dispatcher;
        public double Time
        {
            set
            {
                if (_dispatcher.Interval.TotalMilliseconds != value)
                {
                    _dispatcher.Interval = TimeSpan.FromMilliseconds(10);
                }
            }
        }

        public DoTick()
        {
            _dispatcher = new DispatcherTimer();
            _dispatcher.Interval = TimeSpan.FromMilliseconds(30);
            _dispatcher.Tick += Do_Tick;
            _dispatcher.Start();
        }
        public void Do_Tick(object sender, EventArgs e)
        {

        }
    }
}
