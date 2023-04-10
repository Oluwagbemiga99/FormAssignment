using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class CommandFactory : Command
    {
        public override Shape CreateCommands(Canvas canvas, string userinput)
        {
            string command = Parser.GetCommand(userinput);
            command.ToLower();
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
            else
            {
                var newMessage = MessageBox.Show("invalid Command");
                return null;
            }
        }
    }
}
