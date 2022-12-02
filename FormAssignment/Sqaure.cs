using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class Sqaure : Shape
    {
        int size;

        public Sqaure(int xPos, int yPos, int Size) : base(xPos, yPos)
        {
            size = Size;
        }

        // The square draw method
        public void drawSqaure(Graphics g)
        {
            Pen myPen = new(Color.Black, 1);
            g.DrawRectangle(myPen, xPos, yPos, size, size);
        }
    }
}
