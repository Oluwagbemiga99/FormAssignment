using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAssignment
{
    public class Parser
    {
        public Parser(string showCommand, Graphics g) 
        {
            string[] commandList = showCommand.Split(" ");
            // Ensures the text is always lower case
            string command = commandList[0].ToLowerInvariant();
            if (commandList.Length < 3 || commandList.Length < 2 || commandList.Length < 1)
            {
                MessageBox.Show("Not enough parameters");
            }
            else
            {
                // Takes in x coordinate
                int current_xPos = int.Parse(commandList[1]);
                // Takes in y coordinate
                int current_yPos = int.Parse(commandList[2]);
                // Takes in the radius for the circle
                int current_Radius = int.Parse(commandList[3]);
                // Takes in the side of the square
                int current_size = int.Parse(commandList[3]);
                // Takes in the width for the rectangle
                int current_width = int.Parse(commandList[3]);

                if (command == "circle")
                {
                    Circle circle = new(current_xPos, current_yPos, current_Radius);
                    circle.DrawCircle(g);
                }
                else if (command == "square")
                {
                    Sqaure sqaure = new(current_xPos, current_yPos, current_size);
                    sqaure.drawSqaure(g);
                }
                else if (command == "rect")
                {
                    Rectangle rect = new(current_xPos, current_yPos, current_width, int.Parse(commandList[4]));
                    rect.DrawRectancgle(g);
                }
                else
                {
                    MessageBox.Show("Wrong command");
                }
            }
        }
    }
}
