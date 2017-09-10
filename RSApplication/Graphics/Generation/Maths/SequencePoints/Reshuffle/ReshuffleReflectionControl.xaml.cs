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
using RSL.Maths.SequencePoints.Reshuffle;
using RSL.Maths.Algebra;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Reshuffle
{
    /// <summary>
    /// Логика взаимодействия для ReshuffleReflectionControl.xaml
    /// </summary>
    public partial class ReshuffleReflectionControl : UserControl
    {
        public ReshuffleReflectionControl()
        {
            InitializeComponent();

            var arr = ReshuffleReflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = ReshuffleReflection.GetControl(name);
        }

        public IReshuffle<Vector2> Generate()
        {
            return (ContentValue.Content as IReshuffleControl).Generate();
        }
    }
}
