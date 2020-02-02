namespace Clinical_System
{
    partial class Booking
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timesComboBox = new System.Windows.Forms.ComboBox();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 226);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Location = new System.Drawing.Point(12, 58);
            this.bookingDataGridView.MultiSelect = false;
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(466, 146);
            this.bookingDataGridView.TabIndex = 1;
            this.bookingDataGridView.SelectionChanged += new System.EventHandler(this.bookingDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctors";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(200, 21);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(97, 18);
            this.patientNameLabel.TabIndex = 3;
            this.patientNameLabel.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Times:";
            // 
            // timesComboBox
            // 
            this.timesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timesComboBox.FormattingEnabled = true;
            this.timesComboBox.Location = new System.Drawing.Point(383, 237);
            this.timesComboBox.Name = "timesComboBox";
            this.timesComboBox.Size = new System.Drawing.Size(85, 21);
            this.timesComboBox.TabIndex = 5;
            this.timesComboBox.SelectedIndexChanged += new System.EventHandler(this.timesComboBox_SelectedIndexChanged);
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Enabled = false;
            this.bookAppointmentButton.Location = new System.Drawing.Point(310, 309);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(104, 34);
            this.bookAppointmentButton.TabIndex = 6;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.bookAppointmentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.timesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timesComboBox;
        private System.Windows.Forms.Button bookAppointmentButton;
        private System.Windows.Forms.Label label3;
    }
}