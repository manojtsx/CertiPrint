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
    public partial class adminUserControl : UserControl
    {
        private Login login;
        private studentUserControl StudentUserControl;
        private facilitatorUserControl FacilitatorUserControl;
        private adminHomePage AdminHomePage;
        private addStudentUserControl AddStudentUserControl;
        public adminUserControl()
        {
            InitializeComponent();
            AdminHomePage = new adminHomePage();    
            addUserControlFirstPanel(AdminHomePage);    
        }
        public void addUserControlFirstPanel(UserControl userControl)
        {
            firstPanel.Controls.Clear();
            firstPanel.Controls.Add(userControl);
            firstPanel.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            AdminHomePage = new adminHomePage();
            addUserControlFirstPanel(AdminHomePage);
        }

        private void studentMenu_Click(object sender, EventArgs e)
        {
            StudentUserControl = new studentUserControl();
            addUserControlFirstPanel(StudentUserControl);
        }

        private void facilitatorMenu_Click(object sender, EventArgs e)
        {
            FacilitatorUserControl = new facilitatorUserControl();
            addUserControlFirstPanel(FacilitatorUserControl);
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            login = new Login();
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Login.RestartApplication();
            }
}

        private void firstPanel_Paint(object sender, PaintEventArgs e)
        {
               
        }

       public void secondPanel_Paint(object sender, PaintEventArgs e)
        {
            //AddStudentUserControl = new addStudentUserControl();
            //adduserControlSecondPanel(AddStudentUserControl);

        }
    }
}
