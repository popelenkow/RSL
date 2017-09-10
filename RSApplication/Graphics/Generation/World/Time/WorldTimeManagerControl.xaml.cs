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
using RSL.World.Time;

namespace RSL.Graphics.Generation.World.Time
{
    /// <summary>
    /// Логика взаимодействия для WorldTimeManagerControl.xaml
    /// </summary>
    public partial class WorldTimeManagerControl : UserControl
    {
        public WorldTimeManagerControl()
        {
            InitializeComponent();
        }
        public IWorldTime Generate()
        {
            return ReflectionControl.Generate();
        }
    }
}
