using SuperMarketApp2.Models;
using SuperMarketApp2.PresentationLayers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SuperMarketApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var inputUsername = txtUserName.Text;
            var inputPassword = txtPswd.Text;
            var message = Users.LoginProcess(inputUsername, inputPassword);
            switch (message)
            {
                case "1":
                    new AdminHomePage().ShowDialog();
                    break;
                case "2":
                    new SalesPage().ShowDialog();
                    break;
                default:
                    MessageBox.Show(message, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            txtUserName.Clear();
            txtPswd.Clear();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                epLogin.SetError(txtUserName, "User Name cannot be empty!");
                btnLogin.Enabled = false;
            }
            else
            {
                epLogin.SetError(txtUserName, null);
            }
        }

        private void txtPswd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPswd.Text))
            {
                e.Cancel = true;
                txtPswd.Focus();
                epLogin.SetError(txtPswd, "Password cannot be empty!");
                btnLogin.Enabled = false;
            }
            else
            {
                epLogin.SetError(txtPswd, null);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPswd.Text != "")
            {
                btnLogin.Enabled = true;
            }
        }
        #endregion
    }
}
