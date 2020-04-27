using LSPSolution.Business;
using LSPSolution.Entities;
using LSPSolution.Singleton;
using LSPSolution.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPSolution
{
    public partial class Login : Form
    {
        CUsers users = new CUsers();
        CBank cbank = new CBank();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (users.confirmLogin(txtUser.Text, txtPass.Text))
            {
                Users user = users.getUserByName(txtUser.Text);
                user.Bank = cbank.getBankByUser(user.User);
                SUsers.setInstance(user);
                Principal principal = new Principal();
                Hide();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("there is no user with this password or user", "there is an error:");
            }
        }
    }
}
