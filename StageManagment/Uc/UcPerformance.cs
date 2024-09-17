using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Web.WebView2.Core;
using StageManagment.Entities;
using StageManagment.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageManagment.Uc
{
    public partial class UcPerformance : UserControl
    {
        private readonly ServicePerformance _servicePerformance;
        private readonly ServiceProgramStage _serviceProgramStage;
        private IsEdit _addOrEdit;

        public UcPerformance()
        {
            InitializeComponent();
            var context = new DbContextStageManagment();
            _servicePerformance = new ServicePerformance(context);
            _serviceProgramStage = new ServiceProgramStage(context);

            LoadUi();
            ConfDataGridAndDateTimePicker();
            groupBoxPerformance.Visible = false;
        }

        private void ConfDataGridAndDateTimePicker()
        {
            dateTimePickerStartPerfromance.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartPerfromance.CustomFormat = "dd/mm/yyyy HH:mm:ss";

            dateTimePickerEndPerformance.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndPerformance.CustomFormat = "dd/mm/yyy HH:mm:ss";

            dataGridViewPerformance.Columns["PerformanceId"].Visible = false;
            dataGridViewPerformance.Columns["ProgramStageId"].Visible = false;
            dataGridViewPerformance.Columns["Tickets"].Visible = false;

            dataGridViewPerformance.Columns["StartPerformance"].HeaderText = "Begin";
            dataGridViewPerformance.Columns["EndPerformance"].HeaderText = "Ende";
            dataGridViewPerformance.Columns["IsActive"].HeaderText = "Aktiv";
            dataGridViewPerformance.Columns["ProgramStage"].HeaderText = "Program";
        }

        private void LoadUi()
        {
            dataGridViewPerformance.DataSource = _servicePerformance.GetAllPerformances();
            comboBoxProgram.DataSource = _serviceProgramStage.GetAllProgramStages();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidatePerformance().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidatePerformance()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var program = (ProgramStage)comboBoxProgram.SelectedItem;

            var performance = new Performance
            {
                Name = textBoxName.Text,
                StartPerformance = dateTimePickerStartPerfromance.Value,
                EndPerformance = dateTimePickerEndPerformance.Value,
                IsActive = checkBoxIsActiv.Checked,
                ProgramStageId = program.ProgramStageId
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_servicePerformance.CheckForDuplicatePerformance(performance))
                {
                    MessageBox.Show("Diese Show gibt es schon");
                    return;
                }
                _servicePerformance.AddPerformance(performance);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                performance.PerformanceId = CurrentPerfromanceId();
                _servicePerformance.UpdatePerformance(performance);
            }
            LoadUi();
            groupBoxPerformance.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxPerformance.Visible = true;

            textBoxName.Clear();
            checkBoxIsActiv.Checked = false;
            comboBoxProgram.SelectedItem = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxPerformance.Visible = true;

            var performance = _servicePerformance.FindPerformanceById(CurrentPerfromanceId());

            textBoxName.Text = performance.Name;
            dateTimePickerStartPerfromance.Value = performance.StartPerformance;
            dateTimePickerEndPerformance.Value = performance.EndPerformance;
            checkBoxIsActiv.Checked = performance.IsActive;
            comboBoxProgram.SelectedItem = performance.ProgramStage;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie diese Vorstellung löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _servicePerformance.DeletePerformanceById(CurrentPerfromanceId());
                LoadUi();
            }
        }

        public List<string> ValidatePerformance()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errors.Add("Geben sie bitte einen Namen ein");
            }
            if (comboBoxProgram.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte ein Program aus");
            }
            if (dateTimePickerStartPerfromance.Value > dateTimePickerEndPerformance.Value)
            {
                errors.Add("Start muss vor Ende liegen");
            }

            return errors;
        }

        private int CurrentPerfromanceId()
        {
            return Convert.ToInt32(dataGridViewPerformance.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
