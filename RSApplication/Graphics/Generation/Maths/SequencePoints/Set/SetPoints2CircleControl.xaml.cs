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
using RSL.Maths.Algebra;

namespace RSL.Graphics.Generation.Maths.SequencePoints.Set
{
    /// <summary>
    /// Логика взаимодействия для SP2CircleControl.xaml
    /// </summary>

    public partial class SetPoints2CircleControl : UserControl, ISetPoints2Control
    {
        public Vector2 Position
        {
            get
            {
                Vector2 p = new Vector2()
                {
                    X = double.Parse(PositionXControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture),
                    Y = double.Parse(PositionYControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture)
                };
                return p;
            }
            set
            {
                PositionXControl.TextBox.Text = value.X.ToString();
                PositionYControl.TextBox.Text = value.Y.ToString();
            }
        }
        public double Radius
        {
            get
            {
                return double.Parse(RadiusControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
            set
            {
                RadiusControl.TextBox.Text = value.ToString();
            }
        }
        public Direction2 Direction
        {
            get
            {
                return new Direction2(double.Parse(DirectionAzimuthalControl.TextBox.Text, System.Globalization.CultureInfo.InvariantCulture));
            }
            set
            {
                DirectionAzimuthalControl.TextBox.Text = value.Azimuthal.ToString();
            }
        }
        public SetPoints2CircleControl()
        {
            InitializeComponent();

        }

        public ISetPoints2 Generate()
        {

            return new SetPoints2Circle(Radius, Position, Direction);
        }
        /*
        private TableKeyValueControl CreateTableControl()
        {
            return new TableKeyValueControl(CreateTableData());
        }
        private TableKeyValueData CreateTableData()
        {
            var table = new TableKeyValueData();
            RowKeyValueData rowData;

            rowData = CreateRowData("Radius", 1);
            table.Rows.Add(rowData);
            rowData = CreateRowData("Position", 2);
            table.Rows.Add(rowData);
            rowData = CreateRowData("Direction", 1);
            table.Rows.Add(rowData);

            return table;
        }
        private RowKeyValueData CreateRowData(string keyName, int countValues)
        {
            var rowData = new RowKeyValueData();

            TextBlock key = new TextBlock();

            key.SetResourceReference(TextBlock.TextProperty, keyName);
            rowData.Key = key;


            for (int i = 0; i < countValues; i++)
            {
                rowData.Values.Add(new RSNumericBox());
            }

            return rowData;
        }
        */
    }

}
