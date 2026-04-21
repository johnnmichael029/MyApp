using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyApp.Services
{
    internal class ConvertRecordsHelper
    {

        public MySqlConnection GetConnection()
        {
            string myConn = ConnectionStringHelper.ConnectionString;
            return new MySqlConnection(myConn);
        }
        public void SaveConvertRecord(double f, double c)
        {

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO convertrecords (Fahrenheit, Celsius) VALUES (@f, @c)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@f", f);
                        cmd.Parameters.AddWithValue("@c", c);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Database Error: " + ex.Message); }
            }
        }

        public DataTable GetAllRecords()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM convertrecords ORDER BY id DESC";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            return dt;
        }

    }
}
