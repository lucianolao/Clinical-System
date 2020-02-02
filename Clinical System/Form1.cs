using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinical_System
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            showDailyAppointments();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection != null)
                connection.Close();
        }

        public void connect()
        {
            string server = "ec2-54-86-171-192.compute-1.amazonaws.com";
            string database = "f2014_user24";
            string uid = "f2014_user24";
            string password = "f2014_user24";
            string connectionString = "SERVER=" + server + ";DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again.");
                        break;
                }
                System.Environment.Exit(1);
            }
        }

        public void queryIntoGrid(string query, DataGridView dataGridView)
        {
            if (connection != null)
            {
                MySqlDataAdapter mcmd = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        public List<Object[]> queryIntoListOfObjects(string query, int numberElements)
        {
            List<Object[]> list = new List<Object[]>();
            if (connection != null)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                DataTable schemaTable = dataReader.GetSchemaTable();
                
                while (dataReader.Read())
                {
                    Object[] obj = new Object[numberElements];
                    //int count = 0;
                    //foreach (DataColumn column in schemaTable.Columns)
                    for (int count = 0; count < numberElements; count++)
                    {
                        if (dataReader[count] != DBNull.Value)
                            obj[count] = dataReader[count].ToString();
                        //count++;
                    }
                    list.Add(obj);
                }
                dataReader.Close();
            }
            else
            {
                MessageBox.Show("Try to connect");
            }
            return list;
        }

        public int nonQuery(string sql)
        {
            if (connection != null)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            else
            {
                MessageBox.Show("Try to connect");
                return 0;
            }
        }

        // string[] fmt = {"{0,-52}","{0,-15}","{0,-20}","{0,-20:C}"};
        // listBox.Items.Add(string.Format("{0,-52}{1,-15}", "Country", "Population"));
        private void displayListIntoListBox(List<Object[]> list, string[] fmt, string[] header, ListBox listBox)
        {
            string output = "";
            listBox.Items.Clear();
            for (int i = 0; i < fmt.Length; i++)
            {
                output += string.Format(fmt[i], header[i]);
            }
            listBox.Items.Add(output);
            listBox.Items.Add("");
            foreach (Object[] obj in list)
            {
                output = "";
                if (fmt.Length != obj.Length)
                {
                    MessageBox.Show("Error: Formatting length and objects length are not the same");
                    return;
                }
                for (int count = 0; count < obj.Length; count++)
                {
                    output += string.Format(fmt[count], obj[count]);
                }
                listBox.Items.Add(output);
            }
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            New_Patient window = new New_Patient(this);
            //window.Show(); // Modeless
            window.ShowDialog(this); // Modal
        }

        private void newDoctorButton_Click(object sender, EventArgs e)
        {
            New_Doctor window = new New_Doctor(this);
            //window.Show(); // Modeless
            window.ShowDialog(this); // Modal
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            long tempLong;
            string sql = "select id as ID,fname as 'First Name',lname as 'Last Name',phn as 'Health Number' from patient";
            sql += " where fname like '%" + searchPatientFirstNameTextBox.Text.Trim() + "%' and lname like '%" + searchPatientLastNameTextBox.Text.Trim() + "%'";
            if (searchPatientIDTextBox.Text.Trim() != "" && !int.TryParse(searchPatientIDTextBox.Text.Trim(), out tempInt))
                MessageBox.Show("ID must be an integer value");
            else if (searchPatientIDTextBox.Text.Trim() != "")
                sql += " or id = " + searchPatientIDTextBox.Text.Trim();
            if (searchPatientPHNTextBox.Text.Trim() != "" && !long.TryParse(searchPatientPHNTextBox.Text.Trim(), out tempLong))
                MessageBox.Show("Health Number must be an integer value");
            else if (searchPatientPHNTextBox.Text.Trim() != "")
                sql += " or phn = " + searchPatientPHNTextBox.Text.Trim();
            queryIntoGrid(sql, patientsDataGridView);
        }

        private void searchDoctorButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            string sql = "select id as ID,fname as 'First Name',lname as 'Last Name',specialization as 'Specialization' from doctor";
            sql += " where fname like '%" + searchDoctorFirstNameTextBox.Text.Trim() + "%' and lname like '%" + searchDoctorLastNameTextBox.Text.Trim() + "%' and specialization like '%" + searchDoctorSpecializationTextBox.Text.Trim() + "%'";
            if (searchDoctorIDTextBox.Text.Trim() != "" && !int.TryParse(searchDoctorIDTextBox.Text.Trim(), out tempInt))
                MessageBox.Show("ID must be an integer value");
            else if (searchDoctorIDTextBox.Text.Trim() != "")
                sql += " or id = " + searchDoctorIDTextBox.Text.Trim();
            queryIntoGrid(sql, doctorsDataGridView);

        }

        private void patientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;
            patientsListBox.Items.Clear();
            if (patientsDataGridView.CurrentRow != null)
            {
                if (int.TryParse(patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    bookAppointmentButton.Enabled = true;
                    showPatientAppointmentsButton.Enabled = true;
                    previousConsultsButton.Enabled = true;
                    allPrescriptionsButton.Enabled = true;
                    viewDetailsPatientButton.Enabled = true;
                    removePatientButton.Enabled = true;
                    return;
                }
            }
            bookAppointmentButton.Enabled = false;
            showPatientAppointmentsButton.Enabled = false;
            previousConsultsButton.Enabled = false;
            allPrescriptionsButton.Enabled = false;
            viewDetailsPatientButton.Enabled = false;
            removePatientButton.Enabled = false;
        }

        private void doctorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;
            doctorsListBox.Items.Clear();
            if (doctorsDataGridView.CurrentRow != null)
            {
                if (int.TryParse(doctorsDataGridView.Rows[doctorsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    showDoctorAppointmentsButton.Enabled = true;
                    showPatientsButton.Enabled = true;
                    removeDoctorButton.Enabled = true;
                    return;
                }
            }
            showDoctorAppointmentsButton.Enabled = false;
            showPatientsButton.Enabled = false;
            removeDoctorButton.Enabled = false;
        }

        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            Booking window = new Booking(this,patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //window.Show(); // Modeless
            window.ShowDialog(this); // Modal
        }

        private void showPatientAppointmentsButton_Click(object sender, EventArgs e)
        {
            string id = patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select a.id as ID,date_format(day_time,'%m/%d/%Y') as 'Date',date_format(day_time,'%H:%i') as 'Time',concat(d.fname,' ',d.lname) as 'Doctor'";
            sql += " from appointment a, doctor d";
            sql += " where a.doctor_fk = d.id";
            sql += " and a.patient_fk = " + id;
            sql += " and day_time > curdate()";
            sql += " and status <> 'CANCELLED'";
            List<Object[]> list = queryIntoListOfObjects(sql,4);
            string[] fmt = { "{0,-5}", "{0,-15}", "{0,-10}", "{0,-45}" };
            string[] header = { "ID", "Date", "Time", "Doctor" };
            displayListIntoListBox(list,fmt,header,patientsListBox);
        }

        private void previousConsultsButton_Click(object sender, EventArgs e)
        {
            string id = patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select a.id as ID,date_format(day_time,'%m/%d/%Y') as 'Date',date_format(day_time,'%H:%i') as 'Time',concat(d.fname,' ',d.lname) as 'Doctor'";
            sql += " from appointment a, doctor d";
            sql += " where a.doctor_fk = d.id";
            sql += " and a.patient_fk = " + id;
            sql += " and day_time < curdate()";
            sql += " and status <> 'CANCELLED'";
            List<Object[]> list = queryIntoListOfObjects(sql, 4);
            string[] fmt = { "{0,-5}", "{0,-15}", "{0,-10}", "{0,-45}" };
            string[] header = { "ID", "Date", "Time", "Doctor" };
            displayListIntoListBox(list, fmt, header, patientsListBox);
        }

        private void allPrescriptionsButton_Click(object sender, EventArgs e)
        {
            string id = patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select a.id as 'Appointment_ID',date_format(day_time,'%m/%d/%Y') as 'Date',concat(d.fname,' ',d.lname) as 'Doctor',";
            sql += " concat(p.title,': ',p.description) as Prescription";
            sql += " from appointment a, doctor d, prescription p";
            sql += " where a.doctor_fk = d.id";
            sql += " and a.id = p.appointment_fk";
            sql += " and a.patient_fk = " + id;
            sql += " and status <> 'CANCELLED'";
            List<Object[]> list = queryIntoListOfObjects(sql, 4);
            string[] fmt = { "{0,-16}", "{0,-15}", "{0,-20}", "{0,-300}" };
            string[] header = { "Appointment_ID", "Date", "Doctor", "Prescription" };
            displayListIntoListBox(list, fmt, header, patientsListBox);
        }

        private void viewDetailsPatientButton_Click(object sender, EventArgs e)
        {
            string id = patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select id as ID, phn as PHN, fname as 'First Name', lname as 'Last Name', gender as Gender,";
            sql += " date_format(birth,'%m/%d/%Y') as Birth, height as 'Height(cm)', weight as 'Weight(lbs)', allergies as Allergies";
            sql += " from patient where id = " + id;
            List<Object[]> list = queryIntoListOfObjects(sql, 9);
            string[] fmt = { "{0,-5}", "{0,-16}", "{0,-15}", "{0,-15}", "{0,-8}", "{0,-12}", "{0,-12}", "{0,-13}", "{0,-100}" };
            string[] header = { "ID", "PHN", "First Name", "Last Name", "Gender", "Birth", "Height(cm)", "Weight(lbs)", "Allergies" };
            displayListIntoListBox(list, fmt, header, patientsListBox);
        }

        private void removePatientButton_Click(object sender, EventArgs e)
        {
            string id = patientsDataGridView.Rows[patientsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "delete from patient where id = " + id;
            int rows = nonQuery(sql);
            if (rows > 0)
            {
                MessageBox.Show("Patient deleted");
            }
            else
            {
                MessageBox.Show("Removing patient failed");
            }
        }

        private void showDoctorAppointmentsButton_Click(object sender, EventArgs e)
        {
            string id = doctorsDataGridView.Rows[doctorsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select a.id as ID,date_format(day_time,'%m/%d/%Y') as 'Date',date_format(day_time,'%H:%i') as 'Time',concat(p.fname,' ',p.lname) as 'Patient'";
            sql += " from appointment a, patient p";
            sql += " where a.patient_fk = p.id";
            sql += " and a.doctor_fk = " + id;
            sql += " and day_time > curdate()";
            sql += " and status <> 'CANCELLED'";
            List<Object[]> list = queryIntoListOfObjects(sql, 4);
            string[] fmt = { "{0,-5}", "{0,-15}", "{0,-10}", "{0,-45}" };
            string[] header = { "ID", "Date", "Time", "Patient" };
            displayListIntoListBox(list, fmt, header, doctorsListBox);
        }

        private void showPatientsButton_Click(object sender, EventArgs e)
        {
            string id = doctorsDataGridView.Rows[doctorsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "select distinct(p.id) as ID,concat(p.fname,' ',p.lname) as 'Patient'";
            sql += " from appointment a, patient p";
            sql += " where a.doctor_fk = " + id;
            sql += " and a.patient_fk = p.id";
            sql += " and status <> 'CANCELLED'";
            List<Object[]> list = queryIntoListOfObjects(sql, 2);
            string[] fmt = { "{0,-5}", "{0,-45}" };
            string[] header = { "ID", "Patient" };
            displayListIntoListBox(list, fmt, header, doctorsListBox);
        }

        private void removeDoctorButton_Click(object sender, EventArgs e)
        {
            string id = doctorsDataGridView.Rows[doctorsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sql = "delete from doctor where id = " + id;
            int rows = nonQuery(sql);
            if (rows > 0)
            {
                MessageBox.Show("Doctor deleted");
            }
            else
            {
                MessageBox.Show("Removing doctor failed");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            showDailyAppointments();
        }

        public void showDailyAppointments()
        {
            string sql = "select a.id as ID,date_format(a.day_time,'%H:%i') as 'Time',";
            sql += "concat(d.fname,' ',d.lname) as Doctor, concat(p.fname,' ',p.lname) as Patient, status as Status";
            sql += " from appointment a, patient p, doctor d";
            sql += " where date_format(day_time,'%Y-%m-%d') = '" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "'";
            sql += " and a.patient_fk = p.id";
            sql += " and a.doctor_fk = d.id";
            sql += " order by Time,Doctor,Patient";
            queryIntoGrid(sql, appointmentsDataGridView);
        }

        private void appointmentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int id = 0;
            //doctorsListBox.Items.Clear();
            if (appointmentsDataGridView.CurrentRow != null)
            {
                if (int.TryParse(appointmentsDataGridView.Rows[appointmentsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), out id))
                {
                    attendedButton.Enabled = true;
                    cancelledButton.Enabled = true;
                    addPrescriptionButton.Enabled = true;
                    return;
                }
            }
            attendedButton.Enabled = false;
            cancelledButton.Enabled = false;
            addPrescriptionButton.Enabled = false;
        }

        private void attendedButton_Click(object sender, EventArgs e)
        {
            string sql = "update appointment set status='ATTENDED' where status =''";
            sql += " and id = " + appointmentsDataGridView.Rows[appointmentsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            nonQuery(sql);
            showDailyAppointments();
        }

        private void cancelledButton_Click(object sender, EventArgs e)
        {
            string sql = "update appointment set status='CANCELLED' where status =''";
            sql += " and id = " + appointmentsDataGridView.Rows[appointmentsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            nonQuery(sql);
            showDailyAppointments();
        }

        private void addPrescriptionButton_Click(object sender, EventArgs e)
        {
            Prescription window = new Prescription(this, appointmentsDataGridView.Rows[appointmentsDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //window.Show(); // Modeless
            window.ShowDialog(this); // Modal
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                showDailyAppointments();
            }
        }


        /* non query
        string instruction = "INSERT into Patient(firstname,lastname,dob,address,city,province) values (@vlname, @vfname, @vdob, @vadd, @vcity, @vpro)";
            //open connection
            if (connection != null)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = connection.CreateCommand();
                //MySqlCommand cmd = new MySqlCommand(instruction, connection);
                cmd.CommandText = instruction;
                cmd.Parameters.AddWithValue("@vlname", firstNTextBox.Text);
                cmd.Parameters.AddWithValue("@vfname", lastNTextBox.Text);
                cmd.Parameters.AddWithValue("@vdob", dobTextBox.Text);
                cmd.Parameters.AddWithValue("@vadd", addTextBox.Text);
                cmd.Parameters.AddWithValue("@vcity", cityTextBox.Text);
                cmd.Parameters.AddWithValue("@vpro", proTextBox.Text);
                //Execute command
                cmd.ExecuteNonQuery();
                showAll();

            }
         */
    }
}
