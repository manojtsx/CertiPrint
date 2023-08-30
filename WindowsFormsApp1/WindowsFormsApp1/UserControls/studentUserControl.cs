using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using SAM.form;
using System.Data.SqlClient;
using static System.Windows.Forms.LinkLabel;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
using System.Reflection;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1.UserControls
{
    public partial class studentUserControl : UserControl
    {
        private addStudentUserControl AddStudentUserControl;
        private editStudentUserControl EditStudentUserControl;
        private adminUserControl AdminUserControl;
        private PrintDocument printDocument;
        private certificatedesign Certificatedesign;
        public studentUserControl()
        {
            InitializeComponent();
            Certificatedesign = new certificatedesign();    
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

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
        //prints the usercontrol
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Bitmap bitmap = new Bitmap(Certificatedesign.Width, Certificatedesign.Height);
            Certificatedesign.DrawToBitmap(bitmap, new Rectangle(0, 0, Certificatedesign.Width, Certificatedesign.Height));
            graphics.DrawImage(bitmap, new Point(100, 100)); // Adjust the position as needed
        }

        public void addUserControlSecondPanel(UserControl userControl)
        {
            studentExtraPanel.Controls.Clear();
            studentExtraPanel.Controls.Add(userControl);
            studentExtraPanel.BringToFront();
        }




        private void studentUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditStudentUserControl = new editStudentUserControl();
            addUserControlSecondPanel(EditStudentUserControl);

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

                    string deleteQuery = "DELETE FROM students WHERE ID = @ID";
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


        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            AddStudentUserControl = new addStudentUserControl();
            addUserControlSecondPanel(AddStudentUserControl);

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
       







    }
    }
