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
    public partial class facilitatorUserControl : UserControl
    {
        private addFacilitatorUserControl AddFacilitatorUserControl;
        private editFacilitatorUserControl EditFacilitatorUserControl;
        public facilitatorUserControl()
        {
            InitializeComponent();
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
            addUserControlSecondPanel(EditFacilitatorUserControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFacilitatorUserControl = new addFacilitatorUserControl();
            addUserControlSecondPanel(AddFacilitatorUserControl);
        }
    }
}
