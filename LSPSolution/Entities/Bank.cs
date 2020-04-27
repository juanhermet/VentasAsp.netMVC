using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Entities
{
    abstract class Bank
    {
        protected int id;
        protected string code;
        protected string type;
        protected double mount;
        protected double interest;
        public Bank(int id, string code, double mount)
        {
            this.id = id;
            this.code = code;
            this.mount = mount;
        }
        public abstract void extract(double mount);
        public abstract void deposit(double mount);
        public int ID { get => id; }
        public string Code { get => code; }
        public string Type { get => type; }
        public double Mount { get => mount; }

    }
}
