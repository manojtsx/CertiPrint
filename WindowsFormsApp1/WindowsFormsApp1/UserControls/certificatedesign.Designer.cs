﻿namespace WindowsFormsApp1.UserControls
{
    partial class certificatedesign
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Boarding School";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Random Place, Random District";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Character Certificate";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(503, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 3;
            // 
            // certificatedesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "certificatedesign";
            this.Size = new System.Drawing.Size(1106, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
