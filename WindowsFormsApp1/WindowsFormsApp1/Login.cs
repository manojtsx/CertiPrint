using SAM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private adminUserControl AdminUserControl;
        public Login()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void addUserControlMainPanel(UserControl userControl)
        {
            mainPanelContainer.Controls.Clear();
            mainPanelContainer.Controls.Add(userControl);
            mainPanelContainer.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          AdminUserControl = new adminUserControl();
          addUserControlMainPanel(AdminUserControl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "admin";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void mainPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void RestartApplication()
        {
            string fileName = Application.ExecutablePath;
            string arguments = string.Join(" ", Environment.GetCommandLineArgs());

            Process.Start(fileName, arguments);
            Environment.Exit(0); // Exit the current instance of the application
        }
    }
}
