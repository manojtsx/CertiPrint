namespace WindowsFormsApp1.UserControls
{
    partial class adminUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutMenu = new System.Windows.Forms.Label();
            this.facilitatorMenu = new System.Windows.Forms.Label();
            this.studentMenu = new System.Windows.Forms.Label();
            this.homeMenu = new System.Windows.Forms.Label();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutMenu);
            this.panel1.Controls.Add(this.facilitatorMenu);
            this.panel1.Controls.Add(this.studentMenu);
            this.panel1.Controls.Add(this.homeMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 82);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logoutMenu
            // 
            this.logoutMenu.AutoSize = true;
            this.logoutMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutMenu.Location = new System.Drawing.Point(1230, 34);
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(73, 22);
            this.logoutMenu.TabIndex = 1;
            this.logoutMenu.Text = "Log Out";
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // facilitatorMenu
            // 
            this.facilitatorMenu.AutoSize = true;
            this.facilitatorMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilitatorMenu.Location = new System.Drawing.Point(1125, 33);
            this.facilitatorMenu.Name = "facilitatorMenu";
            this.facilitatorMenu.Size = new System.Drawing.Size(93, 22);
            this.facilitatorMenu.TabIndex = 2;
            this.facilitatorMenu.Text = "Facilitator";
            this.facilitatorMenu.Click += new System.EventHandler(this.facilitatorMenu_Click);
            // 
            // studentMenu
            // 
            this.studentMenu.AutoSize = true;
            this.studentMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentMenu.Location = new System.Drawing.Point(1026, 33);
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Size = new System.Drawing.Size(68, 22);
            this.studentMenu.TabIndex = 1;
            this.studentMenu.Text = "Student";
            this.studentMenu.Click += new System.EventHandler(this.studentMenu_Click);
            // 
            // homeMenu
            // 
            this.homeMenu.AutoSize = true;
            this.homeMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenu.Location = new System.Drawing.Point(913, 33);
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(57, 22);
            this.homeMenu.TabIndex = 0;
            this.homeMenu.Text = "Home";
            this.homeMenu.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // firstPanel
            // 
            this.firstPanel.Location = new System.Drawing.Point(3, 86);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(1384, 391);
            this.firstPanel.TabIndex = 1;
            this.firstPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.firstPanel_Paint);
            // 
            // adminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.panel1);
            this.Name = "adminUserControl";
            this.Size = new System.Drawing.Size(1390, 840);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoutMenu;
        private System.Windows.Forms.Label facilitatorMenu;
        private System.Windows.Forms.Label studentMenu;
        private System.Windows.Forms.Panel firstPanel;
    }
}
