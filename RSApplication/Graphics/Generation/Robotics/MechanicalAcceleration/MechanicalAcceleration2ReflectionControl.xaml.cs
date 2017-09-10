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
using RSL.Robotics.MechanicalAcceleration;

namespace RSL.Graphics.Generation.Robotics.MechanicalAcceleration
{
    /// <summary>
    /// Логика взаимодействия для MechanicalAcceleration2ReflectionControl.xaml
    /// </summary>
    public partial class MechanicalAcceleration2ReflectionControl : UserControl
    {
        public MechanicalAcceleration2ReflectionControl()
        {
            InitializeComponent();

            var arr = MechanicalAcceleration2Reflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = MechanicalAcceleration2Reflection.GetControl(name);
        }
        public IMechanicalAcceleration2 Generate()
        {
            return (ContentValue.Content as IMechanicalAcceleration2Control).Generate();
        }
    }
}
