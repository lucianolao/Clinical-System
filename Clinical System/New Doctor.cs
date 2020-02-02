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
    public partial class New_Doctor : Form
    {
        private Form1 form1;

        public New_Doctor()
        {
            InitializeComponent();
        }

        public New_Doctor(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (addDoctorTextBox1.Text.Trim() == "" || addDoctorTextBox2.Text.Trim() == "" || addDoctorTextBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please, fill all the fields");
            }
            else if (!addDoctorTextBox1.Text.Trim().All(c => Char.IsLetter(c) || c == ' ') || !addDoctorTextBox2.Text.Trim().All(c => Char.IsLetter(c) || c == ' ') || !addDoctorTextBox3.Text.Trim().All(c => Char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Please, use only latin alphabet");
            }
            else
            {
                string sql = "insert into doctor(fname,lname,specialization) values(";
                sql += "'" + addDoctorTextBox1.Text.Trim() + "','" + addDoctorTextBox2.Text.Trim() + "','" + addDoctorTextBox3.Text.Trim() + "')";
                int rows = form1.nonQuery(sql);
                if (rows > 0)
                    MessageBox.Show("Doctor registered");
                else
                    MessageBox.Show("Error: no rows affected");
                this.Close();
            }
        }
    }
}
