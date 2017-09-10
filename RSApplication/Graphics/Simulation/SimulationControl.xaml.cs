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
using RSL.World;
using System.Windows.Threading;
using System.IO;


namespace RSL.Graphics.Simulation
{
    /// <summary>
    /// Логика взаимодействия для SimulationControl.xaml
    /// </summary>
    public partial class SimulationControl : UserControl
    {
        private IWorld2 w;
        private DispatcherTimer _dispatcher;



        public SimulationControl()
        {
            InitializeComponent();
            _dispatcher = new DispatcherTimer();
            _dispatcher.Interval = TimeSpan.FromMilliseconds(10);
            _dispatcher.Tick += Simulate_Tick;
            _dispatcher.Start();
        }
        private void Simulate_Tick(object sender, EventArgs e)
        {
            var ww = Application.Current.Resources["GlobalWorld"] as IWorld2;
           
            if (ww != w)
            {
                w = ww;
                _dispatcher.Interval = TimeSpan.FromMilliseconds(10/w.Time.SpeedWorld);
            }
            UpdateSimulation(w);
            Picture.Update(w);
            Graph.Update(w);
        }
        public void UpdateSimulation(IWorld2 w)
        {
            w.Time.Update();
            foreach (var r in w.Map.Robots)
            {
                r.ComputeCognitive();
                r.ComputeMechanical();
            }
        }
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            w.Time.Frozen = false;

        }
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            w.Time.Frozen = true;
        }

        private static string _pathProject = Directory.GetCurrentDirectory() + "\\Analysis\\";
        private static string _pathFileNextDirectory = _pathProject + "NextDirectory.txt";
        private string _pathDirectory;

        private void Save_Click(object sender, RoutedEventArgs e)
        {


            ReadPathDirectory();
            CreateDirectory();

            foreach (var a in Graph.ArrayAnalyzer)
            {
                StringBuilder text = new StringBuilder();
                foreach (var p in a.Points)
                {
                    //text.AppendLine("Время: " + d.Time.ToString() + " Отклонение: " + d.Data.ToString());
                    text.AppendLine(p.X.ToString());
                    text.AppendLine(p.Y.ToString());
                }
                File.WriteAllText(_pathDirectory + a.Name +".txt", text.ToString());
            }

        }
        void ReadPathDirectory()
        {
            int n = Convert.ToInt32(File.ReadAllText(_pathFileNextDirectory));
            File.WriteAllText(_pathFileNextDirectory, (n + 1).ToString());
            _pathDirectory = _pathProject + n.ToString() + "\\";
        }
        void CreateDirectory()
        {
            Directory.CreateDirectory(_pathDirectory);
        }
    }
}
