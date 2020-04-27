using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPSolution.Entities
{
    class VIPBank : Bank
    {
        public VIPBank(int id, string code, double mount) : base(id, code, mount)
        {
            interest = 0.5;
            type = "VIP";
        }
        public override void deposit(double mount)
        {
            this.mount += mount;
        }
        public override void extract(double mount)
        {
            if (this.mount - mount > 0)
            {
                this.mount -= mount;
            }
            else
            {
                MessageBox.Show("the amount you want to withdraw exceeds the amount you have in your account.", "there is an error:");
            }
        }
    }
}
