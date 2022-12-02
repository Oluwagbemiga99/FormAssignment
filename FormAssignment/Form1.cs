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

        public Form1()
        {
            InitializeComponent();
        }

        private void RunCommand_Click(object sender, EventArgs e)
        {
            string multiCommand = MultiCommandText.Text;
            string showCommand = CommandText.Text;
            Graphics g = ShapesWindow.CreateGraphics();

            // Takes in the text from the textbox and passes it to the parser class
            Parser parser = new(showCommand, g);
        }

        private void ResetCommand_Click(object sender, EventArgs e)
        {
            ShapesWindow.Refresh();
        }

        private void CommandText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string showCommand = CommandText.Text;
                Graphics g = ShapesWindow.CreateGraphics();

                // Takes in the text from the textbox and passes it to the parser class
                Parser parser = new(showCommand, g);
            }
        }
    }
}