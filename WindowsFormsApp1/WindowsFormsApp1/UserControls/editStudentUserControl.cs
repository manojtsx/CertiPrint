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
    public partial class editStudentUserControl : UserControl
    {
        public editStudentUserControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update the edited data in the database
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string updateQuery = "UPDATE students SET grade = @Value1, gpa = @Value2, name = @Value3, remarks = @Value4,username = @Value5, password = @Value6  WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value1", gradeField.Text);
                    command.Parameters.AddWithValue("@Value2", gpaField.Text);
                    command.Parameters.AddWithValue("@Value3", nameField.Text);
                    command.Parameters.AddWithValue("@Value4", remarksField.Text);
                    command.Parameters.AddWithValue("@ID", label7.Text);
                    command.Parameters.AddWithValue("@Value5",usernameField.Text);  
                    command.Parameters.AddWithValue("@Value6",passwordField.Text);  
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data upated Successfully");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editStudentUserControl_Load(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpaField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
