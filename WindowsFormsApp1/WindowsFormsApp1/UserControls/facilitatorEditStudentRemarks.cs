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
    public partial class facilitatorEditStudentRemarks : UserControl
    {
        public facilitatorEditStudentRemarks()
        {
            InitializeComponent();
        }

        private void remarksField_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the edited data in the database
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string updateQuery = "UPDATE students SET remarks = @Value4  WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value4", remarksField.Text);
                    command.Parameters.AddWithValue("@ID", label7.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data upated Successfully");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
