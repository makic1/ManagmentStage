namespace StageManagment.Uc
{
    partial class UcProgramStage
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
            groupBoxProgramStage = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            checkBoxIsPayd = new CheckBox();
            textBoxEndPrice = new TextBox();
            label5 = new Label();
            textBoxStartPrice = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            numericUpDownDuration = new NumericUpDown();
            label2 = new Label();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxArtist = new ComboBox();
            textBoxName = new TextBox();
            labelName = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewProgramStage = new DataGridView();
            groupBoxProgramStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramStage).BeginInit();
            SuspendLayout();
            // 
            // groupBoxProgramStage
            // 
            groupBoxProgramStage.Controls.Add(label8);
            groupBoxProgramStage.Controls.Add(label7);
            groupBoxProgramStage.Controls.Add(label6);
            groupBoxProgramStage.Controls.Add(checkBoxIsPayd);
            groupBoxProgramStage.Controls.Add(textBoxEndPrice);
            groupBoxProgramStage.Controls.Add(label5);
            groupBoxProgramStage.Controls.Add(textBoxStartPrice);
            groupBoxProgramStage.Controls.Add(label4);
            groupBoxProgramStage.Controls.Add(textBoxPrice);
            groupBoxProgramStage.Controls.Add(label3);
            groupBoxProgramStage.Controls.Add(numericUpDownDuration);
            groupBoxProgramStage.Controls.Add(label2);
            groupBoxProgramStage.Controls.Add(buttonSave);
            groupBoxProgramStage.Controls.Add(label1);
            groupBoxProgramStage.Controls.Add(comboBoxArtist);
            groupBoxProgramStage.Controls.Add(textBoxName);
            groupBoxProgramStage.Controls.Add(labelName);
            groupBoxProgramStage.Location = new Point(679, 3);
            groupBoxProgramStage.Name = "groupBoxProgramStage";
            groupBoxProgramStage.Size = new Size(287, 285);
            groupBoxProgramStage.TabIndex = 9;
            groupBoxProgramStage.TabStop = false;
            groupBoxProgramStage.Text = "Program";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 151);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 17;
            label8.Text = "€";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 122);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 16;
            label7.Text = "€";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 93);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 15;
            label6.Text = "€";
            // 
            // checkBoxIsPayd
            // 
            checkBoxIsPayd.AutoSize = true;
            checkBoxIsPayd.Location = new Point(217, 177);
            checkBoxIsPayd.Name = "checkBoxIsPayd";
            checkBoxIsPayd.Size = new Size(64, 19);
            checkBoxIsPayd.TabIndex = 14;
            checkBoxIsPayd.Text = "Bezahlt";
            checkBoxIsPayd.UseVisualStyleBackColor = true;
            // 
            // textBoxEndPrice
            // 
            textBoxEndPrice.Location = new Point(124, 148);
            textBoxEndPrice.Name = "textBoxEndPrice";
            textBoxEndPrice.Size = new Size(136, 23);
            textBoxEndPrice.TabIndex = 13;
            textBoxEndPrice.KeyPress += textBoxEndPrice_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Schlusszahlung";
            // 
            // textBoxStartPrice
            // 
            textBoxStartPrice.Location = new Point(124, 119);
            textBoxStartPrice.Name = "textBoxStartPrice";
            textBoxStartPrice.Size = new Size(136, 23);
            textBoxStartPrice.TabIndex = 11;
            textBoxStartPrice.KeyPress += textBoxStartPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Anzahlung";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(124, 90);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(136, 23);
            textBoxPrice.TabIndex = 9;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 93);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "Preis";
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(124, 61);
            numericUpDownDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(157, 23);
            numericUpDownDuration.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Dauer";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(206, 256);
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
            label1.Location = new Point(6, 205);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Künstler";
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(124, 202);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(157, 23);
            comboBoxArtist.TabIndex = 2;
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
            // buttonDelete
            // 
            buttonDelete.Location = new Point(596, 404);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(78, 45);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(512, 404);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(78, 45);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(428, 404);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(78, 45);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Hinufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewProgramStage
            // 
            dataGridViewProgramStage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProgramStage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProgramStage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramStage.Location = new Point(3, 3);
            dataGridViewProgramStage.MultiSelect = false;
            dataGridViewProgramStage.Name = "dataGridViewProgramStage";
            dataGridViewProgramStage.ReadOnly = true;
            dataGridViewProgramStage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProgramStage.Size = new Size(670, 395);
            dataGridViewProgramStage.TabIndex = 5;
            // 
            // UcProgramStage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxProgramStage);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProgramStage);
            Name = "UcProgramStage";
            Size = new Size(969, 452);
            groupBoxProgramStage.ResumeLayout(false);
            groupBoxProgramStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramStage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProgramStage;
        private CheckBox checkBoxIsPayd;
        private TextBox textBoxEndPrice;
        private Label label5;
        private TextBox textBoxStartPrice;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label3;
        private NumericUpDown numericUpDownDuration;
        private Label label2;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxArtist;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewProgramStage;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
