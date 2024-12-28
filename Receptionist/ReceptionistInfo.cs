using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Barbershop_Operations_Platform.Receptionist
{
    public partial class ReceptionistInfo : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public ReceptionistInfo(int id, Receptionist_Controller controllerObj)
        {
            InitializeComponent();
            this.id = id;
            DataTable dt = controllerObj.GetPersonalInfo(63);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                textBox1.Text = row["Name"].ToString();
                textBox3.Text = (row["OnDayOff"].ToString() == "False") ? "Available" : "On Day Off";
                textBox4.Text = row["Phone_number"].ToString();
                textBox5.Text = row["Address"].ToString();
                textBox6.Text = row["Email"].ToString();
            }
            this.controllerObj = controllerObj;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 12 && textBox4.Text.All(char.IsDigit))
            {
                //phone number updating
                if (controllerObj.UpdatePhone(id, textBox4.Text) != 0)
                    MessageBox.Show("Phone number updated successfully");
                else MessageBox.Show("Error!");
            }
            else
            {
                // phone number invalid
                MessageBox.Show("Invalid phone number. Please enter a 12-digit number.");
            }
            if (textBox6.Text.Length != 0 && textBox6.Text.Contains("@"))
            {
                //email updating
                if (!Regex.IsMatch(textBox6.Text, @"^[a-zA-Z0-9_]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Enter Valid Email");
                    return;
                }
                if (controllerObj.UpdateEmail(id, textBox6.Text) != 0)
                    MessageBox.Show("Email updated successfully");
                else MessageBox.Show("Error!");
            }
            else
            {
                // empty or invalid
                MessageBox.Show("Invalid email. Please re-enter your email.");
            }
            if (textBox5.Text.Length != 0)
            {
                //address updating
                if (controllerObj.UpdateAddress(id, textBox5.Text) != 0)
                    MessageBox.Show("Address updated successfully");
                else MessageBox.Show("Error!");
            }
            if (checkBox1.Checked)
            {
                if (textBox7.Text.Length < 8)
                {
                    MessageBox.Show("Password should be longer than 8 digits");
                    return;
                }
                if (textBox8.Text != textBox7.Text)
                {
                    MessageBox.Show("Passwords do no match");
                    return;
                }
                if (controllerObj.UpdatePassword(id, textBox7.Text) != 0)
                    MessageBox.Show("Password updated successfully");
                else MessageBox.Show("Error!");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label8.Visible = true;
                label9.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label9.Visible = false;
                textBox8.Visible = false;
                textBox7.Visible = false;
            }
        }
    }
}
