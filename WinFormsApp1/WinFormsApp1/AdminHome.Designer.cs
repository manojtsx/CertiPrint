namespace WinFormsApp1
{
    partial class AdminHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            facilitatorToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "CertiPrint- ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 70);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 2;
            label2.Text = "A Certificate Printing System";
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, studentToolStripMenuItem, facilitatorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "adminNavigation";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // facilitatorToolStripMenuItem
            // 
            facilitatorToolStripMenuItem.Name = "facilitatorToolStripMenuItem";
            facilitatorToolStripMenuItem.Size = new Size(74, 20);
            facilitatorToolStripMenuItem.Text = "Facilitator ";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(62, 20);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 128);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 4;
            label3.Text = "About";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(197, 175);
            label4.Name = "label4";
            label4.Size = new Size(382, 15);
            label4.TabIndex = 5;
            label4.Text = "This is just a description about the institure so let's not focus over here. \r\n";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 270);
            label5.Name = "label5";
            label5.Size = new Size(279, 32);
            label5.TabIndex = 6;
            label5.Text = "Your School - Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 212, 229);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(30, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 10);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 0;
            label6.Text = "No of Students";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(70, 45);
            label7.Name = "label7";
            label7.Size = new Size(47, 37);
            label7.TabIndex = 1;
            label7.Text = "43";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(241, 212, 229);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(277, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(70, 45);
            label8.Name = "label8";
            label8.Size = new Size(47, 37);
            label8.TabIndex = 1;
            label8.Text = "22";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(41, 10);
            label9.Name = "label9";
            label9.Size = new Size(120, 21);
            label9.TabIndex = 0;
            label9.Text = "No of Facilitator";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(241, 212, 229);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(526, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(70, 45);
            label10.Name = "label10";
            label10.Size = new Size(69, 37);
            label10.TabIndex = 1;
            label10.Text = "60%";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(41, 10);
            label11.Name = "label11";
            label11.Size = new Size(152, 21);
            label11.TabIndex = 0;
            label11.Text = "Overall Performance";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.brand_logo;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(30, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(110, 81);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(30, 163);
            panel5.Name = "panel5";
            panel5.Size = new Size(101, 100);
            panel5.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 245, 246);
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem facilitatorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private Panel panel5;
    }
}