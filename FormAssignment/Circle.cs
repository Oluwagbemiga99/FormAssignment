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

        // Circle constructor
        public Circle(Canvas paintCanvas, List<string> param)
        {
            PaintCanvas = paintCanvas;
            Param = param;
            CheckParam();
        }

        // this gets the radius of the circle
        public int Radius
        {
            get { return radius; }
        }

        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(',');
            if (int.TryParse(userParam[0], out int Radius))
            {
                radius = Radius;
            }
        }

        // The circle draw method
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(paintCanvas.Bitmap);

            if (paintCanvas.Fill == false)
            {
                Pen myPen = new Pen(paintCanvas.MyColour);
                var xPos = paintCanvas.XPos - radius;
                var yPos = paintCanvas.YPos - radius;
                g.DrawEllipse(myPen, xPos, yPos, radius * 2, radius * 2);
                myPen.Dispose();
            }
            else
            {
                SolidBrush solidBrush = new SolidBrush(paintCanvas.MyColour);
                var xPos = paintCanvas.XPos - radius;
                var yPos = paintCanvas.YPos - radius;
                g.FillEllipse(solidBrush, xPos, yPos, radius, radius);
                solidBrush.Dispose();
            }
        }
    }
}

