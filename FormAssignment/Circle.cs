using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class Circle : Shape
    {
        int radius;

        public Circle(int xPos, int yPos, int Radius) : base(xPos, yPos)
        {
            radius = Radius;
        }

        // The circle draw method
        public void DrawCircle(Graphics g)
        {
            Pen myPen = new(Color.Black, 1);
            g.DrawEllipse(myPen, xPos, yPos, radius, radius);
        }
    }
}

