using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class MoveTo : Shape
    {
        int newX, newY;

        // MoveTo constructor
        public MoveTo(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the new x position to draw t
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
                MessageBox.Show("Invalid number of parameters");
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

        // The moveTo draw method
        public override void Draw()
        {
            PaintCanvas.XPos = newX;
            PaintCanvas.YPos = newY;
        }
    }
}
