using StageManagment.Entities;
using StageManagment.Service;

namespace StageManagment.Uc
{
    public partial class UcProgramStage : UserControl
    {
        private readonly ServiceProgramStage _serviceProgramStage;
        private readonly ServiceArtist _serviceArtist;
        private IsEdit _addOrEdit;

        public UcProgramStage()
        {
            InitializeComponent();
            var context = new DbContextStageManagment();
            _serviceArtist = new ServiceArtist(context);
            _serviceProgramStage = new ServiceProgramStage(context);

            LoadUi();
            ConfDatagrid();
            groupBoxProgramStage.Visible = false;
        }

        private void ConfDatagrid()
        {
            dataGridViewProgramStage.Columns["ProgramStageId"].Visible = false;
            dataGridViewProgramStage.Columns["ArtistId"].Visible = false;
            dataGridViewProgramStage.Columns["Performances"].Visible = false;

            dataGridViewProgramStage.Columns["DurationInMinutes"].HeaderText = "Dauer(min)";
            dataGridViewProgramStage.Columns["PriceInEuro"].HeaderText = "Preis(€)";
            dataGridViewProgramStage.Columns["StartPriceInEuro"].HeaderText = "Anzahlung(€)";
            dataGridViewProgramStage.Columns["EndPriceInEuro"].HeaderText = "Schlusszahlung(€)";
            dataGridViewProgramStage.Columns["IsPayd"].HeaderText = "Bezahlt";
            dataGridViewProgramStage.Columns["Artist"].HeaderText = "Künstler";
        }

        private void LoadUi()
        {
            dataGridViewProgramStage.DataSource = _serviceProgramStage.GetAllProgramStages();
            comboBoxArtist.DataSource = _serviceArtist.GetAllArtists();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateProgramStage().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateProgramStage()), "Vllidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artist = (Artist)comboBoxArtist.SelectedItem;

            var programStage = new ProgramStage
            {
                Name = textBoxName.Text,
                DurationInMinutes = Convert.ToUInt32(numericUpDownDuration.Value),
                PriceInEuro = Convert.ToDecimal(textBoxPrice.Text),
                StartPriceInEuro = Convert.ToDecimal(textBoxStartPrice.Text),
                EndPriceInEuro = Convert.ToDecimal(textBoxEndPrice.Text),
                IsPayd = checkBoxIsPayd.Checked,
                ArtistId = artist.ArtistId
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_serviceProgramStage.CheckForDuplicateProgramStage(programStage))
                {
                    MessageBox.Show("Dieses Programm von diesem Artist gibt es schon");
                    return;
                }
                _serviceProgramStage.AddProgramStage(programStage);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                programStage.ProgramStageId = CurrentProgramStageId();
                _serviceProgramStage.UpdateProgramStage(programStage);
            }
            LoadUi();
            groupBoxProgramStage.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxProgramStage.Visible = true;

            textBoxName.Clear();
            textBoxPrice.Text = "0";
            textBoxStartPrice.Text = "0";
            textBoxEndPrice.Text = "0";
            numericUpDownDuration.Value = 0;
            checkBoxIsPayd.Checked = false;
            comboBoxArtist.SelectedItem = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxProgramStage.Visible = true;

            var programStage = _serviceProgramStage.FindProgramStageById(CurrentProgramStageId());

            textBoxName.Text = programStage.Name;
            textBoxPrice.Text = programStage.PriceInEuro.ToString();
            textBoxStartPrice.Text = programStage.StartPriceInEuro.ToString();
            textBoxEndPrice.Text = programStage.EndPriceInEuro.ToString();
            numericUpDownDuration.Value = programStage.DurationInMinutes;
            checkBoxIsPayd.Checked = programStage.IsPayd;
            comboBoxArtist.SelectedItem = programStage.Artist;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie dieses Program löschen möchten", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceProgramStage.DeleteProgramStageById(CurrentProgramStageId());
                LoadUi();
            }
        }

        private int CurrentProgramStageId()
        {
            return Convert.ToInt32(dataGridViewProgramStage.SelectedRows[0].Cells[0].Value);
        }

        private List<string> ValidateProgramStage()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errors.Add("Bitte name eingeben");
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                errors.Add("Geben sie bitte einen Preis ein");
            }
            if (string.IsNullOrWhiteSpace(textBoxStartPrice.Text))
            {
                errors.Add("Geben sie bitte eine Anzahlung ein falls nichts dann 0");
            }
            if (string.IsNullOrWhiteSpace(textBoxEndPrice.Text))
            {
                errors.Add("Geben sie bitte eine Schlusszahlung ein falls nichts dann 0");
            }
            if (comboBoxArtist.SelectedItem == null)
            {
                errors.Add("Wählen sie Bitte einen Artist aus");
            }
            if (numericUpDownDuration.Value == 0)
            {
                errors.Add("Geben sie bitte die Dauer ein");
            }

            return errors;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxStartPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxEndPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
