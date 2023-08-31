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
    public partial class facilitatorHomePageUserControlDown : UserControl
    {
        public facilitatorHomePageUserControlDown()
        {
            InitializeComponent();
            UpdateStudentCount();
            UpdateFacilitatorCount();
        }

        private void facilitatorHomePageUserControlDown_Load(object sender, EventArgs e)
        {

        }
        private void UpdateStudentCount()
        {
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM students";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int studentCount = (int)command.ExecuteScalar();
                    studentNumber.Text = studentCount.ToString();
                }
            }
        }
        private void UpdateFacilitatorCount()
        {
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM facilitators";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int studentCount = (int)command.ExecuteScalar();
                    facilitatorNumber.Text = studentCount.ToString();
                }
            }
        }
    }
}
