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
using RSL.World.Map;
using RSL.Robotics;
using RSL.Maths.Algebra;

namespace RSL.Graphics.Simulation
{
    /// <summary>
    /// Логика взаимодействия для RobotControl.xaml
    /// </summary>
    public partial class RobotControl : UserControl
    {
        public RobotControl(IRobot2 r)
        {
            InitializeComponent();
            Update(r);
        }
        public void Update(IRobot2 r)
        {
            Vector2 pos = r.Physics.Position;
            double proportions = r.Physics.Proportions*2;
            Width = proportions;
            Height = proportions;
            Canvas.SetLeft(this, pos.X - proportions/2);
            Canvas.SetBottom(this, pos.Y - proportions / 2);
          
            RotateTransform rotation = Img.RenderTransform as RotateTransform;
            if (rotation != null) // Make sure the transform is actually a RotateTransform
            {
                rotation.Angle = -r.Physics.Course.Azimuthal;
                // Do something with the rotationInDegrees here, if needed...
            }
        }
    }
}
