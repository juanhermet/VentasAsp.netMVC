using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Business
{
    class Conexion
    {
        MySqlConnection connection;
        public Conexion()
        {
            const string con = @"Server=127.0.0.1;Database=lsp;Uid=root;password=root;";
            connection = new MySqlConnection(con);
        }
        public MySqlConnection get()
        {
            return connection;
        }
        public bool isOpened()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
    }
}
