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
using RSL.Maths.SequencePoints.Set;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Set
{
    /// <summary>
    /// Логика взаимодействия для SetPoints2DefaultControl.xaml
    /// </summary>
    public partial class SetPoints2DefaultControl : UserControl, ISetPoints2Control
    {
        public SetPoints2DefaultControl()
        {
            InitializeComponent();
        }

        public ISetPoints2 Generate()
        {
            return new SetPoints2Default();
        }
    }
}
