using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class DrawTo : Shape
    {
        int newX, newY;

        public DrawTo(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the new x position to draw to
        public int NewX
        {
            get { return newX; }
        }

        // This gets the new y position to draw to
        public int NewY
        {
            get { return newY; }
        }

        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(',');
            if (int.TryParse(userParam[0], out int xPos) 
                && int.TryParse(userParam[1], out int yPos))
            {
                newX = xPos;
                newY = yPos;
            }
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(paintCanvas.Bitmap);

            Pen myPen = new Pen(PaintCanvas.MyColour);
            var xPos = paintCanvas.XPos;
            var yPos = paintCanvas.YPos;
            g.DrawLine(myPen, xPos, yPos, newX, newY);

            paintCanvas.XPos = newX;
            paintCanvas.YPos = newY;
        }
    }
}
