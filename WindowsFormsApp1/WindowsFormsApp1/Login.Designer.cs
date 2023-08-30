namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.userroleField = new System.Windows.Forms.ComboBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.userroleField);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(502, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 247);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(74, 191);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(96, 32);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userroleField
            // 
            this.userroleField.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "facilitator"});
            this.userroleField.FormattingEnabled = true;
            this.userroleField.Items.AddRange(new object[] {
            "facilitator",
            "admin"});
            this.userroleField.Location = new System.Drawing.Point(121, 129);
            this.userroleField.Name = "userroleField";
            this.userroleField.Size = new System.Drawing.Size(121, 24);
            this.userroleField.TabIndex = 5;
            this.userroleField.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(121, 78);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(208, 22);
            this.passwordField.TabIndex = 4;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(121, 17);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(208, 22);
            this.usernameField.TabIndex = 3;
            this.usernameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Role";
            // 
            // mainPanelContainer
            // 
            this.mainPanelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanelContainer.BackgroundImage")));
            this.mainPanelContainer.Location = new System.Drawing.Point(0, 3);
            this.mainPanelContainer.Name = "mainPanelContainer";
            this.mainPanelContainer.Size = new System.Drawing.Size(1382, 724);
            this.mainPanelContainer.TabIndex = 3;
            this.mainPanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanelContainer_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanelContainer);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox userroleField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel mainPanelContainer;
    }
}