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
using RSL.Graphics.Generation.World.Time;
using RSL.World;

namespace RSL.Graphics.Generation.World
{
    /// <summary>
    /// Логика взаимодействия для WorldControl.xaml
    /// </summary>
    public partial class WorldControl : UserControl
    {
        public WorldControl()
        {
            InitializeComponent();
        }
        public IWorld2 Generate()
        {
            return new World2
            {
                Map = WorldMap.Generate(),
                Time = WorldTime.Generate()
            };
        }
    }
}
