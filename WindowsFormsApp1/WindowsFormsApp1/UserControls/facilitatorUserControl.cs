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
    public partial class facilitatorUserControl : UserControl
    {
        private addFacilitatorUserControl AddFacilitatorUserControl;
        private editFacilitatorUserControl EditFacilitatorUserControl;
        public facilitatorUserControl()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string query = "SELECT * FROM facilitators";
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
            facilitatorExtraPanel.Controls.Clear();
            facilitatorExtraPanel.Controls.Add(userControl);
            facilitatorExtraPanel.BringToFront();
        }

        private void facilitatorUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void facilitatorExtraPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditFacilitatorUserControl = new editFacilitatorUserControl();
            string id = "";
            string username = "";
            string password = "";
            string subject = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["id"].Value.ToString();
                username = selectedRow.Cells["username"].Value.ToString();
                password = selectedRow.Cells["password"].Value.ToString();
                subject = selectedRow.Cells["subjectName"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No rows selected..");
            }
            EditFacilitatorUserControl.label6.Text = id;
            EditFacilitatorUserControl.usernameField.Text = username;
            EditFacilitatorUserControl.passwordField.Text = password;
            EditFacilitatorUserControl.subjectField.Text = subject;
            addUserControlSecondPanel(EditFacilitatorUserControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFacilitatorUserControl = new addFacilitatorUserControl();
            addUserControlSecondPanel(AddFacilitatorUserControl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM students";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the value of the primary key from the selected row (assuming the ID is stored in the first column)
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(dbConnect.strConnString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM facilitators WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", idToDelete);
                        command.ExecuteNonQuery();
                    }

                    // Refresh the DataGridView after deletion
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }

        }
    }
}
