namespace WindowsFormsApp1.UserControls
{
    partial class addStudentUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remarksField = new System.Windows.Forms.ComboBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpaField = new System.Windows.Forms.TextBox();
            this.gradeField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remarks";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(142, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.remarksField);
            this.panel1.Controls.Add(this.addressField);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gpaField);
            this.panel1.Controls.Add(this.gradeField);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 348);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(142, 17);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(207, 22);
            this.usernameField.TabIndex = 15;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(142, 54);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(207, 22);
            this.passwordField.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username";
            // 
            // remarksField
            // 
            this.remarksField.FormattingEnabled = true;
            this.remarksField.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Average",
            "Not Good",
            "Worse"});
            this.remarksField.Location = new System.Drawing.Point(142, 243);
            this.remarksField.Name = "remarksField";
            this.remarksField.Size = new System.Drawing.Size(207, 24);
            this.remarksField.TabIndex = 11;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(142, 207);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(207, 22);
            this.addressField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // gpaField
            // 
            this.gpaField.Location = new System.Drawing.Point(142, 166);
            this.gpaField.Name = "gpaField";
            this.gpaField.Size = new System.Drawing.Size(207, 22);
            this.gpaField.TabIndex = 7;
            // 
            // gradeField
            // 
            this.gradeField.Location = new System.Drawing.Point(141, 123);
            this.gradeField.Name = "gradeField";
            this.gradeField.Size = new System.Drawing.Size(207, 22);
            this.gradeField.TabIndex = 6;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(141, 84);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(207, 22);
            this.nameField.TabIndex = 5;
            // 
            // addStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "addStudentUserControl";
            this.Size = new System.Drawing.Size(537, 384);
            this.Load += new System.EventHandler(this.addStudentUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gradeField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox gpaField;
        private System.Windows.Forms.ComboBox remarksField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
    }
}
