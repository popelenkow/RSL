using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Wpf;
using RSL.World;
using System.Windows.Threading;
using RSL.Analysis;

namespace RSL.Graphics.Simulation
{
    /// <summary>
    /// Логика взаимодействия для GraphControl.xaml
    /// </summary>
    public partial class GraphControl : UserControl
    {
        private IWorld2 World;
        private DispatcherTimer _dispatcherCalc;
        private DispatcherTimer _dispatcherPlot;

        private List<IAnalyzer> _arrayAnalyzer = new List<IAnalyzer>();
        public List<IAnalyzer> ArrayAnalyzer
        {
            get { return _arrayAnalyzer; }
            set { _arrayAnalyzer = value; }
        }

        public GraphControl()
        {
            InitializeComponent();
      
                _dispatcherCalc = new DispatcherTimer();
                _dispatcherCalc.Interval = TimeSpan.FromMilliseconds(300);
                _dispatcherCalc.Tick += Calc_Tick;
                _dispatcherCalc.Start();

            _dispatcherPlot = new DispatcherTimer();
            _dispatcherPlot.Interval = TimeSpan.FromSeconds(3);
            _dispatcherPlot.Tick += Plot_Tick;
            _dispatcherPlot.Start();
        }

        public void Calc_Tick(object sender, EventArgs e)
        {
            Calc();
        }
        public void Plot_Tick(object sender, EventArgs e)
        {
            Plot.InvalidatePlot();
        }
        public void Calc()
        {
            IWorld2 w = World;
            if (w == null) return;
            if (w.Time.Frozen) return;
            foreach (var a in _arrayAnalyzer)
            {
                a.Compute(w);
            }
        }

        public void Update(IWorld2 w)
        {
            var aa = Application.Current.Resources["GlobalAnalysis"] as List<IAnalyzer>;
            if (aa == null) return;
            if (World != w || aa != _arrayAnalyzer)
            {
                World = w;
                _arrayAnalyzer = aa;

                Plot.Series.Clear();

                foreach (var a in _arrayAnalyzer)
                {
                    LineSeries s;
                    s = new LineSeries
                    {
                        ItemsSource = a.Points,
                        Title = a.Name
                    };
                    Plot.Series.Add(s);
                }
            }
        }

    }
}
