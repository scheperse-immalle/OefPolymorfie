using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace oefPolymorfie
{
    public class Circle : Shape
    {
        private Ellipse ellipse;

        public Circle(int initx, int initY)
        {
            x = initx;
            y = initx;
            CreateEllipse();
        }
        public override void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(ellipse);
        }
        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = brush;
            ellipse.Height = size;
            ellipse.Width = size;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }
    }
}
