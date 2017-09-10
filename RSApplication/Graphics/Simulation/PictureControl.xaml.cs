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

namespace RSL.Graphics.Simulation
{
    /// <summary>
    /// Логика взаимодействия для PictureControl.xaml
    /// </summary>
    public partial class PictureControl : UserControl
    {
        private IWorld2 World;
        private DispatcherTimer _dispatcher;



        private List<RobotControl> _robots = new List<RobotControl>();

        public PictureControl()
        {
            InitializeComponent();

            _dispatcher = new DispatcherTimer();
            _dispatcher.Interval = TimeSpan.FromMilliseconds(30);
            _dispatcher.Tick += Do_Tick;
            _dispatcher.Start();
        }

        public void Do_Tick(object sender, EventArgs e)
        {
            UpdateSimulation(World);
        }

        public void Update(IWorld2 w)
        {
            UpdatePicture(w);
            
        }
        private void UpdatePicture(IWorld2 w)
        {
            if (World != w)
            {
                World = w;
                Picture.Width = w.Map.Dimension.X;
                Picture.Height = w.Map.Dimension.Y;
                _robots = new List<RobotControl>();
                foreach (var r in w.Map.Robots)
                {
                    var rc = new RobotControl(r);
                    _robots.Add(rc);
                }
                var ch = Picture.Children;
                ch.Clear();
                foreach(var r in _robots)
                {
                    ch.Add(r);
                }
            }
        }
        private void UpdateSimulation(IWorld2 w)
        {
            for (int i = 0; i < _robots.Count; i++)
            {
                _robots[i].Update(w.Map.Robots[i]);
            }
        }
        
    }
}
