﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public abstract class Shape
    {
        protected List<string> param = new List<string>();
        protected Canvas paintCanvas;

        // The command draw method
        public abstract void Draw();

        // Checks if the parameters are not met
        // and also parses command parameter
        public abstract void CheckParam();

        // This gets or sets the user input
        public List<string> Param
        {
            get { return param; }
            set { param = value; }   
        }

        // This gets or sets the canvas
        public Canvas PaintCanvas
        {
            get { return paintCanvas; }
            set { paintCanvas = value; }
        }
    }
}
