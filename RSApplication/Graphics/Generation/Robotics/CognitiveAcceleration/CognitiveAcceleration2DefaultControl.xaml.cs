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
using RSL.Robotics.CognitiveAcceleration;

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration
{
    /// <summary>
    /// Логика взаимодействия для CognitiveAcceleration2DefaultControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2DefaultControl : UserControl, ICognitiveAcceleration2Control
    {
        public CognitiveAcceleration2DefaultControl()
        {
            InitializeComponent();
        }

        public ICognitiveAcceleration2 Generate()
        {
            return new CognitiveAcceleration2Default();
        }
    }
}
