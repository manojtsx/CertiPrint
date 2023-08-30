using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private adminUserControl AdminUserControl;
        private facilitatorHomepageUserControl FacilitatorHomepageUserControl;
        private dbConnect DBConnect; 
        public Login()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void addUserControlMainPanel(UserControl userControl)
        {
            mainPanelContainer.Controls.Clear();
            mainPanelContainer.Controls.Add(userControl);
            mainPanelContainer.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            string userrole = "";
            if (userroleField.SelectedItem != null)
            {
                userrole = userroleField.SelectedItem.ToString();
            }

            if (username == "" || password == "" | userrole == "")
            {
                MessageBox.Show("Please fill the login details first.");
            }
            else
            {
                DBConnect = new dbConnect();
                if (userrole == "admin")
                {
                    using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
                    {
                        connection.Open();
                        try
                        {
                            string query = "SELECT COUNT(*) FROM admins WHERE Username = @Username AND Password = @Password";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", password);

                                int count = (int)command.ExecuteScalar();

                                if (count > 0)
                                {
                                    // Successful login
                                    MessageBox.Show("Login successful!");

                                    AdminUserControl = new adminUserControl();
                                    addUserControlMainPanel(AdminUserControl);
                                    // Perform user control change or other navigation here
                                }
                                else
                                {
                                    // Invalid login
                                    MessageBox.Show("Invalid login credentials.");
                                }
                            }

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
                        {
                            connection.Open();
                            string query = "SELECT COUNT(*) FROM facilitators WHERE Username = @Username AND Password = @Password";
                            using (SqlCommand command = new SqlCommand(query,connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", password);

                                int count = (int)command.ExecuteScalar();

                                if (count > 0)
                                {
                                    // Successful login
                                    MessageBox.Show("Login successful!");

                                    FacilitatorHomepageUserControl = new facilitatorHomepageUserControl();
                                    addUserControlMainPanel(FacilitatorHomepageUserControl);
                                    // Perform user control change or other navigation here
                                }
                                else
                                {
                                    // Invalid login
                                    MessageBox.Show("Invalid login credentials.");
                                }
                            }

                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernameField.Text = "";
            passwordField.Text = "";
            userroleField.Text = "admin";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void mainPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void RestartApplication()
        {
            string fileName = Application.ExecutablePath;
            string arguments = string.Join(" ", Environment.GetCommandLineArgs());

            Process.Start(fileName, arguments);
            Environment.Exit(0); // Exit the current instance of the application
        }
    }
}
