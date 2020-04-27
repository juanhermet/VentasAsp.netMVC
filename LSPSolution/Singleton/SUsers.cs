using LSPSolution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Singleton
{
    class SUsers
    {
        private static Users instance = null;

        public static void setInstance(Users user)
        {
            if (instance == null)
            {
                instance = user;
            }
        }
        public static Users getInstance()
        {
            return instance;
        }
        public static string getRole()
        {
            return instance.Role.Role;
        }
        public static Bank getBank()
        {
            return instance.Bank;
        }
    }
}
