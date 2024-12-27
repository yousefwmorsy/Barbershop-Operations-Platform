using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                controllerObj.UpdatePhone(id, textBox4.Text);
                MessageBox.Show("Phone number updated successfully");
            }
            else
            {
                // phone number invalid
                MessageBox.Show("Invalid phone number. Please enter a 12-digit number.");
            }
            if (textBox6.Text.Length != 0 && textBox6.Text.Contains("@"))
            {
                //email updating
                controllerObj.UpdateEmail(id, textBox6.Text);
                MessageBox.Show("Email updated successfully");
            }
            else
            {
                // empty or invalid
                MessageBox.Show("Invalid email. Please re-enter your email.");
            }
            if (textBox5.Text.Length != 0)
            {
                //address updating
                controllerObj.UpdateAddress(id, textBox5.Text);
                MessageBox.Show("Address updated successfully");
            }
        }
    }
}
