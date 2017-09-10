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

namespace RSL.Graphics.Generation.Robotics.CognitiveAcceleration.MaximizationFunction
{
    /// <summary>
    /// Логика взаимодействия для MaximizationFunction2ReflectionControl.xaml
    /// </summary>
    public partial class MaximizationFunction2ReflectionControl : UserControl
    {
        public MaximizationFunction2ReflectionControl()
        {
            InitializeComponent();
            var arr = MaximizationFunction2Reflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = MaximizationFunction2Reflection.GetControl(name);
        }
        public IMaximizationFunction2 Generate()
        {
            var res = ContentValue.Content as IMaximizationFunction2Control;
            return res.Generate();
        }
    }
}

