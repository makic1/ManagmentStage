using StageManagment.Entities;
using StageManagment.Service;

namespace StageManagment.Uc
{
    public partial class UcTicket : UserControl
    {
        private readonly ServiceTicket _serviceTicket;
        private readonly ServicePerformance _servicePerformance;
        private IsEdit _addOrEdit;
        public UcTicket()
        {
            InitializeComponent();
            var context = new DbContextStageManagment();
            _serviceTicket = new ServiceTicket(context);
            _servicePerformance = new ServicePerformance(context);

            LoadUi();
            ConfDatagrid();
            groupBoxTicket.Visible = false;
        }

        private void ConfDatagrid()
        {

            dataGridViewTicket.Columns["TicketId"].Visible = false;
            dataGridViewTicket.Columns["PerformanceId"].Visible = false;

            // Todo: Fertig übersetzen
            dataGridViewTicket.Columns["SeatRow"].HeaderText = "Reihe";
            dataGridViewTicket.Columns["SeatNumber"].HeaderText = "Platz";
            dataGridViewTicket.Columns["PriceInEuro"].HeaderText = "Preis(€)";
            dataGridViewTicket.Columns["PaydPriceInEuro"].HeaderText = "Bezahlt(€)";
            dataGridViewTicket.Columns["CustomerFirstname"].HeaderText = "Vorname";
            dataGridViewTicket.Columns["CustomerLastName"].HeaderText = "Nachname";
            dataGridViewTicket.Columns["CustomerCategorie"].HeaderText = "Kategorie";
            dataGridViewTicket.Columns["CustomerAddress"].HeaderText = "Adresse";
        }

        private void LoadUi()
        {
            dataGridViewTicket.DataSource = _serviceTicket.GetAllTickets();
            comboBoxCategorie.DataSource = Enum.GetValues(typeof(CustomerCategorie));
            comboBoxSeatRow.DataSource = Enum.GetValues(typeof(SeatRow));
            comboBoxPerformance.DataSource = _servicePerformance.GetAllActivPerformance();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateTicket().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateTicket()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var performance = (Performance)comboBoxPerformance.SelectedItem;

            var ticket = new Ticket
            {
                SeatRow = (SeatRow)comboBoxSeatRow.SelectedItem,
                SeatNumber = Convert.ToInt32(numericUpDownSeatNumber.Value),
                PriceInEuro = Convert.ToDecimal(textBoxPrice.Text),
                PaydPriceInEuro = Convert.ToDecimal(textBoxPayedPrice.Text),
                CustomerFirstname = string.IsNullOrWhiteSpace(textBoxFirstName.Text) ? null : textBoxFirstName.Text,
                CustomerLastname = textBoxLastname.Text,
                CustomerCategorie = (CustomerCategorie)comboBoxCategorie.SelectedItem,
                CustomerAddress = textBoxAddress.Text,
                CustomerCountry = textBoxCountry.Text,
                CustomerPLZ = Convert.ToInt32(numericUpDownPLZ.Value),
                PerformanceId = performance.PerformanceId,
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_serviceTicket.CheckForDuplicateTickets(ticket))
                {
                    MessageBox.Show("Dieses Ticket gibt es schon");
                    return;
                }
                _serviceTicket.AddTicket(ticket);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                ticket.TicketId = CurrentTicketId();
                _serviceTicket.UpdateTicket(ticket);
            }
            LoadUi();
            groupBoxTicket.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxTicket.Visible = true;

            comboBoxSeatRow.SelectedItem = null;
            numericUpDownSeatNumber.Value = 1;
            textBoxPrice.Text = "0";
            textBoxPayedPrice.Text = "0";
            textBoxFirstName.Text = "Nicht Verkauft";
            textBoxLastname.Text = "Nicht Verkauft";
            comboBoxCategorie.SelectedItem = null;
            textBoxAddress.Text = "Nicht Verkauft";
            textBoxCountry.Text = "Nicht Verkauft";
            numericUpDownPLZ.Value = 1;
            comboBoxPerformance.SelectedItem = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxTicket.Visible = true;

            var ticket = _serviceTicket.FindTicketById(CurrentTicketId());

            comboBoxSeatRow.SelectedItem = ticket.SeatRow;
            numericUpDownSeatNumber.Value = ticket.SeatNumber;
            textBoxPrice.Text = ticket.PriceInEuro.ToString();
            textBoxPayedPrice.Text = ticket.PaydPriceInEuro.ToString();
            textBoxFirstName.Text = ticket.CustomerFirstname;
            textBoxLastname.Text = ticket.CustomerLastname;
            comboBoxCategorie.SelectedItem = ticket.CustomerCategorie;
            textBoxAddress.Text = ticket.CustomerAddress;
            textBoxCountry.Text = ticket.CustomerCountry;
            numericUpDownPLZ.Value = Convert.ToInt32(ticket.CustomerPLZ);
            comboBoxPerformance.SelectedItem = ticket.PerformanceId;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie dieses Ticket löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceTicket.RemoveTicketById(CurrentTicketId());
                LoadUi();
            }
        }

        private int CurrentTicketId()
        {
            return Convert.ToInt32(dataGridViewTicket.SelectedRows[0].Cells[0].Value);
        }

        public List<string> ValidateTicket()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) && textBoxPrice.Text == "0")
            {
                errors.Add("Geben sie bitte einen Preis ein");
            }
            if (comboBoxSeatRow.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte eine Reihe aus");
            }
            if (comboBoxPerformance.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte eine Vorstellung aus");
            }
            if (comboBoxCategorie.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte eine Categorie aus fals noch nicht verkauft dann wähle NichtVerkauft");
            }
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) && string.IsNullOrWhiteSpace(textBoxLastname.Text) && string.IsNullOrWhiteSpace(textBoxAddress.Text) && string.IsNullOrWhiteSpace(textBoxCountry.Text))
            {
                errors.Add("Die Felder Vorname, Nachname, Adresse, Stadt dürfen nicht leer sein falls das Ticket noch nicht verkauft wurde dann trage Nicht Verkauft ein");
            }
            if (string.IsNullOrWhiteSpace(textBoxPayedPrice.Text))
            {
                errors.Add("Bitte geben sie den bezahlten preis ein falls noch nicht Verkauft trage 0 ein");
            }
            return errors;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxPayedPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back);
        }

        private enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
