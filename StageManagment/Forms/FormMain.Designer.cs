﻿namespace StageManagment
{
    partial class FormMain
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
            panelMain = new Panel();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(12, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(983, 486);
            panelMain.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 510);
            Controls.Add(panelMain);
            MaximumSize = new Size(1023, 549);
            MinimumSize = new Size(1023, 549);
            Name = "FormMain";
            Text = "Kunstbühne";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
    }
}
