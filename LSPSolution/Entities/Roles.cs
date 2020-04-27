using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Entities
{
    class Roles
    {
        int id;
        string role;

        public Roles(int id, string role)
        {
            this.id = id;
            this.role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Role { get => role; set => role = value; }
    }
}
