﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public abstract class Command
    {
        // Takes in shape object and runs the draw method
        public void Commands(Canvas canvas, string userInput) 
        {
            Shape shape;

            shape = CreateCommands(canvas, userInput);

            if (shape != null )
            {
                shape.Draw();
            }
            
        }

        // returns a shape object
        public abstract Shape CreateCommands(Canvas canvas, string userinput);
    }
}
