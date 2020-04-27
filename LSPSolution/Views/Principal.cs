using LSPSolution.Business;
using LSPSolution.Entities;
using LSPSolution.Singleton;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPSolution.Views
{
    public partial class Principal : Form
    {
        CBank cBank = new CBank();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string amount = Interaction.InputBox("please, insert the amount what you could deposit.", "do a deposit");
            Users user = SUsers.getInstance();
            user.Bank.deposit(Convert.ToDouble(amount));
            cBank.updateBank(user.Bank);
            MessageBox.Show("cash added!!!", "successful operation");
            Principal_Load(sender, e);
        }

        private void btnExtraction_Click(object sender, EventArgs e)
        {
            string amount;
            if (SUsers.getBank().Type == "VIP")
            {
                amount = Interaction.InputBox("please, insert the amount what you could extract", "do an extract");
            }
            else
            {
                amount = Interaction.InputBox("please, insert the amount what you could extract, you have a 20% of surcharge.", "do an extract");
            }

            Users user = SUsers.getInstance();
            user.Bank.extract(Convert.ToDouble(amount));
            cBank.updateBank(user.Bank);
            MessageBox.Show("cash extracted!!!", "successful operation");
            Menu_Load(sender, e);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblName.Text = SUsers.getInstance().Name;
            lblLastName.Text = SUsers.getInstance().LastName;
            lblRole.Text = SUsers.getRole();
            if (SUsers.getRole() != "Admin")
            {
                btnCreateUser.Visible = false;
                btnRole.Visible = false;
            }
            if (SUsers.getBank() == null)
            {
                gbBank.Visible = false;
                btnFixedT.Visible = false;
            }
            else
            {
                btnAddBank.Visible = false;
                gbBank.Visible = true;
                btnFixedT.Visible = true;
                gbBank.Text = SUsers.getInstance().Bank.Type;
                lblCode.Text = SUsers.getBank().Code;
                lblMount.Text = SUsers.getBank().Mount.ToString();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            CUsers cuser = new CUsers();
            string userstng = Interaction.InputBox("please, insert the user's code that you want to transfer.", "insert code:");
            double amount = Convert.ToDouble(Interaction.InputBox("please, insert the amount that you want to transfer.", "insert amount:"));
            if (userstng != null & amount != 0)
            {
                Users receptor = cuser.getUserByCode(userstng);
                Users emisor = SUsers.getInstance();
                cuser.transfer(emisor, receptor, amount);
                Menu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("please, insert a code count or amount to process", "there is an error:");
            }
        }
    }
}
