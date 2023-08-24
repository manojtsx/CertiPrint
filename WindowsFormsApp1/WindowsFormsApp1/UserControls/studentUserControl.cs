using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class studentUserControl : UserControl
    {
        private adminForm AdminForm;
        private addStudentUserControl AddStudentUserControl;
        public studentUserControl()
        {
            InitializeComponent();
        }
        //private void addUserControl(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    AdminForm.panel2.Controls.Clear();
        //    AdminForm.panel2.Controls.Add(userControl);
        //    userControl.BringToFront();

        //}
        // Inside StudentControl.cs




        private void studentUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate the AddStudentControl user control
             AddStudentUserControl = new addStudentUserControl();

            // Call the method to switch the content in AdminForm.panel2
            AdminForm.AddUserControl(AddStudentUserControl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
