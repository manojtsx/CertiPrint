using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class addStudentUserControl : UserControl
    {
        private dbConnect DBConnect;
        private studentUserControl StudentUserControl;
        public addStudentUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect = new dbConnect();
            try
            {
                // Create a SQL INSERT query based on your data
                string insertQuery = "INSERT INTO students(username,password,name, grade,gpa,remarks) VALUES (@Username,@Password,@Name,@Grade,@GPA,@Remarks)";

                // Assuming you have two textboxes named textBox1 and textBox2 for input
                using (SqlCommand dbCommand = new SqlCommand(insertQuery))
                {
                  
                    dbCommand.Parameters.AddWithValue("@Username", usernameField.Text);
                    dbCommand.Parameters.AddWithValue("@Password", passwordField.Text);
                    dbCommand.Parameters.AddWithValue("@Name", nameField.Text);
                    dbCommand.Parameters.AddWithValue("@Grade", gradeField.Text);
                    dbCommand.Parameters.AddWithValue("@GPA", gpaField.Text);
                    dbCommand.Parameters.AddWithValue("@Remarks", remarksField.Text);
             
                    int rowsAffected = DBConnect.executeQuery(dbCommand);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed.");
                    }
                    StudentUserControl = new studentUserControl();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void addStudentUserControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
