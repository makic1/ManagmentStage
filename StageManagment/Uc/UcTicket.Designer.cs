namespace StageManagment.Uc
{
    partial class UcTicket
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
            groupBoxTicket = new GroupBox();
            numericUpDownPLZ = new NumericUpDown();
            comboBoxCategorie = new ComboBox();
            label12 = new Label();
            textBoxCountry = new TextBox();
            label11 = new Label();
            textBoxAddress = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBoxLastname = new TextBox();
            label8 = new Label();
            textBoxFirstName = new TextBox();
            label5 = new Label();
            comboBoxSeatRow = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBoxPayedPrice = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            numericUpDownSeatNumber = new NumericUpDown();
            label2 = new Label();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxPerformance = new ComboBox();
            labelSeatRow = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewTicket = new DataGridView();
            groupBoxTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPLZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.Controls.Add(numericUpDownPLZ);
            groupBoxTicket.Controls.Add(comboBoxCategorie);
            groupBoxTicket.Controls.Add(label12);
            groupBoxTicket.Controls.Add(textBoxCountry);
            groupBoxTicket.Controls.Add(label11);
            groupBoxTicket.Controls.Add(textBoxAddress);
            groupBoxTicket.Controls.Add(label10);
            groupBoxTicket.Controls.Add(label9);
            groupBoxTicket.Controls.Add(textBoxLastname);
            groupBoxTicket.Controls.Add(label8);
            groupBoxTicket.Controls.Add(textBoxFirstName);
            groupBoxTicket.Controls.Add(label5);
            groupBoxTicket.Controls.Add(comboBoxSeatRow);
            groupBoxTicket.Controls.Add(label7);
            groupBoxTicket.Controls.Add(label6);
            groupBoxTicket.Controls.Add(textBoxPayedPrice);
            groupBoxTicket.Controls.Add(label4);
            groupBoxTicket.Controls.Add(textBoxPrice);
            groupBoxTicket.Controls.Add(label3);
            groupBoxTicket.Controls.Add(numericUpDownSeatNumber);
            groupBoxTicket.Controls.Add(label2);
            groupBoxTicket.Controls.Add(buttonSave);
            groupBoxTicket.Controls.Add(label1);
            groupBoxTicket.Controls.Add(comboBoxPerformance);
            groupBoxTicket.Controls.Add(labelSeatRow);
            groupBoxTicket.Location = new Point(679, 3);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Size = new Size(287, 432);
            groupBoxTicket.TabIndex = 14;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Ticket";
            // 
            // numericUpDownPLZ
            // 
            numericUpDownPLZ.Location = new Point(124, 313);
            numericUpDownPLZ.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownPLZ.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPLZ.Name = "numericUpDownPLZ";
            numericUpDownPLZ.Size = new Size(157, 23);
            numericUpDownPLZ.TabIndex = 32;
            numericUpDownPLZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxCategorie
            // 
            comboBoxCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorie.FormattingEnabled = true;
            comboBoxCategorie.Location = new Point(124, 226);
            comboBoxCategorie.Name = "comboBoxCategorie";
            comboBoxCategorie.Size = new Size(157, 23);
            comboBoxCategorie.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 316);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 29;
            label12.Text = "PLZ";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(124, 284);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(157, 23);
            textBoxCountry.TabIndex = 28;
            textBoxCountry.Text = "Nicht Verkauft";
            textBoxCountry.KeyPress += textBoxCountry_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 287);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 27;
            label11.Text = "Stadt";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(124, 255);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(157, 23);
            textBoxAddress.TabIndex = 26;
            textBoxAddress.Text = "Nicht Verkauft";
            textBoxAddress.KeyPress += textBoxAddress_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 258);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 25;
            label10.Text = "Adresse";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 229);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 23;
            label9.Text = "Kategorie";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(124, 197);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(157, 23);
            textBoxLastname.TabIndex = 22;
            textBoxLastname.Text = "Nicht Verkauft";
            textBoxLastname.KeyPress += textBoxLastname_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 200);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 21;
            label8.Text = "Nachname";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(124, 168);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(157, 23);
            textBoxFirstName.TabIndex = 20;
            textBoxFirstName.Text = "Nicht Verkauft";
            textBoxFirstName.KeyPress += textBoxFirstName_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 171);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 19;
            label5.Text = "Vorname";
            // 
            // comboBoxSeatRow
            // 
            comboBoxSeatRow.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeatRow.FormattingEnabled = true;
            comboBoxSeatRow.Location = new Point(124, 32);
            comboBoxSeatRow.Name = "comboBoxSeatRow";
            comboBoxSeatRow.Size = new Size(155, 23);
            comboBoxSeatRow.TabIndex = 18;
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
            // textBoxPayedPrice
            // 
            textBoxPayedPrice.Location = new Point(124, 119);
            textBoxPayedPrice.Name = "textBoxPayedPrice";
            textBoxPayedPrice.Size = new Size(136, 23);
            textBoxPayedPrice.TabIndex = 11;
            textBoxPayedPrice.KeyPress += textBoxPayedPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Bezahlt";
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
            // numericUpDownSeatNumber
            // 
            numericUpDownSeatNumber.Location = new Point(124, 61);
            numericUpDownSeatNumber.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownSeatNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSeatNumber.Name = "numericUpDownSeatNumber";
            numericUpDownSeatNumber.Size = new Size(157, 23);
            numericUpDownSeatNumber.TabIndex = 7;
            numericUpDownSeatNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Nummer";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(206, 401);
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
            label1.Location = new Point(6, 361);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Vorstellung";
            // 
            // comboBoxPerformance
            // 
            comboBoxPerformance.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPerformance.FormattingEnabled = true;
            comboBoxPerformance.Location = new Point(124, 358);
            comboBoxPerformance.Name = "comboBoxPerformance";
            comboBoxPerformance.Size = new Size(157, 23);
            comboBoxPerformance.TabIndex = 2;
            // 
            // labelSeatRow
            // 
            labelSeatRow.AutoSize = true;
            labelSeatRow.Location = new Point(6, 35);
            labelSeatRow.Name = "labelSeatRow";
            labelSeatRow.Size = new Size(36, 15);
            labelSeatRow.TabIndex = 0;
            labelSeatRow.Text = "Reihe";
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
            // dataGridViewTicket
            // 
            dataGridViewTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTicket.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Location = new Point(3, 3);
            dataGridViewTicket.MultiSelect = false;
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTicket.Size = new Size(670, 395);
            dataGridViewTicket.TabIndex = 10;
            // 
            // UcTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxTicket);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewTicket);
            Name = "UcTicket";
            Size = new Size(969, 452);
            groupBoxTicket.ResumeLayout(false);
            groupBoxTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPLZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTicket;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBoxCountry;
        private Label label11;
        private TextBox textBoxAddress;
        private Label label10;
        private Label label9;
        private TextBox textBoxLastname;
        private Label label8;
        private TextBox textBoxFirstName;
        private Label label5;
        private ComboBox comboBoxSeatRow;
        private Label label7;
        private Label label6;
        private CheckBox checkBoxIsPayd;
        private TextBox textBoxPayedPrice;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label3;
        private NumericUpDown numericUpDownSeatNumber;
        private Label label2;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxPerformance;
        private Label labelSeatRow;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewTicket;
        private ComboBox comboBoxCategorie;
        private NumericUpDown numericUpDownPLZ;
    }
}
