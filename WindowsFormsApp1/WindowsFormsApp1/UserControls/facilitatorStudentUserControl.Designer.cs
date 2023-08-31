namespace WindowsFormsApp1.UserControls
{
    partial class facilitatorStudentUserControl
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
            this.extraPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addRemarksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // extraPanel
            // 
            this.extraPanel.Location = new System.Drawing.Point(960, 91);
            this.extraPanel.Name = "extraPanel";
            this.extraPanel.Size = new System.Drawing.Size(340, 209);
            this.extraPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Page";
            // 
            // addRemarksButton
            // 
            this.addRemarksButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRemarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRemarksButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addRemarksButton.Location = new System.Drawing.Point(30, 379);
            this.addRemarksButton.Name = "addRemarksButton";
            this.addRemarksButton.Size = new System.Drawing.Size(173, 42);
            this.addRemarksButton.TabIndex = 3;
            this.addRemarksButton.Text = "Add Remarks";
            this.addRemarksButton.UseVisualStyleBackColor = false;
            this.addRemarksButton.Click += new System.EventHandler(this.addRemarksButton_Click);
            // 
            // facilitatorStudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRemarksButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extraPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "facilitatorStudentUserControl";
            this.Size = new System.Drawing.Size(1384, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel extraPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRemarksButton;
    }
}
