namespace WinFormsApp1
{
    partial class AdminEditFacilitator
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            facilitatorToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(241, 212, 229);
            textBox3.Location = new Point(121, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 23);
            textBox3.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 186);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 33;
            label4.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(241, 212, 229);
            textBox2.Location = new Point(122, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 150);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 31;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 110);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 29;
            label1.Text = "SN:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(115, 187, 201);
            button1.Location = new Point(32, 231);
            button1.Name = "button1";
            button1.Size = new Size(77, 36);
            button1.TabIndex = 28;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 56);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 27;
            label3.Text = "Edit Facilitator";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(62, 20);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // facilitatorToolStripMenuItem
            // 
            facilitatorToolStripMenuItem.Name = "facilitatorToolStripMenuItem";
            facilitatorToolStripMenuItem.Size = new Size(74, 20);
            facilitatorToolStripMenuItem.Text = "Facilitator ";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(241, 212, 229);
            textBox1.Location = new Point(121, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 30;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, studentToolStripMenuItem, facilitatorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "adminNavigation";
            // 
            // AdminEditFacilitator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "AdminEditFacilitator";
            Text = "AdminEditFacilitator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem facilitatorToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
    }
}