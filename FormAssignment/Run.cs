using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Run : Shape
    {
        protected UserProgram prog;
        protected string userProg;

        // Run constructor
        public Run(Canvas canvas, string userProg) 
        {
            PaintCanvas = canvas;
            this.userProg = userProg;
            prog = new UserProgram(PaintCanvas);
            CheckParam();
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            if (Param.Count != 0)
            {
                MessageBox.Show("Invalid Parameters");
                return;
            }
        }

        // Ececutes the userprogram class to find the correct shape
        public override void Draw()
        {
            prog.SetProgLines(userProg);
            prog.Perform();

            PictureBox shape = Application.OpenForms["Form1"].Controls["ShapesWindow"] as PictureBox;
            shape.Image = PaintCanvas.Bitmap;
        }
    }
}
