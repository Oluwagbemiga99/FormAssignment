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

        private void RunCommand_Click(object sender, EventArgs e)
        {
            string multiCommand = MultiCommandText.Text;
            string showCommand = CommandText.Text;

            comm.Commands(newCanvas, showCommand);
            comm.Commands(newCanvas, multiCommand);
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

                comm.Commands(newCanvas, showCommand);
            }
        }
    }
}