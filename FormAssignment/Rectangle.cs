using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class Rectangle : Shape
    {
        int height;
        int width;

        public Rectangle(int xPos, int yPos, int Width, int Height) : base(xPos, yPos)
        {
            width = Width;
            height = Height;
        }

        // The rectangle draw method
        public void DrawRectancgle(Graphics g)
        {
            Pen myPen = new(Color.Black, 1);
            g.DrawRectangle(myPen, xPos, yPos, width, height);
        }
    }
}
