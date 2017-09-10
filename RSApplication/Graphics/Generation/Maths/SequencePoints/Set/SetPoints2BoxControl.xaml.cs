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
    /// Логика взаимодействия для SetPoints2BoxControl.xaml
    /// </summary>
    public partial class SetPoints2BoxControl : UserControl
    {
        public SetPoints2BoxControl()
        {
            InitializeComponent();
        }
        public ISetPoints2 Generate()
        {
            return (Box.ContentValue as SetPoints2ReflectionControl).Generate();
        }
    }
}
