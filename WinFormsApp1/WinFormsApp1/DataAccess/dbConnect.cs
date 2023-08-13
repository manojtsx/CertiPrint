using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Import the necessary namespace

//Install mysql.data
//Install nuget framework
//for installing go to tools 
//    nuget package manager
//    manage nuget packages for solution
//        search for the package in browse
namespace WinFormsApp1.DataAccess
{
    internal class dbConnect
    {
        public static string connectionString;
        public static MySqlConnection connection;
        public static MySqlConnection connect()
        {
            connectionString = "server=localhost;user=root;password=;database=certiprint;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return connection;
        }
    }
}
