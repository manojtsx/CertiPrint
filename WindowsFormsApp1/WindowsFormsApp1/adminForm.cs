using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class adminForm : Form
    {
        private facilitatorUserControl facilitatorUserControl;
        private studentUserControl studentUserControl;
        private homepageUserControl homepageUserControl;

        public adminForm()
        {
            InitializeComponent();
            homepageUserControl = new homepageUserControl();
            addUserControl(homepageUserControl);

        }

        private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;  
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
               this.Controls.Clear(); 
               Login login = new Login();
                this.Hide();
                login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepageUserControl = new homepageUserControl();
            addUserControl(homepageUserControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentUserControl = new studentUserControl();
            addUserControl(studentUserControl);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facilitatorUserControl = new facilitatorUserControl();
            addUserControl(facilitatorUserControl);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
