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
    /// Логика взаимодействия для SetPoints2ReflectionControl.xaml
    /// </summary>
    public partial class SetPoints2ReflectionControl : UserControl
    {
        public SetPoints2ReflectionControl()
        {
            InitializeComponent();

            var arr = SetPoints2Reflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = SetPoints2Reflection.GetControl(name);
        }
        public ISetPoints2 Generate()
        {
            return (ContentValue.Content as ISetPoints2Control).Generate();
        }
    }
}
