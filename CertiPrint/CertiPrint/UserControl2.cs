using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiPrint
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();

            // Subscribe to the Load event
            Load +=UserControl2_Load;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            string text = label1.Text;
            int num = 0;
            label1.Text = text + num;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
