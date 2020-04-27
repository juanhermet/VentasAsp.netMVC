using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Entities
{
    class Users
    {
        int id;
        string user;
        string password;
        string name;
        string lastName;
        Bank bank;
        Roles role;
        public Users(int id, string user, string password, string name, string lastName)
        {
            this.id = id;
            this.user = user;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Bank Bank { get => bank; set => bank = value; }
        public Roles Role { get => role; set => role = value; }
    }
}
