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
    public partial class Prescription : Form
    {
        private Form1 form1;
        private string appointmentID;

        public Prescription()
        {
            InitializeComponent();
        }

        public Prescription(Form1 form1, string appointmentID)
        {
            InitializeComponent();
            this.form1 = form1;
            this.appointmentID = appointmentID;
        }

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            string sql = "insert into prescription(appointment_fk,title,description) values (";
            sql += appointmentID+",'"+titleTextBox.Text+"','"+descriptionRichTextBox.Text+"')";
            int rows = form1.nonQuery(sql);
            if (rows > 0)
            {
                MessageBox.Show("Prescription added succesfully");
            }
            else
            {
                MessageBox.Show("Adding prescription failed");
            }
        }
    }
}
