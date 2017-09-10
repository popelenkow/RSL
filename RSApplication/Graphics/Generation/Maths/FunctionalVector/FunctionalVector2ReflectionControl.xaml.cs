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
using RSL.Maths.FunctionalVector;

namespace RSL.Graphics.Generation.Maths.FunctionalVector
{
    /// <summary>
    /// Логика взаимодействия для FunctionalVector2ReflectionControl.xaml
    /// </summary>
    public partial class FunctionalVector2ReflectionControl : UserControl
    {
        public FunctionalVector2ReflectionControl()
        {
            InitializeComponent();

            var arr = FunctionalVector2Reflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = FunctionalVector2Reflection.GetControl(name);
        }

        public IFunctionalVector2 Generate()
        {
            return (ContentValue.Content as IFunctionalVector2Control).Generate();
        }
    }
}
