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
using RSL.Controls;

namespace RSL.Graphics.Generation.Analysis
{
    /// <summary>
    /// Логика взаимодействия для AnalyzerStackControl.xaml
    /// </summary>
    public partial class AnalyzerStackControl : UserControl
    {
        public AnalyzerStackControl()
        {
            InitializeComponent();
            Stack.TypeNewItem = typeof(AnalyzerReflectionControl);
            Stack.AddNewItem();
        }
        public List<IAnalyzer> Generate()
        {
            List<IAnalyzer> arr = new List<IAnalyzer>();
            foreach (var r in Stack.ItemsStackControl.Children)
            {
                var rr = (r as RSStackItem).ContentValue;
                var refl = rr as AnalyzerReflectionControl;
                arr.Add(refl.Generate());
            }
            return arr;
        }
    }
}
