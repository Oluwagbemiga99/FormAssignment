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

        public Rectangle(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // this gets the width of the rectangle
        public int Width
        {
            get { return width; }
        }

        // this gets the height of the rectangle
        public int Height
        {
            get { return height; }
        }

        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(',');
            if (int.TryParse(userParam[0], out int Width)
                && int.TryParse(userParam[1], out int Height))
            {
                width = Width;
                height = Height;
            }
        }

        // The rectangle draw method
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(paintCanvas.Bitmap);

            if (PaintCanvas.Fill == false)
            {
                Pen myPen = new Pen(PaintCanvas.MyColour);
                var xPos = paintCanvas.XPos - (width / 2);
                var yPos = paintCanvas.YPos - (height / 2);
                g.DrawRectangle(myPen, xPos, yPos, width, height);
                myPen.Dispose();
            }
            else
            {
                SolidBrush solidBrush = new SolidBrush(PaintCanvas.MyColour);
                var xPos = paintCanvas.XPos - (width / 2);
                var yPos = paintCanvas.YPos - (height / 2);
                g.FillEllipse(solidBrush, xPos, yPos, width, height);
                solidBrush.Dispose();
            }
        }
    }
}
