using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Rectangle : Shape
    {
        int height;
        int width;

        // Rectangle constructor
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

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(",");
      
            if (Param.Count != 1 || userParam.Length != 2)
            {
                MessageBox.Show("Invalid number of Parameters");
                return;
            }

            if (int.TryParse(userParam[0], out width)
                && int.TryParse(userParam[1], out height))
            {
                width = Width;
                height = Height;
            }
            else
            {
                MessageBox.Show("Invalid Type of parameters");
            }
        }

        // The rectangle draw method
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(PaintCanvas.Bitmap);

            var xPos = PaintCanvas.XPos - (width / 2);
            var yPos = PaintCanvas.YPos - (height / 2);

            if (PaintCanvas.Filled == false)
            {
                using (Pen myPen = new Pen(PaintCanvas.MyColour))
                {
                    g.DrawRectangle(myPen, xPos, yPos, width, height);
                }
            }
            else
            {
                using (SolidBrush solidBrush = new SolidBrush(PaintCanvas.MyColour))
                {
                    g.FillEllipse(solidBrush, xPos, yPos, width, height);
                }
            }
        }
    }
}
