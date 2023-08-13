namespace WinFormsApp1
{
    partial class AdminEditStudent
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            facilitatorToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, studentToolStripMenuItem, facilitatorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
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
            label3.Location = new Point(50, 54);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 11;
            label3.Text = "Edit Student";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(115, 187, 201);
            button1.Location = new Point(51, 336);
            button1.Name = "button1";
            button1.Size = new Size(77, 36);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 108);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 14;
            label1.Text = "Symbol No:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(241, 212, 229);
            textBox1.Location = new Point(139, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(241, 212, 229);
            textBox2.Location = new Point(140, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 148);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(241, 212, 229);
            textBox3.Location = new Point(139, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 23);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 184);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 18;
            label4.Text = "Date of Birth:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(241, 212, 229);
            textBox4.Location = new Point(140, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 23);
            textBox4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 221);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 20;
            label5.Text = "GPA:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(241, 212, 229);
            textBox5.Location = new Point(140, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 23);
            textBox5.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 258);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 22;
            label6.Text = "Address:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(241, 212, 229);
            textBox6.Location = new Point(140, 288);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 23);
            textBox6.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 296);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 24;
            label7.Text = "Remarks:";
            // 
            // AdminEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Name = "AdminEditStudent";
            Text = "AdminEditStudent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem facilitatorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label3;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
    }
}