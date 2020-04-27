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
    class CUsers
    {
        Conexion conexion = new Conexion();
        public bool confirmLogin(string user, string pass)
        {
            const string query = "select id_user FROM users WHERE user=@user AND password=@pass";
            int id = 0;
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["id_user"].ToString());
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
            return (id > 0);
        }
        public void addUser(Users user)
        {
            const string query = "INSERT INTO users(user,password,name,last_name,role) VALUES(@user,@pass,@name,@last,@role)";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@user", user.User);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@last", user.LastName);
            command.Parameters.AddWithValue("@role", user.Role.Id);
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
        public Users getUserByName(string username)
        {
            CRoles rol = new CRoles();
            CBank cbank = new CBank();
            int idRole = 0;
            List<Users> luser = new List<Users>();
            const string query = "SELECT id_user,user,password,name,last_name,role FROM users WHERE user = @user";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@user", username);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idRole = Convert.ToInt32(reader["role"]);
                    Users users = new Users(Convert.ToInt32(reader["id_user"]), reader["user"].ToString(), reader["password"].ToString(),
                        reader["name"].ToString(), reader["last_name"].ToString());
                    luser.Add(users);
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error");
            }
            Users user = luser.First();
            user.Role = rol.getRole(idRole).FirstOrDefault();
            return user;
        }
        public void transfer(Users emisor, Users receptor, double amount)
        {
            CBank bani = new CBank();
            if (emisor.Bank != null)
            {
                if (receptor.Bank != null)
                {

                    emisor.Bank.extract(amount);
                    receptor.Bank.deposit(amount);
                    bani.updateBank(emisor.Bank);
                    bani.updateBank(receptor.Bank);
                }
                else
                {
                    MessageBox.Show("this receptor user hasn't a bank count, please insert another receptor", "there is an error:");
                }
            }
            else
            {
                MessageBox.Show("this emisor user hasn't a bank count, please insert another emisor", "there is an error:");
            }
        }
        public Users getUserByCode(string code)
        {
            List<Users> lu = new List<Users>();
            CRoles rol = new CRoles();
            CBank cbank = new CBank();
            int role = 0;
            const string query = "SELECT u.id_user,u.user,u.password,u.name,u.last_name,u.role FROM users u JOIN userbank ub " +
                "ON u.id_user = ub.id_user JOIN banks b ON b.id_bank = ub.id_bank WHERE b.code = @code";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@code", code);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    role = Convert.ToInt32(reader["role"]);
                    lu.Add(new Users(Convert.ToInt32(reader["id_user"]), reader["user"].ToString(),
                        reader["password"].ToString(), reader["name"].ToString(), reader["last_name"].ToString()));
                }
                conexion.Close();
                MessageBox.Show("transfer successful", "operation successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
            Users user = lu.FirstOrDefault();
            user.Role = rol.getRole(role).First();
            user.Bank = cbank.getBankByCode(code);
            return user;
        }
    }
}
