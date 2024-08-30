namespace ViewCs
{
    partial class MainView
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            //
            //  Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 15);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Label1";
            //
            //  txtCommand
            //
            this.txtCommand.Location = new System.Drawing.Point(71, 21);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(332, 23);
            this.txtCommand.TabIndex = 6;
            //
            //  btnRun
            //
            this.btnRun.Location = new System.Drawing.Point(12, 64);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 31);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "btnRun";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            //
            //  txtOutput
            //
            this.txtOutput.Location = new System.Drawing.Point(16, 112);
            this.txtOutput.Name = "txtCommand";
            this.txtOutput.BackColor = SystemColors.Window;
            this.txtOutput.Multiline = true;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(416, 168);
            this.txtOutput.TabIndex = 8;

            //
            //  MainView
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.Label1);
            this.Name = "MainView";
            this.Text = "Sample View";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label Label1;
        internal TextBox txtCommand;
        internal Button btnRun;
        internal TextBox txtOutput;
    }
}
