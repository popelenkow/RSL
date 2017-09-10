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
    /// Логика взаимодействия для CognitiveAcceleration2ReflectionControl.xaml
    /// </summary>
    public partial class CognitiveAcceleration2ReflectionControl : UserControl
    {
        public CognitiveAcceleration2ReflectionControl()
        {
            InitializeComponent();

            var arr = CognitiveAcceleration2Reflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
            
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = CognitiveAcceleration2Reflection.GetControl(name);
        }
        public ICognitiveAcceleration2 Generate()
        {
            return (ContentValue.Content as ICognitiveAcceleration2Control).Generate();
        }
    }
}
