﻿namespace ViewCs
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
            this.Button1 = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();

            this.SuspendLayout();
            //
            // Button1
            //
            this.Button1.Location = new System.Drawing.Point(12, 64);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(110, 31);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            //
            // txtCommand
            //
            this.txtCommand.Location = new System.Drawing.Point(71, 21);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(332, 23);
            this.txtCommand.TabIndex = 6;
            //
            // Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 15);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Label1";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Button Button1;
        internal TextBox txtCommand;
        internal Label Label1;
    }
}
