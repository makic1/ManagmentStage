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
    public partial class UcLogin : UserControl
    {
        private readonly ServiceAccount _serviceAccount;
        private readonly FormMain _formMain;
        public UcLogin(FormMain formMain)
        {
            InitializeComponent();
            var context = new DbContextStageManagment();
            _serviceAccount = new ServiceAccount(context);

            textBoxPassword.PasswordChar = '*';
            _formMain = formMain;

            // todo: am schluss löschen
            textBoxUsername.Text = "admin";
            textBoxPassword.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginmodel = new LoginModel
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
            };

            var account = _serviceAccount.FindAccount(loginmodel.Username);

            if (account != null && BCrypt.Net.BCrypt.Verify(loginmodel.Password, account.HashPassword))
            {
                AuthService.Instance.Login(account.Username);
                _formMain.IsLoggedIn(true);
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
            }
        }
    }
}
