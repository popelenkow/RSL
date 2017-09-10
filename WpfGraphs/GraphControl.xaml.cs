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
using System.Windows.Threading;
using System.IO;
using RSL.Controls;
using OxyPlot;
using OxyPlot.Wpf;

namespace WpfGraphs
{
    /// <summary>
    /// Логика взаимодействия для GraphControl.xaml
    /// </summary>
    public partial class GraphControl : UserControl
    {

        public LoadStackControl Stack { get; set; }
        public GraphControl()
        {
            InitializeComponent();
        }

     
        private void Plot_Click(object sender, RoutedEventArgs e)
        {
            Plot.Series.Clear();
            Plot.Axes.Clear();

            var linearAxis1 = new LinearAxis();
            linearAxis1.MajorGridlineStyle = LineStyle.Solid;
            linearAxis1.MinorGridlineStyle = LineStyle.Dot;
            linearAxis1.Position = OxyPlot.Axes.AxisPosition.Bottom;
            linearAxis1.Title = "Время [cек]";
            Plot.Axes.Add(linearAxis1);
            var linearAxis2 = new LinearAxis();
            linearAxis2.MajorGridlineStyle = LineStyle.Solid;
            linearAxis2.MinorGridlineStyle = LineStyle.Dot;
            linearAxis2.Title = TextBox.Text;
            Plot.Axes.Add(linearAxis2);

            foreach (var r in Stack.Stack.ItemsStackControl.Children)
            {
                var rr = (r as RSStackItem).ContentValue;
                var refl = rr as LoadControl;




                LineSeries s;
                s = new LineSeries
                {
                    ItemsSource = refl.Points,
                    Title = refl.GraphNameTextBox.Text
                };
                Plot.Series.Add(s);
            }
            Plot.LegendBackground = Colors.White;
            Plot.LegendBorder = Colors.Black;
            Plot.LegendFontSize = 20;
            Plot.InvalidatePlot();

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Plot.Series.Clear();

            var pngExporter = new PngExporter { Width = 600, Height = 260, Background = OxyColors.White };
            pngExporter.ExportToFile(Plot.ActualModel, Directory.GetCurrentDirectory() + "\\img.png");
        }
       
    }
}
