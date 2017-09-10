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
using RSL.Analysis;

namespace RSL.Graphics.Generation.Analysis
{
    /// <summary>
    /// Логика взаимодействия для AnalyzerReflectionControl.xaml
    /// </summary>
    public partial class AnalyzerReflectionControl : UserControl
    {
        public AnalyzerReflectionControl()
        {
            InitializeComponent();

            var arr = AnalyzerReflection.Controls;
            foreach (var el in arr)
            {
                ContentKey.Items.Add(el.Name);
            }

            ContentKey.SelectedIndex = 0;
        }
        private void Update(object sender, SelectionChangedEventArgs args)
        {
            string name = ContentKey.SelectedItem as string;
            ContentValue.Content = AnalyzerReflection.GetControl(name);
        }
        public IAnalyzer Generate()
        {
            return (ContentValue.Content as IAnalyzerControl).Generate();
        }
    }
}
