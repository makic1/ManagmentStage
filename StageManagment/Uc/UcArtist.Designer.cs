namespace StageManagment.Uc
{
    partial class UcArtist
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
            dataGridViewArtist = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            groupBoxArtist = new GroupBox();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxArtistCategorie = new ComboBox();
            textBoxName = new TextBox();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtist).BeginInit();
            groupBoxArtist.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewArtist
            // 
            dataGridViewArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewArtist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArtist.Location = new Point(3, 3);
            dataGridViewArtist.MultiSelect = false;
            dataGridViewArtist.Name = "dataGridViewArtist";
            dataGridViewArtist.ReadOnly = true;
            dataGridViewArtist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArtist.Size = new Size(670, 395);
            dataGridViewArtist.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(428, 404);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(78, 45);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Hinufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(512, 404);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(78, 45);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(596, 404);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(78, 45);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBoxArtist
            // 
            groupBoxArtist.Controls.Add(buttonSave);
            groupBoxArtist.Controls.Add(label1);
            groupBoxArtist.Controls.Add(comboBoxArtistCategorie);
            groupBoxArtist.Controls.Add(textBoxName);
            groupBoxArtist.Controls.Add(labelName);
            groupBoxArtist.Location = new Point(679, 3);
            groupBoxArtist.Name = "groupBoxArtist";
            groupBoxArtist.Size = new Size(287, 158);
            groupBoxArtist.TabIndex = 4;
            groupBoxArtist.TabStop = false;
            groupBoxArtist.Text = "Künstler";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(206, 120);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Kategorie";
            // 
            // comboBoxArtistCategorie
            // 
            comboBoxArtistCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArtistCategorie.FormattingEnabled = true;
            comboBoxArtistCategorie.Location = new Point(124, 61);
            comboBoxArtistCategorie.Name = "comboBoxArtistCategorie";
            comboBoxArtistCategorie.Size = new Size(157, 23);
            comboBoxArtistCategorie.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(124, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(157, 23);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // UcArtist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxArtist);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewArtist);
            Name = "UcArtist";
            Size = new Size(969, 452);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtist).EndInit();
            groupBoxArtist.ResumeLayout(false);
            groupBoxArtist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewArtist;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private GroupBox groupBoxArtist;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxArtistCategorie;
    }
}
