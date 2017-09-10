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
    /// Логика взаимодействия для WorldTimeReflectionControl.xaml
    /// </summary>
    public partial class WorldTimeReflectionControl : UserControl
    {
        public WorldTimeReflectionControl()
        {
            InitializeComponent();

            var arr = WorldTimeReflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = WorldTimeReflection.GetControl(name);
        }

        public IWorldTime Generate()
        {
            return (ContentValue.Content as IWorldTimeControl).Generate();
        }
    }
}
