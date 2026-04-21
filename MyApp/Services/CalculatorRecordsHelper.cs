using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MyApp.Services
{
    internal class CalculatorRecordsHelper
    {   
        
        public MySqlConnection GetConnection()
        {
            string myConn = ConnectionStringHelper.ConnectionString;
            return new MySqlConnection(myConn);
        }
        public void SaveRecord(double n1, double n2, double res)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    // Change 'your_table_name' to your actual table name
                    string query = "INSERT INTO calculatorrecords (Num1, Num2, Result) VALUES (@n1, @n2, @res)";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@n1", n1);
                        cmd.Parameters.AddWithValue("@n2", n2);
                        cmd.Parameters.AddWithValue("@res", res);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        public DataTable GetAllRecords()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM calculatorrecords ORDER BY id DESC";
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
