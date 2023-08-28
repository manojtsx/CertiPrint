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


namespace WindowsFormsApp1.UserControls
{
    public partial class studentUserControl : UserControl
    {
        private addStudentUserControl AddStudentUserControl;
        private editStudentUserControl EditStudentUserControl;
        private adminUserControl AdminUserControl;
        private PrintDocument printDocument;
        public studentUserControl()
        {
            InitializeComponent();
            AddStudentUserControl = new addStudentUserControl();    
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        //prints the usercontrol
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Bitmap bitmap = new Bitmap(AddStudentUserControl.Width, AddStudentUserControl.Height);
            AddStudentUserControl.DrawToBitmap(bitmap, new Rectangle(0, 0, AddStudentUserControl.Width, AddStudentUserControl.Height));
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

    }
}
