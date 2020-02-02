using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical_System
{
    public partial class Booking : Form
    {
        private Form1 form1;
        private string patientID;

        public Booking()
        {
            InitializeComponent();
        }

        public Booking(Form1 form1, string patientID)
        {
            InitializeComponent();
            this.form1 = form1;
            this.patientID = patientID;
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            string sql = "select id as ID,fname as 'First Name',lname as 'Last Name',specialization as Specialization from doctor";
            form1.queryIntoGrid(sql,this.bookingDataGridView);
            sql = "select concat(fname,' ',lname) from patient where id = "+patientID;
            List<Object[]> list = form1.queryIntoListOfObjects(sql,1);
            patientNameLabel.Text = list[0][0].ToString();
        }

        private void bookingDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;
            timesComboBox.Items.Clear();
            bookAppointmentButton.Enabled = false;
            if (bookingDataGridView.CurrentRow != null)
            {
                if (int.TryParse(bookingDataGridView.Rows[bookingDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    updateComboBox();
                    return;
                }
            }
            // not ok
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            timesComboBox.Items.Clear();
            bookAppointmentButton.Enabled = false;
            updateComboBox();
        }

        public void updateComboBox()
        {
            List<string> availableTimes = new List<string>() { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30" };
            
            string sql = "select date_format(day_time,'%H:%i') from appointment a, patient p";
            sql += " where date_format(day_time,'%Y-%m-%d') = '" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "'";
            sql += " and a.patient_fk = p.id";
            sql += " and a.patient_fk = " + patientID;
            sql += " and status <> 'CANCELLED'";
            List<Object[]> patientAppointmentsList = form1.queryIntoListOfObjects(sql, 1);
            foreach (Object[] obj in patientAppointmentsList)
            {
                availableTimes.Remove(obj[0].ToString());
                //MessageBox.Show("Patient has appointment: "+obj[0].ToString());
            }

            sql = "select date_format(day_time,'%H:%i') from appointment a, doctor d";
            sql += " where date_format(day_time,'%Y-%m-%d') = '" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "'";
            sql += " and a.doctor_fk = d.id";
            sql += " and a.doctor_fk = " + bookingDataGridView.Rows[bookingDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            List<Object[]> doctorAppointmentsList = form1.queryIntoListOfObjects(sql, 1);
            foreach (Object[] obj in doctorAppointmentsList)
            {
                availableTimes.Remove(obj[0].ToString());
                //MessageBox.Show("Doctor has appointment: " + obj[0].ToString());
            }

            foreach (string time in availableTimes)
            {
                timesComboBox.Items.Add(time);
            }
        }

        private void timesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookAppointmentButton.Enabled = true;
        }

        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionEnd < DateTime.Today)
            {
                MessageBox.Show("You cannot book an appointment for passed dates");
                return;
            }
            string sql = "insert into appointment(day_time,patient_fk,doctor_fk) values (";
            sql += "'" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd")+" "+timesComboBox.SelectedItem.ToString() + "',";
            sql += patientID + ",";
            sql += bookingDataGridView.Rows[bookingDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString() + ")";
            int rows = form1.nonQuery(sql);
            if (rows > 0)
                MessageBox.Show("Appointment booked");
            else
                MessageBox.Show("Error: no rows affected");
            this.Close();
        }
    }
}
