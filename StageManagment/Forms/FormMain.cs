using StageManagment.Uc;

namespace StageManagment
{
    public partial class FormMain : Form
    {

        private UcLogin _ucLogin;
        public FormMain()
        {
            InitializeComponent();

            if (_ucLogin is null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcLogin(this));
            }
            panelMain.Controls.Add(_ucLogin);
        }

        public void IsLoggedIn(bool isLoggedIn)
        {
            if (isLoggedIn)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcManageUsercontrols());
            }
        }
    }
}
