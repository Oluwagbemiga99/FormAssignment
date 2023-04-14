using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Circle : Shape
    {
        int radius;

        // Circle constructor
        public Circle(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the radius of the circle
        public int Radius
        {
            get { return radius; }
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            if (Param.Count != 1)
            {
                MessageBox.Show("Invalid number of parameters");
                return;
            }

            string[] userParam = Param[0].Split(",");
            if (int.TryParse(userParam[0], out int Radius))
            {
                radius = Radius;
            }
            else
            {
                Console.WriteLine("Invalid Type of parameters");
            }
        }

        // The circle draw method
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(PaintCanvas.Bitmap);

            var xPos = PaintCanvas.XPos - radius;
            var yPos = PaintCanvas.YPos - radius;

            if (PaintCanvas.Filled == false)
            {
                using (Pen myPen = new Pen(PaintCanvas.MyColour))
                {
                    g.DrawEllipse(myPen, xPos, yPos, radius * 2, radius * 2);
                }
            }
            else
            {
                using (SolidBrush solidBrush = new SolidBrush(PaintCanvas.MyColour))
                {
                    g.FillEllipse(solidBrush, xPos, yPos, radius * 2, radius * 2);
                }
            }
        }
    }
}

