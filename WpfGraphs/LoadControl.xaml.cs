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
using OxyPlot;

namespace WpfGraphs
{
    /// <summary>
    /// Логика взаимодействия для LoadControl.xaml
    /// </summary>
    public partial class LoadControl : UserControl
    {
        private List<DataPoint> _points = new List<DataPoint>();

        public List<DataPoint> Points
        {
            get { return _points; }
        }

        public LoadControl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                FileNameTextBox.Text = filename;

                System.IO.StreamReader file = new System.IO.StreamReader(filename);

                string line = "";

                Points.Clear();
                while (true)
                {
                    if ((line = file.ReadLine()) == null) break;
                    double x = Convert.ToDouble(line);
                    if ((line = file.ReadLine()) == null) break;
                    double y = Convert.ToDouble(line);

                    DataPoint p = new DataPoint(x, y);
                    Points.Add(p);
                }
                
            }
        }
    }
}
