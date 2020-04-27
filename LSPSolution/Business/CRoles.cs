using LSPSolution.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPSolution.Business
{
    class CRoles
    {
        Conexion conexion = new Conexion();

        public void addRole(Roles role)
        {
            const string query = "INSERT INTO roles(role) VALUES(@role)";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@role", role.Role);
            try
            {
                conexion.Open();
                int result = command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
        }
        public void deleteRole(Roles role)
        {
            const string query = "DELETE FROM roles WHERE id_role = @id";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@id", role.Id);
            try
            {
                conexion.Open();
                int result = command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
        }
        public List<Roles> getRole(int id)
        {
            List<Roles> lr = new List<Roles>();
            const string query = "SELECT role FROM roles WHERE id_role=@id";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@id", id);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lr.Add(new Roles(id, reader["role"].ToString()));
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
            return lr;
        }
    }
}
