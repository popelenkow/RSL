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
using RSL.World.Map;
using RSL.Maths.Algebra;

namespace RSL.Graphics.Generation.World.Map
{
    /// <summary>
    /// Логика взаимодействия для WorldMapManagerControl.xaml
    /// </summary>
    public partial class WorldMapManagerControl : UserControl
    {
        public Vector2 Proportions
        {
            get
            {
                Vector2 v = new Vector2
                {
                    X = double.Parse(ProportionsXControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture),
                    Y = double.Parse(ProportionsYControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture)
                };
                return v;
            }
            set
            {
                ProportionsXControl.TextBox.Text = value.X.ToString();
                ProportionsYControl.TextBox.Text = value.Y.ToString();
            }
        }
        public WorldMapManagerControl()
        {
            InitializeComponent();
            //todo
            Proportions = new Vector2(11, 11);
        }
        public IWorldMap2 Generate()
        {
            return new WorldMap2(Proportions);
        }
    }
}
