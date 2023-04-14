using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    public class Variable : Shape
    {
        protected string varName;
        protected int varValue; 
        protected Dictionary<string, int> vars = new Dictionary<string, int>();

        // Variable constructor
        public Variable(List<string> param) 
        {
            Param = param;
            CheckParam();
        }

        // Called by the UserProgram class
        public Variable() { }

        // This gets or sets the name of the variable
        public string VarName
        {
            get { return varName; }
            set { varName = value; }
        }

        // This gets or sets the value of the variable
        public int VarValue
        {
            get { return varValue; }
            set { varValue = value; }
        }

        // This gets or sets the list of variables
        public Dictionary<string, int> Vars
        {
            get { return vars; }
            set { vars = value; }
        }

        // Shows error if the parameters are not met
        public override void CheckParam()
        {
            if (Param.Count == 3)
            {
                if (vars.ContainsKey(Param[2]))
                {
                    Param[2] = vars[Param[2]].ToString();
                }

                if (Param[1] != "=")
                {
                    MessageBox.Show("Incorrect command format");
                    return;
                }
                else if (Int32.TryParse(Param[2], out int parsedValue))
                {
                    varValue = parsedValue;
                    varName = Param[0];
                }
                else
                {
                    MessageBox.Show("Invalid Type of parameters");
                }
            }
            else if (Param.Count == 5 && CheckVarDeclaration(string.Join(" ", Param)))
            {
                varName = Param[0];

                string mathOperator = Param[3];

                if (vars.TryGetValue(varName, out int varValue))
                {
                    if (Int32.TryParse(Param[4], out int increment))
                    {
                        switch (mathOperator)
                        {
                            case "+":
                                varValue += increment;
                                break;
                            case "-":
                                varValue -= increment;
                                break;
                            case "*":
                                varValue *= increment;
                                break;
                            case "/":
                                varValue /= increment;
                                break;
                            default:
                                MessageBox.Show("Invalid operator");
                                break;
                        }

                        vars[varName] = varValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Type of parameters");
                    }
                }
                else
                {
                    MessageBox.Show("Variable not declared");
                }
            }
            else
            {
                MessageBox.Show("Invalid Type of parameters");
            }
        }

        // Checks if the variable declaration format is correct
        public bool CheckVarDeclaration(string input)
        {
            string[] tokens = input.Split(new char[] { '=', ' ', '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length != 3)
            {
                return false;
            }

            if (!int.TryParse(tokens[2], out int value))
            {
                return false;
            }

            return true;
        }

        public override void Draw()
        {
            return;
        }

    }
}
