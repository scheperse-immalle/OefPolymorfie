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
    public class Square : Shape
    {
        private Rectangle rect;

        public Square(int initX, int initY)
        {

        }

        public override void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(rect);
        }
        private void CreateRectangle()
        {
            rect = new Rectangle();
            rect.Stroke = brush;
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(x, y, 0, 0);
        }
    }
}
