using MySqlConnector;
using System;
using System.Windows.Forms;

namespace MyApp.Services
{
    public class DatabaseHelper
    {
        // Change 'your_database_name' to the name you just created in phpMyAdmin
        private string connectionString = "Server=localhost;Database=activitydb;User ID=root;Password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("XAMPP Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
