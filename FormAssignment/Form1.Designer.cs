namespace FormAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShapesWindow = new System.Windows.Forms.PictureBox();
            this.MultiCommandText = new System.Windows.Forms.TextBox();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.RunCommand = new System.Windows.Forms.Button();
            this.ResetCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShapesWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapesWindow
            // 
            this.ShapesWindow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ShapesWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShapesWindow.Location = new System.Drawing.Point(287, 12);
            this.ShapesWindow.Name = "ShapesWindow";
            this.ShapesWindow.Size = new System.Drawing.Size(277, 214);
            this.ShapesWindow.TabIndex = 0;
            this.ShapesWindow.TabStop = false;
            // 
            // MultiCommandText
            // 
            this.MultiCommandText.Location = new System.Drawing.Point(12, 12);
            this.MultiCommandText.Multiline = true;
            this.MultiCommandText.Name = "MultiCommandText";
            this.MultiCommandText.Size = new System.Drawing.Size(239, 214);
            this.MultiCommandText.TabIndex = 1;
            // 
            // CommandText
            // 
            this.CommandText.Location = new System.Drawing.Point(12, 232);
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(239, 23);
            this.CommandText.TabIndex = 2;
            this.CommandText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandText_KeyDown);
            // 
            // RunCommand
            // 
            this.RunCommand.Location = new System.Drawing.Point(12, 261);
            this.RunCommand.Name = "RunCommand";
            this.RunCommand.Size = new System.Drawing.Size(75, 23);
            this.RunCommand.TabIndex = 3;
            this.RunCommand.Text = "Run";
            this.RunCommand.UseVisualStyleBackColor = true;
            this.RunCommand.Click += new System.EventHandler(this.RunCommand_Click);
            // 
            // ResetCommand
            // 
            this.ResetCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetCommand.Location = new System.Drawing.Point(93, 261);
            this.ResetCommand.Name = "ResetCommand";
            this.ResetCommand.Size = new System.Drawing.Size(75, 23);
            this.ResetCommand.TabIndex = 0;
            this.ResetCommand.Text = "Reset";
            this.ResetCommand.UseVisualStyleBackColor = false;
            this.ResetCommand.Click += new System.EventHandler(this.ResetCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(576, 294);
            this.Controls.Add(this.ResetCommand);
            this.Controls.Add(this.RunCommand);
            this.Controls.Add(this.CommandText);
            this.Controls.Add(this.MultiCommandText);
            this.Controls.Add(this.ShapesWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShapesWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ShapesWindow;
        private TextBox MultiCommandText;
        private TextBox CommandText;
        private Button RunCommand;
        private Button ResetCommand;
    }
}