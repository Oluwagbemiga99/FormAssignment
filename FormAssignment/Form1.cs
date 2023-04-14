using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace FormAssignment
{
    public partial class Form1 : Form
    {
        Canvas newCanvas;
        Command comm;

        public Form1()
        {
            InitializeComponent();

            newCanvas = new Canvas(new Bitmap(ShapesWindow.Width, ShapesWindow.Height));
            comm = new CommandFactory();
        }

        // Takes in the multiline textbox text
        // and passes it to the command factory class 
        private void RunCommand_Click(object sender, EventArgs e)
        {
            string multiCommand = MultiCommandText.Text.ToLower();

            comm.Commands(newCanvas, "run" + " " + multiCommand);
        }

        // Takes in the commandline textbox text
        // and passes it to the command factory class 
        private void CommandText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string showCommand = CommandText.Text;

                if (showCommand == "run")
                {
                    RunCommand_Click(sender, e);
                }
                else
                {
                    comm.Commands(newCanvas, showCommand);
                    ShapesWindow.Image = newCanvas.Bitmap;
                }
                
            }
        }
    }
}