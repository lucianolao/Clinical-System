﻿namespace Clinical_System
{
    partial class New_Doctor
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
            this.addDoctorTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDoctorTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDoctorTextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDoctorTextBox2
            // 
            this.addDoctorTextBox2.Location = new System.Drawing.Point(89, 51);
            this.addDoctorTextBox2.MaxLength = 20;
            this.addDoctorTextBox2.Name = "addDoctorTextBox2";
            this.addDoctorTextBox2.Size = new System.Drawing.Size(129, 20);
            this.addDoctorTextBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name*";
            // 
            // addDoctorTextBox1
            // 
            this.addDoctorTextBox1.Location = new System.Drawing.Point(88, 21);
            this.addDoctorTextBox1.MaxLength = 20;
            this.addDoctorTextBox1.Name = "addDoctorTextBox1";
            this.addDoctorTextBox1.Size = new System.Drawing.Size(130, 20);
            this.addDoctorTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name*";
            // 
            // addDoctorTextBox3
            // 
            this.addDoctorTextBox3.Location = new System.Drawing.Point(88, 87);
            this.addDoctorTextBox3.MaxLength = 30;
            this.addDoctorTextBox3.Name = "addDoctorTextBox3";
            this.addDoctorTextBox3.Size = new System.Drawing.Size(130, 20);
            this.addDoctorTextBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Specialization*";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(64, 144);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(115, 39);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register Doctor";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // New_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 220);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.addDoctorTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addDoctorTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDoctorTextBox3);
            this.Controls.Add(this.label1);
            this.Name = "New_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addDoctorTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addDoctorTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addDoctorTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
    }
}