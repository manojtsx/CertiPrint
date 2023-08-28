namespace WindowsFormsApp1.UserControls
{
    partial class studentUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.studentExtraPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.GPA,
            this.Grade,
            this.Remarks,
            this.SID});
            this.dataGridView1.Location = new System.Drawing.Point(17, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // GPA
            // 
            this.GPA.HeaderText = "GPA";
            this.GPA.MinimumWidth = 6;
            this.GPA.Name = "GPA";
            this.GPA.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 125;
            // 
            // SID
            // 
            this.SID.HeaderText = "SID";
            this.SID.MinimumWidth = 6;
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Page";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(19, 309);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 43);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit ";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(139, 309);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 43);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(251, 309);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(92, 43);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(370, 309);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // studentExtraPanel
            // 
            this.studentExtraPanel.Location = new System.Drawing.Point(844, 4);
            this.studentExtraPanel.Name = "studentExtraPanel";
            this.studentExtraPanel.Size = new System.Drawing.Size(537, 384);
            this.studentExtraPanel.TabIndex = 6;
            // 
            // studentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentExtraPanel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            //this.Name = "studentUserControl";
            this.Size = new System.Drawing.Size(1384, 391);
            this.Load += new System.EventHandler(this.studentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel studentExtraPanel;
    }
}
