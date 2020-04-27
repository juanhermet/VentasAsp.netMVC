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
    class CBank
    {
        Conexion conexion = new Conexion();
        public void addBank(Bank bank)
        {
            const string query = "INSERT INTO banks(code,mount,date,type) VALUES(@code,@mount,@date,@type)";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@code", bank.Code);
            command.Parameters.AddWithValue("@mount", bank.Mount);
            command.Parameters.AddWithValue("@date", DateTime.Now);
            command.Parameters.AddWithValue("@type", bank.ID);
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
        public void addBankToUser(Users user)
        {
            const string query = "INSERT INTO userbank(id_user,id_bank,date) VALUES(@user,@bank,@date)";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@user", user.Id);
            command.Parameters.AddWithValue("@bank", user.Bank.ID);
            command.Parameters.AddWithValue("@date", DateTime.Now);
            try
            {
                conexion.Open();
                int result = command.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("count added!!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
        }
        public Bank getBankByCode(string code)
        {
            List<Bank> banks = new List<Bank>();
            const string query = "SELECT id_bank,mount,type FROM banks WHERE code = @code";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@code", code);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["type"].ToString() == "VIP")
                    {
                        banks.Add(new VIPBank(Convert.ToInt32(reader["id_bank"]),
                        code, Convert.ToDouble(reader["mount"])));
                    }
                    else
                    {
                        banks.Add(new simpleBank(Convert.ToInt32(reader["id_bank"]),
                        code, Convert.ToDouble(reader["mount"])));
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
            return banks.FirstOrDefault();
        }
        public Bank getBankByUser(string user)
        {
            List<Bank> banks = new List<Bank>();
            const string query = "SELECT b.id_bank,b.code,b.mount,b.type FROM banks b JOIN userbank ub ON ub.id_bank = b.id_bank" +
                " JOIN users u ON u.id_user = ub.id_user WHERE u.user = @user";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@user", user);
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["type"].ToString() == "VIP")
                    {
                        banks.Add(new VIPBank(Convert.ToInt32(reader["id_bank"]),
                        reader["code"].ToString(), Convert.ToDouble(reader["mount"])));
                    }
                    else
                    {
                        banks.Add(new simpleBank(Convert.ToInt32(reader["id_bank"]),
                        reader["code"].ToString(), Convert.ToDouble(reader["mount"])));
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "there is an error:");
            }
            return banks.FirstOrDefault();
        }
        public void updateBank(Bank bank)
        {

            const string query = "UPDATE banks SET mount = @total WHERE id_bank = @id";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            command.Parameters.AddWithValue("@total", bank.Mount);
            command.Parameters.AddWithValue("@id", bank.ID);
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
        public int getNewId()
        {
            int id = 0;
            const string query = "SELECT id_bank FROM banks ORDER BY id_bank DESC LIMIT 1";
            MySqlCommand command = new MySqlCommand(query, conexion.get());
            try
            {
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id_bank"]);
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "there is an error:");
            }
            return id + 1;
        }

    }
}
