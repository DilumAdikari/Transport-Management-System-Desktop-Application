using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Trnasport_management_system;

namespace TransportManagementSystem
{
    internal static class Program
    {
        // Centralized DB Connection String
        public static string ConnString = "server=127.0.0.1;user=root;database=transport_db;password=;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // App eka start weddima Database connection eka test kirima
            if (TestDatabaseConnection())
            {
                // DB eka connect unoth witharak LoginForm eka open wenawa
                Application.Run(new LoginForm());
            }
            else
            {
                // DB fail nam app eka exit wenawa
                Application.Exit();
            }
        }

        private static bool TestDatabaseConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Database connection failed!\nMake sure XAMPP MySQL is running.\n\nError: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return false;
                }
            }
        }
    }
}