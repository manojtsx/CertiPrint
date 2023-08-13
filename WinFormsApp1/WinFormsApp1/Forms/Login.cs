using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DataAccess;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userTextField.Text;
            string password = passwordTextField.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {

            using (MySqlConnection connection = dbConnect.connect())
            {
                // Call the Connect method from the dbConnect class
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT COUNT(*) FROM facilitator WHERE username = @username AND password = @password";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            return count > 0;

                        }
                    }
                    catch (Exception ex)
                    {
                        Message.Show("Couldnot login");
                        return false;
                    }
                }
                //else
                //{
                //    // Handle connection error
                //    MessageBox.Show("Failed to establish a database connection.");
                //    return false;
                //}
            }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            userTextField.Text = "";
            passwordTextField.Text = "";


        }
    }
}
