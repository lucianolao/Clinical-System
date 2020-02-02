namespace Clinical_System
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.addPrescriptionButton = new System.Windows.Forms.Button();
            this.cancelledButton = new System.Windows.Forms.Button();
            this.attendedButton = new System.Windows.Forms.Button();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientsListBox = new System.Windows.Forms.ListBox();
            this.removePatientButton = new System.Windows.Forms.Button();
            this.allPrescriptionsButton = new System.Windows.Forms.Button();
            this.previousConsultsButton = new System.Windows.Forms.Button();
            this.showPatientAppointmentsButton = new System.Windows.Forms.Button();
            this.viewDetailsPatientButton = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.searchPatientPHNTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchPatientIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.newDoctorButton = new System.Windows.Forms.Button();
            this.doctorsListBox = new System.Windows.Forms.ListBox();
            this.removeDoctorButton = new System.Windows.Forms.Button();
            this.showPatientsButton = new System.Windows.Forms.Button();
            this.showDoctorAppointmentsButton = new System.Windows.Forms.Button();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchDoctorButton = new System.Windows.Forms.Button();
            this.searchDoctorSpecializationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchDoctorIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchDoctorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchDoctorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.tabDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAppointments);
            this.tabControl1.Controls.Add(this.tabPatients);
            this.tabControl1.Controls.Add(this.tabDoctors);
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 516);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.label11);
            this.tabAppointments.Controls.Add(this.addPrescriptionButton);
            this.tabAppointments.Controls.Add(this.cancelledButton);
            this.tabAppointments.Controls.Add(this.attendedButton);
            this.tabAppointments.Controls.Add(this.appointmentsDataGridView);
            this.tabAppointments.Controls.Add(this.monthCalendar1);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointments.Size = new System.Drawing.Size(879, 490);
            this.tabAppointments.TabIndex = 0;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Select an appointment below";
            // 
            // addPrescriptionButton
            // 
            this.addPrescriptionButton.Enabled = false;
            this.addPrescriptionButton.Location = new System.Drawing.Point(675, 330);
            this.addPrescriptionButton.Name = "addPrescriptionButton";
            this.addPrescriptionButton.Size = new System.Drawing.Size(100, 31);
            this.addPrescriptionButton.TabIndex = 21;
            this.addPrescriptionButton.Text = "Add Prescription";
            this.addPrescriptionButton.UseVisualStyleBackColor = true;
            this.addPrescriptionButton.Click += new System.EventHandler(this.addPrescriptionButton_Click);
            // 
            // cancelledButton
            // 
            this.cancelledButton.Enabled = false;
            this.cancelledButton.Location = new System.Drawing.Point(675, 275);
            this.cancelledButton.Name = "cancelledButton";
            this.cancelledButton.Size = new System.Drawing.Size(100, 31);
            this.cancelledButton.TabIndex = 20;
            this.cancelledButton.Text = "Cancelled";
            this.cancelledButton.UseVisualStyleBackColor = true;
            this.cancelledButton.Click += new System.EventHandler(this.cancelledButton_Click);
            // 
            // attendedButton
            // 
            this.attendedButton.Enabled = false;
            this.attendedButton.Location = new System.Drawing.Point(675, 222);
            this.attendedButton.Name = "attendedButton";
            this.attendedButton.Size = new System.Drawing.Size(100, 31);
            this.attendedButton.TabIndex = 19;
            this.attendedButton.Text = "Attended";
            this.attendedButton.UseVisualStyleBackColor = true;
            this.attendedButton.Click += new System.EventHandler(this.attendedButton_Click);
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(564, 452);
            this.appointmentsDataGridView.TabIndex = 18;
            this.appointmentsDataGridView.SelectionChanged += new System.EventHandler(this.appointmentsDataGridView_SelectionChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(614, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.label9);
            this.tabPatients.Controls.Add(this.bookAppointmentButton);
            this.tabPatients.Controls.Add(this.newPatientButton);
            this.tabPatients.Controls.Add(this.patientsListBox);
            this.tabPatients.Controls.Add(this.removePatientButton);
            this.tabPatients.Controls.Add(this.allPrescriptionsButton);
            this.tabPatients.Controls.Add(this.previousConsultsButton);
            this.tabPatients.Controls.Add(this.showPatientAppointmentsButton);
            this.tabPatients.Controls.Add(this.viewDetailsPatientButton);
            this.tabPatients.Controls.Add(this.patientsDataGridView);
            this.tabPatients.Controls.Add(this.searchPatientButton);
            this.tabPatients.Controls.Add(this.searchPatientPHNTextBox);
            this.tabPatients.Controls.Add(this.label4);
            this.tabPatients.Controls.Add(this.searchPatientIDTextBox);
            this.tabPatients.Controls.Add(this.label3);
            this.tabPatients.Controls.Add(this.searchPatientLastNameTextBox);
            this.tabPatients.Controls.Add(this.label2);
            this.tabPatients.Controls.Add(this.searchPatientFirstNameTextBox);
            this.tabPatients.Controls.Add(this.label1);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(879, 490);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Select a patient below";
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Enabled = false;
            this.bookAppointmentButton.Location = new System.Drawing.Point(689, 64);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(110, 23);
            this.bookAppointmentButton.TabIndex = 26;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.bookAppointmentButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(765, 11);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(100, 31);
            this.newPatientButton.TabIndex = 25;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // patientsListBox
            // 
            this.patientsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsListBox.FormattingEnabled = true;
            this.patientsListBox.ItemHeight = 14;
            this.patientsListBox.Location = new System.Drawing.Point(16, 316);
            this.patientsListBox.Name = "patientsListBox";
            this.patientsListBox.Size = new System.Drawing.Size(849, 158);
            this.patientsListBox.TabIndex = 24;
            // 
            // removePatientButton
            // 
            this.removePatientButton.Enabled = false;
            this.removePatientButton.Location = new System.Drawing.Point(689, 209);
            this.removePatientButton.Name = "removePatientButton";
            this.removePatientButton.Size = new System.Drawing.Size(110, 23);
            this.removePatientButton.TabIndex = 23;
            this.removePatientButton.Text = "Remove Patient";
            this.removePatientButton.UseVisualStyleBackColor = true;
            this.removePatientButton.Click += new System.EventHandler(this.removePatientButton_Click);
            // 
            // allPrescriptionsButton
            // 
            this.allPrescriptionsButton.Enabled = false;
            this.allPrescriptionsButton.Location = new System.Drawing.Point(689, 151);
            this.allPrescriptionsButton.Name = "allPrescriptionsButton";
            this.allPrescriptionsButton.Size = new System.Drawing.Size(110, 23);
            this.allPrescriptionsButton.TabIndex = 22;
            this.allPrescriptionsButton.Text = "All Prescriptions";
            this.allPrescriptionsButton.UseVisualStyleBackColor = true;
            this.allPrescriptionsButton.Click += new System.EventHandler(this.allPrescriptionsButton_Click);
            // 
            // previousConsultsButton
            // 
            this.previousConsultsButton.Enabled = false;
            this.previousConsultsButton.Location = new System.Drawing.Point(689, 122);
            this.previousConsultsButton.Name = "previousConsultsButton";
            this.previousConsultsButton.Size = new System.Drawing.Size(110, 23);
            this.previousConsultsButton.TabIndex = 21;
            this.previousConsultsButton.Text = "Previous Consults";
            this.previousConsultsButton.UseVisualStyleBackColor = true;
            this.previousConsultsButton.Click += new System.EventHandler(this.previousConsultsButton_Click);
            // 
            // showPatientAppointmentsButton
            // 
            this.showPatientAppointmentsButton.Enabled = false;
            this.showPatientAppointmentsButton.Location = new System.Drawing.Point(689, 93);
            this.showPatientAppointmentsButton.Name = "showPatientAppointmentsButton";
            this.showPatientAppointmentsButton.Size = new System.Drawing.Size(110, 23);
            this.showPatientAppointmentsButton.TabIndex = 20;
            this.showPatientAppointmentsButton.Text = "Show Appointments";
            this.showPatientAppointmentsButton.UseVisualStyleBackColor = true;
            this.showPatientAppointmentsButton.Click += new System.EventHandler(this.showPatientAppointmentsButton_Click);
            // 
            // viewDetailsPatientButton
            // 
            this.viewDetailsPatientButton.Enabled = false;
            this.viewDetailsPatientButton.Location = new System.Drawing.Point(689, 180);
            this.viewDetailsPatientButton.Name = "viewDetailsPatientButton";
            this.viewDetailsPatientButton.Size = new System.Drawing.Size(110, 23);
            this.viewDetailsPatientButton.TabIndex = 18;
            this.viewDetailsPatientButton.Text = "View Details";
            this.viewDetailsPatientButton.UseVisualStyleBackColor = true;
            this.viewDetailsPatientButton.Click += new System.EventHandler(this.viewDetailsPatientButton_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(16, 64);
            this.patientsDataGridView.MultiSelect = false;
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGridView.Size = new System.Drawing.Size(667, 246);
            this.patientsDataGridView.TabIndex = 17;
            this.patientsDataGridView.SelectionChanged += new System.EventHandler(this.patientsDataGridView_SelectionChanged);
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(659, 11);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(100, 31);
            this.searchPatientButton.TabIndex = 16;
            this.searchPatientButton.Text = "Search";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.searchPatientButton_Click);
            // 
            // searchPatientPHNTextBox
            // 
            this.searchPatientPHNTextBox.Location = new System.Drawing.Point(516, 17);
            this.searchPatientPHNTextBox.Name = "searchPatientPHNTextBox";
            this.searchPatientPHNTextBox.Size = new System.Drawing.Size(123, 20);
            this.searchPatientPHNTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Health Number";
            // 
            // searchPatientIDTextBox
            // 
            this.searchPatientIDTextBox.Location = new System.Drawing.Point(37, 17);
            this.searchPatientIDTextBox.Name = "searchPatientIDTextBox";
            this.searchPatientIDTextBox.Size = new System.Drawing.Size(31, 20);
            this.searchPatientIDTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // searchPatientLastNameTextBox
            // 
            this.searchPatientLastNameTextBox.Location = new System.Drawing.Point(329, 17);
            this.searchPatientLastNameTextBox.Name = "searchPatientLastNameTextBox";
            this.searchPatientLastNameTextBox.Size = new System.Drawing.Size(75, 20);
            this.searchPatientLastNameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // searchPatientFirstNameTextBox
            // 
            this.searchPatientFirstNameTextBox.Location = new System.Drawing.Point(154, 17);
            this.searchPatientFirstNameTextBox.Name = "searchPatientFirstNameTextBox";
            this.searchPatientFirstNameTextBox.Size = new System.Drawing.Size(75, 20);
            this.searchPatientFirstNameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.label10);
            this.tabDoctors.Controls.Add(this.newDoctorButton);
            this.tabDoctors.Controls.Add(this.doctorsListBox);
            this.tabDoctors.Controls.Add(this.removeDoctorButton);
            this.tabDoctors.Controls.Add(this.showPatientsButton);
            this.tabDoctors.Controls.Add(this.showDoctorAppointmentsButton);
            this.tabDoctors.Controls.Add(this.doctorsDataGridView);
            this.tabDoctors.Controls.Add(this.searchDoctorButton);
            this.tabDoctors.Controls.Add(this.searchDoctorSpecializationTextBox);
            this.tabDoctors.Controls.Add(this.label5);
            this.tabDoctors.Controls.Add(this.searchDoctorIDTextBox);
            this.tabDoctors.Controls.Add(this.label6);
            this.tabDoctors.Controls.Add(this.searchDoctorLastNameTextBox);
            this.tabDoctors.Controls.Add(this.label7);
            this.tabDoctors.Controls.Add(this.searchDoctorFirstNameTextBox);
            this.tabDoctors.Controls.Add(this.label8);
            this.tabDoctors.Location = new System.Drawing.Point(4, 22);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Size = new System.Drawing.Size(879, 490);
            this.tabDoctors.TabIndex = 2;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Select a doctor below";
            // 
            // newDoctorButton
            // 
            this.newDoctorButton.Location = new System.Drawing.Point(765, 11);
            this.newDoctorButton.Name = "newDoctorButton";
            this.newDoctorButton.Size = new System.Drawing.Size(100, 31);
            this.newDoctorButton.TabIndex = 42;
            this.newDoctorButton.Text = "New Doctor";
            this.newDoctorButton.UseVisualStyleBackColor = true;
            this.newDoctorButton.Click += new System.EventHandler(this.newDoctorButton_Click);
            // 
            // doctorsListBox
            // 
            this.doctorsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsListBox.FormattingEnabled = true;
            this.doctorsListBox.ItemHeight = 14;
            this.doctorsListBox.Location = new System.Drawing.Point(16, 316);
            this.doctorsListBox.Name = "doctorsListBox";
            this.doctorsListBox.Size = new System.Drawing.Size(849, 158);
            this.doctorsListBox.TabIndex = 41;
            // 
            // removeDoctorButton
            // 
            this.removeDoctorButton.Enabled = false;
            this.removeDoctorButton.Location = new System.Drawing.Point(689, 122);
            this.removeDoctorButton.Name = "removeDoctorButton";
            this.removeDoctorButton.Size = new System.Drawing.Size(110, 23);
            this.removeDoctorButton.TabIndex = 40;
            this.removeDoctorButton.Text = "Remove Doctor";
            this.removeDoctorButton.UseVisualStyleBackColor = true;
            this.removeDoctorButton.Click += new System.EventHandler(this.removeDoctorButton_Click);
            // 
            // showPatientsButton
            // 
            this.showPatientsButton.Enabled = false;
            this.showPatientsButton.Location = new System.Drawing.Point(689, 93);
            this.showPatientsButton.Name = "showPatientsButton";
            this.showPatientsButton.Size = new System.Drawing.Size(110, 23);
            this.showPatientsButton.TabIndex = 38;
            this.showPatientsButton.Text = "Show Patients";
            this.showPatientsButton.UseVisualStyleBackColor = true;
            this.showPatientsButton.Click += new System.EventHandler(this.showPatientsButton_Click);
            // 
            // showDoctorAppointmentsButton
            // 
            this.showDoctorAppointmentsButton.Enabled = false;
            this.showDoctorAppointmentsButton.Location = new System.Drawing.Point(689, 64);
            this.showDoctorAppointmentsButton.Name = "showDoctorAppointmentsButton";
            this.showDoctorAppointmentsButton.Size = new System.Drawing.Size(110, 23);
            this.showDoctorAppointmentsButton.TabIndex = 37;
            this.showDoctorAppointmentsButton.Text = "Show Appointments";
            this.showDoctorAppointmentsButton.UseVisualStyleBackColor = true;
            this.showDoctorAppointmentsButton.Click += new System.EventHandler(this.showDoctorAppointmentsButton_Click);
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Location = new System.Drawing.Point(16, 64);
            this.doctorsDataGridView.MultiSelect = false;
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorsDataGridView.Size = new System.Drawing.Size(667, 246);
            this.doctorsDataGridView.TabIndex = 34;
            this.doctorsDataGridView.SelectionChanged += new System.EventHandler(this.doctorsDataGridView_SelectionChanged);
            // 
            // searchDoctorButton
            // 
            this.searchDoctorButton.Location = new System.Drawing.Point(659, 11);
            this.searchDoctorButton.Name = "searchDoctorButton";
            this.searchDoctorButton.Size = new System.Drawing.Size(100, 31);
            this.searchDoctorButton.TabIndex = 33;
            this.searchDoctorButton.Text = "Search";
            this.searchDoctorButton.UseVisualStyleBackColor = true;
            this.searchDoctorButton.Click += new System.EventHandler(this.searchDoctorButton_Click);
            // 
            // searchDoctorSpecializationTextBox
            // 
            this.searchDoctorSpecializationTextBox.Location = new System.Drawing.Point(516, 17);
            this.searchDoctorSpecializationTextBox.Name = "searchDoctorSpecializationTextBox";
            this.searchDoctorSpecializationTextBox.Size = new System.Drawing.Size(123, 20);
            this.searchDoctorSpecializationTextBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Specialization";
            // 
            // searchDoctorIDTextBox
            // 
            this.searchDoctorIDTextBox.Location = new System.Drawing.Point(37, 17);
            this.searchDoctorIDTextBox.Name = "searchDoctorIDTextBox";
            this.searchDoctorIDTextBox.Size = new System.Drawing.Size(31, 20);
            this.searchDoctorIDTextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID";
            // 
            // searchDoctorLastNameTextBox
            // 
            this.searchDoctorLastNameTextBox.Location = new System.Drawing.Point(329, 17);
            this.searchDoctorLastNameTextBox.Name = "searchDoctorLastNameTextBox";
            this.searchDoctorLastNameTextBox.Size = new System.Drawing.Size(75, 20);
            this.searchDoctorLastNameTextBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Last Name";
            // 
            // searchDoctorFirstNameTextBox
            // 
            this.searchDoctorFirstNameTextBox.Location = new System.Drawing.Point(154, 17);
            this.searchDoctorFirstNameTextBox.Name = "searchDoctorFirstNameTextBox";
            this.searchDoctorFirstNameTextBox.Size = new System.Drawing.Size(75, 20);
            this.searchDoctorFirstNameTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinical System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAppointments.ResumeLayout(false);
            this.tabAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.tabDoctors.ResumeLayout(false);
            this.tabDoctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button removePatientButton;
        private System.Windows.Forms.Button allPrescriptionsButton;
        private System.Windows.Forms.Button previousConsultsButton;
        private System.Windows.Forms.Button showPatientAppointmentsButton;
        private System.Windows.Forms.Button viewDetailsPatientButton;
        private System.Windows.Forms.ListBox patientsListBox;
        private System.Windows.Forms.TextBox searchPatientPHNTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchPatientIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchPatientLastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchPatientFirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox doctorsListBox;
        private System.Windows.Forms.Button removeDoctorButton;
        private System.Windows.Forms.Button showPatientsButton;
        private System.Windows.Forms.Button showDoctorAppointmentsButton;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.Button searchDoctorButton;
        private System.Windows.Forms.TextBox searchDoctorSpecializationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchDoctorIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchDoctorLastNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchDoctorFirstNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button newDoctorButton;
        private System.Windows.Forms.Button bookAppointmentButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button cancelledButton;
        private System.Windows.Forms.Button attendedButton;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.Button addPrescriptionButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

