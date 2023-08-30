using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class editFacilitatorUserControl : UserControl
    {
        public editFacilitatorUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                string updateQuery = "UPDATE facilitators SET username = @Value1, password = @Value2, subjectName = @Value4  WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value1", usernameField.Text);
                    command.Parameters.AddWithValue("@Value2", passwordField.Text);
                    command.Parameters.AddWithValue("@Value4", subjectField.Text);
                    command.Parameters.AddWithValue("@ID", label6.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data upated Successfully");
                }
            }
        }
    }
}
