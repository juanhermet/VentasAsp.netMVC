using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Entities
{
    class simpleBank : Bank
    {
        public simpleBank(int id, string code, double mount) : base(id, code, mount)
        {
            this.interest = 0.3;
            this.type = "simple";
        }
        public override void extract(double mount)
        {
            if (this.mount - (mount * 1.2) > 0)
            {
                this.mount -= (mount * 1.2);
            }
            else
            {
                MessageBox.Show("the amount you want to withdraw exceeds the amount you have in your account.", "there is an error:");
            }
        }
        public override void deposit(double mount)
        {
            this.mount += mount;
        }
    }
}
