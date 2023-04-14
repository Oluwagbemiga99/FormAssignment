using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class ShapeFill : Shape
    {
        protected string fill;

        // ShapeFill constructor
        public ShapeFill(Canvas canvas, List<string> param) 
        { 
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the value of fill
        public string Fill
        {
            get { return fill; }
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            if (Param.Count != 1)
            {
                MessageBox.Show("Invalid number of Parameters");
                return;
            }

            
            if (Param[0] == "on" || Param[0] == "off" )
            {
                fill = Param[0];
            }
            else
            {
                MessageBox.Show("Invalid Type of parameter");
            }
        }

        // Turns fill on or off depending on user input
        public override void Draw()
        {
            if (fill == "on")
            {
                PaintCanvas.Filled = true;
            }
            else
            {
                PaintCanvas.Filled = false;
            }
        }
    }
}
