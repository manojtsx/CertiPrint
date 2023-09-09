using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class addFacilitatorUserControl : UserControl
    {
        private dbConnect DBConnect;
        public addFacilitatorUserControl()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect = new dbConnect();
            try
            {
                // Create a SQL INSERT query based on your data
                string insertQuery = "INSERT INTO facilitators(username,password,subjectName) VALUES (@Username,@Password,@Subject)";

                // Assuming you have two textboxes named textBox1 and textBox2 for input
                using (SqlCommand dbCommand = new SqlCommand(insertQuery))
                {
                  
                    dbCommand.Parameters.AddWithValue("@Username", usernameField.Text);
                    dbCommand.Parameters.AddWithValue("@Password", passwordField.Text);
     
                    dbCommand.Parameters.AddWithValue("@Subject", subjectField.Text);
                   

                
                    int rowsAffected = DBConnect.executeQuery(dbCommand);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}

