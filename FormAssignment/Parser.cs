using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAssignment
{
    public class Parser
    {
        // This gets the command from the user input
        public static string GetCommand(string userInput)
        {
            string[] userCommandSplit = userInput.Split(" ");
            return userCommandSplit[0];
        }

        // This gets the parameters of the user input
        public static List<string> GetParam(string userInput) 
        {
            List<string> param = new List<string>();
            string[] userParamSplit = userInput.Split(" ");
            param = userParamSplit.ToList();
            param.RemoveAt(0);

            return param;
        }

        public static string GetParamMultiline(string userInput) 
        {
            List<string> param = new List<string>();
            string[] userParamSplit = userInput.Split(" ");
            param = userParamSplit.ToList();
            param.RemoveAt(0);

            return string.Join(" ", param);
        }
    }
}
