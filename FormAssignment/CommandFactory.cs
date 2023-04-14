using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class CommandFactory : Command
    {
        // Returns Shape object
        public override Shape CreateCommands(Canvas canvas, string userinput)
        {
            string command = Parser.GetCommand(userinput);
            List<string> param = Parser.GetParam(userinput);

            if(command == "moveto")
            {
                return new MoveTo(canvas, param);
            }
            else if(command == "drawto")
            {
                return new DrawTo(canvas, param);
            }
            else if (command == "circle")
            {
                return new Circle(canvas, param);
            }
            else if (command == "rect" || command == "rectangle")
            {
                return new Rectangle(canvas, param);
            }
            else if (command == "pen")
            {
                return new Colour(canvas, param);
            }
            else if (command == "fill")
            {
                return new ShapeFill(canvas, param);
            }
            else if (command == "clear")
            {
                return new Clear(canvas, param);
            }
            else if (command == "reset")
            {
                return new Reset(canvas, param);
            }
            else if (command == "var")
            {
                return new Variable(param);
            }
            else if (command == "run")
            {
                string userProg = Parser.GetParamMultiline(userinput);
                return new Run(canvas, userProg);
            }
            else
            {
                MessageBox.Show(command + " is an invalid Command");
                return null;
            }

        }
    }
}
