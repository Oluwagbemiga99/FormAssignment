using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Reset : Shape
    {
        //Reset constructor
        public Reset(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            if (Param.Count != 0)
            {
                MessageBox.Show("Invalid number of Parameters");
                return;
            }
        }

        // Moves the cursor back to its original position
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(PaintCanvas.Bitmap))
            {
                paintCanvas.XPos = 0;
                paintCanvas.YPos = 0;
            }
        }
    }
}
