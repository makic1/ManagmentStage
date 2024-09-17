namespace StageManagment.Uc
{
    partial class UcManageUsercontrols
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPageArtist = new TabPage();
            tabPageProgramStage = new TabPage();
            tabPagePerformance = new TabPage();
            tabPageTicket = new TabPage();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageArtist);
            tabControlMain.Controls.Add(tabPageProgramStage);
            tabControlMain.Controls.Add(tabPagePerformance);
            tabControlMain.Controls.Add(tabPageTicket);
            tabControlMain.Location = new Point(3, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(977, 480);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageArtist
            // 
            tabPageArtist.Location = new Point(4, 24);
            tabPageArtist.Name = "tabPageArtist";
            tabPageArtist.Padding = new Padding(3);
            tabPageArtist.Size = new Size(969, 452);
            tabPageArtist.TabIndex = 0;
            tabPageArtist.Text = "Künstler";
            tabPageArtist.UseVisualStyleBackColor = true;
            // 
            // tabPageProgramStage
            // 
            tabPageProgramStage.Location = new Point(4, 24);
            tabPageProgramStage.Name = "tabPageProgramStage";
            tabPageProgramStage.Padding = new Padding(3);
            tabPageProgramStage.Size = new Size(969, 452);
            tabPageProgramStage.TabIndex = 1;
            tabPageProgramStage.Text = "Program";
            tabPageProgramStage.UseVisualStyleBackColor = true;
            // 
            // tabPagePerformance
            // 
            tabPagePerformance.Location = new Point(4, 24);
            tabPagePerformance.Name = "tabPagePerformance";
            tabPagePerformance.Size = new Size(969, 452);
            tabPagePerformance.TabIndex = 2;
            tabPagePerformance.Text = "Vorstellung";
            tabPagePerformance.UseVisualStyleBackColor = true;
            // 
            // tabPageTicket
            // 
            tabPageTicket.Location = new Point(4, 24);
            tabPageTicket.Name = "tabPageTicket";
            tabPageTicket.Size = new Size(969, 452);
            tabPageTicket.TabIndex = 3;
            tabPageTicket.Text = "Ticket";
            tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // UcManageUsercontrols
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlMain);
            Name = "UcManageUsercontrols";
            Size = new Size(983, 486);
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageArtist;
        private TabPage tabPageProgramStage;
        private TabPage tabPagePerformance;
        private TabPage tabPageTicket;
    }
}
