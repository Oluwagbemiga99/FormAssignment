using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class UserProgram
    {
        protected CommandFactory commFactory;
        protected ArrayList progLines;
        protected Canvas paintCanvas;
        protected Dictionary<string, int> vars = new Dictionary<string, int>();
        
        // UserProgram constructor
        public UserProgram(Canvas paintCanvas)
        {
            commFactory = new CommandFactory();
            progLines = new ArrayList();
            this.paintCanvas = paintCanvas;
        }

        // This gets or sets the list of lines in the multiline text
        public ArrayList ProgLines
        {
            get { return progLines; }
            set { progLines = value; }
        }

        // This gets each line of the textbox and stores
        // the command in the arraylist progLines
        public void SetProgLines(string userInput)
        {
            string[] userProg = userInput.Trim().ToLower().Split(new[] { "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < userProg.Length; i++)
            {
                var comm = commFactory.CreateCommands(paintCanvas, userProg[i]);

                if (comm is Variable variable)
                {
                    variable.Param = Parser.GetParam(userProg[i]);
                    variable.Vars = vars;
                    variable.CheckParam();

                    int value = variable.VarValue;
                    string varName = variable.VarName;

                    if (vars.ContainsKey(varName))
                    {
                        vars[varName] = value;
                    }
                    else
                    {
                        vars.Add(varName, value);
                        progLines.Add(variable);
                    }
                    continue;
                }

                string checkedVars = CheckVariables(userProg[i]);
                progLines.Add(commFactory.CreateCommands(paintCanvas, checkedVars));
            }
        }

        public string CheckVariables(string line)
        {
            string[] each = line.Split(" ");

            // Variable substitution for multiple parameter commands
            for (int i = 0; i < each.Length; i++)
            {
                if (each[i].Contains(","))
                {
                    string[] splitParam = each[i].Split(",");

                    for (int j = 0; j < splitParam.Length; j++)
                    {
                        if (vars.ContainsKey(splitParam[j]))
                        {
                            splitParam[j] = vars[splitParam[j]].ToString();
                        }
                    }

                    string rejoinParam = string.Join(",", splitParam);
                    each[i] = rejoinParam;
                }

                // Variable substitution for single parameter commands
                if (vars.ContainsKey(each[i]))
                {
                    each[i] = vars[each[i]].ToString();
                }
            }

            return string.Join(" ", each);
        }

        public void Perform()
        {
            foreach (Shape shape in progLines)
            {
                if (shape != null)
                {
                    shape.Draw();
                }                  
            }
        }
    }
}
