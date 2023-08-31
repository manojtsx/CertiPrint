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
    public partial class facilitatorStudentUserControl : UserControl
    {
        private facilitatorEditStudentRemarks FacilitatorEditStudentRemarks;
        public facilitatorStudentUserControl()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string query = "SELECT * FROM students";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Bind the data to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
        }
        public void addUserControlSecondPanel(UserControl userControl)
        {
            extraPanel.Controls.Clear();
            extraPanel.Controls.Add(userControl);
            extraPanel.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addRemarksButton_Click(object sender, EventArgs e)
        {
            FacilitatorEditStudentRemarks = new facilitatorEditStudentRemarks();
            string id = "";
            string remarks = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["id"].Value.ToString();
                remarks = selectedRow.Cells["remarks"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No rows selected..");
            }
            FacilitatorEditStudentRemarks.label7.Text = id;
            FacilitatorEditStudentRemarks.remarksField.Text = remarks;
            addUserControlSecondPanel(FacilitatorEditStudentRemarks);

        }
    }
}
   