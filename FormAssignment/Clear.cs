using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Clear : Shape
    {
        // Clear Constructor
        public Clear(Canvas canvas, List<string> param)
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

        // Clears the canvas
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(PaintCanvas.Bitmap))
            {
                g.Clear(Color.DarkGray);
            }
        }
    }
}
