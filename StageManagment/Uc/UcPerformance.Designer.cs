namespace StageManagment.Uc
{
    partial class UcPerformance
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
            groupBoxPerformance = new GroupBox();
            label3 = new Label();
            dateTimePickerEndPerformance = new DateTimePicker();
            label2 = new Label();
            dateTimePickerStartPerfromance = new DateTimePicker();
            checkBoxIsActiv = new CheckBox();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxProgram = new ComboBox();
            textBoxName = new TextBox();
            labelName = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewPerformance = new DataGridView();
            groupBoxPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPerformance
            // 
            groupBoxPerformance.Controls.Add(label3);
            groupBoxPerformance.Controls.Add(dateTimePickerEndPerformance);
            groupBoxPerformance.Controls.Add(label2);
            groupBoxPerformance.Controls.Add(dateTimePickerStartPerfromance);
            groupBoxPerformance.Controls.Add(checkBoxIsActiv);
            groupBoxPerformance.Controls.Add(buttonSave);
            groupBoxPerformance.Controls.Add(label1);
            groupBoxPerformance.Controls.Add(comboBoxProgram);
            groupBoxPerformance.Controls.Add(textBoxName);
            groupBoxPerformance.Controls.Add(labelName);
            groupBoxPerformance.Location = new Point(679, 3);
            groupBoxPerformance.Name = "groupBoxPerformance";
            groupBoxPerformance.Size = new Size(287, 221);
            groupBoxPerformance.TabIndex = 14;
            groupBoxPerformance.TabStop = false;
            groupBoxPerformance.Text = "Vorstellung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 18;
            label3.Text = "Ende";
            // 
            // dateTimePickerEndPerformance
            // 
            dateTimePickerEndPerformance.Location = new Point(124, 90);
            dateTimePickerEndPerformance.Name = "dateTimePickerEndPerformance";
            dateTimePickerEndPerformance.Size = new Size(157, 23);
            dateTimePickerEndPerformance.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 16;
            label2.Text = "Begin";
            // 
            // dateTimePickerStartPerfromance
            // 
            dateTimePickerStartPerfromance.Location = new Point(124, 61);
            dateTimePickerStartPerfromance.Name = "dateTimePickerStartPerfromance";
            dateTimePickerStartPerfromance.Size = new Size(157, 23);
            dateTimePickerStartPerfromance.TabIndex = 15;
            // 
            // checkBoxIsActiv
            // 
            checkBoxIsActiv.AutoSize = true;
            checkBoxIsActiv.Location = new Point(228, 119);
            checkBoxIsActiv.Name = "checkBoxIsActiv";
            checkBoxIsActiv.Size = new Size(53, 19);
            checkBoxIsActiv.TabIndex = 14;
            checkBoxIsActiv.Text = "Aktiv";
            checkBoxIsActiv.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(206, 191);
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
            label1.Location = new Point(6, 147);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Program";
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Location = new Point(124, 144);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(157, 23);
            comboBoxProgram.TabIndex = 2;
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
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(512, 404);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(78, 45);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(428, 404);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(78, 45);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Hinufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewPerformance
            // 
            dataGridViewPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPerformance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPerformance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerformance.Location = new Point(3, 3);
            dataGridViewPerformance.MultiSelect = false;
            dataGridViewPerformance.Name = "dataGridViewPerformance";
            dataGridViewPerformance.ReadOnly = true;
            dataGridViewPerformance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPerformance.Size = new Size(670, 395);
            dataGridViewPerformance.TabIndex = 10;
            // 
            // UcPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPerformance);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewPerformance);
            Name = "UcPerformance";
            Size = new Size(969, 452);
            groupBoxPerformance.ResumeLayout(false);
            groupBoxPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPerformance;
        private Label label3;
        private DateTimePicker dateTimePickerEndPerformance;
        private Label label2;
        private DateTimePicker dateTimePickerStartPerfromance;
        private CheckBox checkBoxIsActiv;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxProgram;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewPerformance;
    }
}
