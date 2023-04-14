using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Colour : Shape
    {
        protected Color myColour;

        // Colour constructor
        public Colour(Canvas canvas, List<string> param) 
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        // This gets the pen colour of the circle
        public Color MyColour
        {
            get { return myColour; }
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            string userColour = Param[0].ToLower();
            if (Param.Count != 1)
            {
                MessageBox.Show("Invalid number of Parameters");
                return;
            }

            
            if (userColour == "red")
            {
                myColour = Color.Red;
            }
            else if (userColour == "blue")
            {
                myColour = Color.Blue;
            }
            else if (userColour == "green")
            {
                myColour = Color.Green;
            }
            else if (userColour == "black")
            {
                myColour = Color.Black;
            }
            else if (userColour == "orange")
            {
                myColour = Color.Orange;
            }
            else
            {
                MessageBox.Show("Invalid Type of parameter");
            }
        }

        // Updates the pen colour
        public override void Draw()
        {
            PaintCanvas.MyColour = MyColour;
        }
    }
}
