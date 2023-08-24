namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            loginbtn = new Button();
            resetbtn = new Button();
            userTextField = new TextBox();
            passwordTextField = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 175);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 231);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(115, 187, 201);
            loginbtn.Location = new Point(376, 312);
            loginbtn.Margin = new Padding(3, 4, 3, 4);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(107, 41);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.FromArgb(115, 187, 201);
            resetbtn.Location = new Point(510, 312);
            resetbtn.Margin = new Padding(3, 4, 3, 4);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(107, 41);
            resetbtn.TabIndex = 3;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += button2_Click;
            // 
            // userTextField
            // 
            userTextField.BackColor = Color.FromArgb(241, 212, 229);
            userTextField.Location = new Point(479, 173);
            userTextField.Margin = new Padding(3, 4, 3, 4);
            userTextField.Name = "userTextField";
            userTextField.Size = new Size(199, 27);
            userTextField.TabIndex = 6;
            // 
            // passwordTextField
            // 
            passwordTextField.BackColor = Color.FromArgb(241, 212, 229);
            passwordTextField.Location = new Point(479, 220);
            passwordTextField.Margin = new Padding(3, 4, 3, 4);
            passwordTextField.Name = "passwordTextField";
            passwordTextField.Size = new Size(199, 27);
            passwordTextField.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 245, 246);
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(passwordTextField);
            Controls.Add(userTextField);
            Controls.Add(resetbtn);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button loginbtn;
        private Button resetbtn;
        private TextBox userTextField;
        private TextBox passwordTextField;
    }
}