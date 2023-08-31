using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class facilitatorHomepageUserControl : UserControl
    {
        private facilitatorFacilitatorUserControl FacilitatorFacilitatorUserControl;
        private facilitatorHomePageUserControlDown FacilitatorHomepageUserControlDown;
        private facilitatorStudentUserControl FacilitatorStudentUserControl;
        private Login login;
        public facilitatorHomepageUserControl()
        {
            InitializeComponent();
            FacilitatorHomepageUserControlDown = new facilitatorHomePageUserControlDown();
            addUserControlFirstPanel(FacilitatorHomepageUserControlDown);
        }
        public void addUserControlFirstPanel(UserControl userControl)
        {
            firstPanel.Controls.Clear();
            firstPanel.Controls.Add(userControl);
            firstPanel.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
        private void facilitatorMenu_Click(object sender, EventArgs e)
        {
            FacilitatorFacilitatorUserControl = new facilitatorFacilitatorUserControl();
            addUserControlFirstPanel(FacilitatorFacilitatorUserControl);
        }

        private void studentMenu_Click(object sender, EventArgs e)
        {
            FacilitatorStudentUserControl = new facilitatorStudentUserControl();
            addUserControlFirstPanel(FacilitatorStudentUserControl);
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            FacilitatorHomepageUserControlDown = new facilitatorHomePageUserControlDown();
            addUserControlFirstPanel(FacilitatorHomepageUserControlDown);
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            login = new Login();
            Login.RestartApplication();
        }
    }
}
