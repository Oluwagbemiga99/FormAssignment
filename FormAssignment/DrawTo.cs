using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class DrawTo : Shape
    {
        int newX, newY;

        // DrawTo constructor
        public DrawTo(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the new x position to draw t0
        public int NewX
        {
            get { return newX; }
        }

        // This gets the new y position to draw to
        public int NewY
        {
            get { return newY; }
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(",");

            if (Param.Count != 1 || userParam.Length != 2)
            {
                MessageBox.Show("Invalid number of Parameters");
                return;
            }

            if (int.TryParse(userParam[0], out int xPos) 
                && int.TryParse(userParam[1], out int yPos))
            {
                newX = xPos;
                newY = yPos;
            }
            else
            {
                MessageBox.Show("Invalid Type of parameters");
            }
        }

        // The drawTo draw method
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(PaintCanvas.Bitmap);

            var xPos = PaintCanvas.XPos;
            var yPos = PaintCanvas.YPos;

            using (Pen myPen = new Pen(PaintCanvas.MyColour))
            {
                PaintCanvas.XPos = newX;
                PaintCanvas.YPos = newY;
                g.DrawLine(myPen, xPos, yPos, newX, newY);
            }                          
        }
    }
}
