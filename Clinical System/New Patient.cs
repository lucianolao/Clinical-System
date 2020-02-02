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
    public partial class New_Patient : Form
    {
        private Form1 form1;

        public New_Patient()
        {
            InitializeComponent();
        }

        public New_Patient(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            long PHN;
            int height;
            float weight;
            if (addPatientTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("PHN is a mandatory field");
            }
            else if (!long.TryParse(addPatientTextBox1.Text.Trim(), out PHN))
            {
                MessageBox.Show("PHN must be a numeric non-decimal value");
            }
            else if (addPatientTextBox2.Text.Trim() == "" || addPatientTextBox3.Text.Trim() == "")
            {
                MessageBox.Show("First and Last Name are mandatory fields");
            }
            else if (!addPatientTextBox2.Text.Trim().All(c => Char.IsLetter(c) || c == ' ') || !addPatientTextBox3.Text.Trim().All(c => Char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("First and Last Name should only contain latin letters");
            }
            else if (dateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("The birth date should not be ahead of today");
            }
            else if (addPatientTextBox4.Text.Trim() != "" && !int.TryParse(addPatientTextBox4.Text.Trim(), out height))
            {
                MessageBox.Show("Height must be an integer value");
            }
            else if (addPatientTextBox5.Text.Trim() != "" && !float.TryParse(addPatientTextBox5.Text.Trim(), out weight))
            {
                MessageBox.Show("Weight must be a decimal value");
            }
            else
            {
                string sql = "insert ignore into patient(phn,fname,lname,gender,birth,height,weight,allergies) values(";
                sql += addPatientTextBox1.Text.Trim() != "" ? "'" + addPatientTextBox1.Text.Trim() + "'," : "null,";
                sql += "'" + addPatientTextBox2.Text.Trim() + "','" + addPatientTextBox3.Text.Trim() + "',";
                sql += maleRadioButton.Checked ? "'M'," : "'F',";
                sql += "'" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "',";
                sql += addPatientTextBox4.Text.Trim() != "" ? addPatientTextBox4.Text.Trim() + "," : "null,";
                sql += addPatientTextBox5.Text.Trim() != "" ? addPatientTextBox5.Text.Trim() + "," : "null,";
                sql += richTextBox.Text.Trim() != "" ? "'" + richTextBox.Text.Trim() + "')" : "null)";
                int rows = form1.nonQuery(sql);
                if (rows > 0)
                {
                    MessageBox.Show("Patient registered");
                    this.Close();
                }
                else
                    MessageBox.Show("The patient was not registered. Please, verify whether the PHN is correct");
                
            }
        }
    }
}
