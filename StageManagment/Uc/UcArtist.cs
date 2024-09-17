using StageManagment.Entities;
using StageManagment.Service;

namespace StageManagment.Uc
{
    public partial class UcArtist : UserControl
    {
        private readonly ServiceArtist _serviceArtist;
        private IsEdit _addOrEdit;

        public UcArtist()
        {
            InitializeComponent();
            var context = new DbContextStageManagment();
            _serviceArtist = new ServiceArtist(context);

            LoadUi();
            ConfDatagrid();
            groupBoxArtist.Visible = false;
        }

        /// <summary>
        /// Delete columns and rename columns
        /// </summary>
        private void ConfDatagrid()
        {
            dataGridViewArtist.Columns["ArtistId"].Visible = false;
            dataGridViewArtist.Columns["ProgramStages"].Visible = false;

            dataGridViewArtist.Columns["ArtistCategorie"].HeaderText = "Kategorie";
        }

        /// <summary>
        /// Load artist in datagrid and load categorie in combobox
        /// </summary>
        private void LoadUi()
        {
            dataGridViewArtist.DataSource = _serviceArtist.GetAllArtists();
            comboBoxArtistCategorie.DataSource = Enum.GetValues(typeof(ArtistCategorie));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateArtist().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateArtist()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artist = new Artist
            {
                Name = textBoxName.Text,
                ArtistCategorie = (ArtistCategorie)comboBoxArtistCategorie.SelectedItem,
            };
            if (_addOrEdit == IsEdit.Add)
            {
                if (_serviceArtist.CheckForDuplicateArtist(artist))
                {
                    MessageBox.Show("Diesen Artist gibt es schon");
                    return;
                }
                _serviceArtist.AddArtist(artist);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                artist.ArtistId = CurrentArtistId();
                _serviceArtist.UpdateArtist(artist);
            }
            LoadUi();
            groupBoxArtist.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxArtist.Visible = true;

            textBoxName.Clear();
            comboBoxArtistCategorie.SelectedItem = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxArtist.Visible = true;

            var artist = _serviceArtist.FindArtistById(CurrentArtistId());

            textBoxName.Text = artist.Name;
            comboBoxArtistCategorie.SelectedItem = artist.ArtistCategorie;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie den ausgewählten Künstler löschen möchten", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceArtist.RemoveArtistById(CurrentArtistId());
                LoadUi();
            }
        }

        /// <summary>
        /// Validate the artist inputfields
        /// </summary>
        /// <returns>a list of errors</returns>
        public List<string> ValidateArtist()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errors.Add("Geben sie bitte den Namen des Künstlers ein");
            }
            if (comboBoxArtistCategorie.SelectedItem is null)
            {
                errors.Add("Wählen sie bitte eine Kategorie vom Künstler aus");
            }
            return errors;
        }

        /// <summary>
        /// Get the selectes artistId
        /// </summary>
        /// <returns>the current selected artistid</returns>
        private int CurrentArtistId()
        {
            return Convert.ToInt32(dataGridViewArtist.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
        }

        /// <summary>
        /// Add, Edit
        /// </summary>
        public enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
