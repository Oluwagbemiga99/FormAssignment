using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Canvas
    {
        protected int xPos;
        protected int yPos;
        protected Bitmap bitmap;
        Color myColour = Color.Black;
        protected bool fill = false;

        // Constructor that indicates the bitmap to draw on.
        public Canvas(Bitmap bitmap) 
        {
            this.bitmap = bitmap;
        }

        // This gets or sets the x-coordinate of the draw method
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        // This gets or sets the x-coordinate of the draw method
        public int YPos
        {
            get { return yPos; }new
            set { yPos = value; }
        }

        // This gets the bitmap
        public Bitmap Bitmap 
        {
            get { return bitmap; } 
        }

        // This gets or sets the colour of the shape
        public Color MyColour
        {
            get { return myColour; }
            set { myColour = value; }
        }

        // This gets or sets whether the shape is filled
        public bool Fill
        {
            get { return fill; }
            set { fill = value; }
        }
    }
}
