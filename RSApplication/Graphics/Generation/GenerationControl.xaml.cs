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
using RSL.Analysis;

namespace RSL.Graphics.Generation
{
    /// <summary>
    /// Логика взаимодействия для GenerationControl.xaml
    /// </summary>
    public partial class GenerationControl : UserControl
    {
        public GenerationControl()
        {
            InitializeComponent();
            Application.Current.Resources["GlobalWorld"] = new World2();
            Application.Current.Resources["GlobalAnalysis"] = new List<IAnalyzer>();
        }

        public void Generate()
        {
            var world = World.Generate();
            var robots = Robotics.Generate(world);
            world.Map.Robots = robots;
            Application.Current.Resources["GlobalWorld"] = world;
            var a = Analysis.Generate();
            Application.Current.Resources["GlobalAnalysis"] = a;
        }

        private void GenerateButton(object sender, RoutedEventArgs e)
        {
            Generate();
        }
       
       
    }
}
