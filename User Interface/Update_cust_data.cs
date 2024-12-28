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

namespace Barbershop_Operations_Platform.User_Interface
{
    public partial class Update_cust_data : Form
    {
        private int ID;
        private Cust_controller controller = new Cust_controller();
        public Update_cust_data(int ID)
        {
            InitializeComponent();
            this.ID = ID;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            //if (!EmailBox.Text.Contains('@') && string.IsNullOrWhiteSpace(EmailBox.Text) && !Regex.IsMatch(EmailBox.Text, pattern))
            //{
            //    MessageBox.Show("enter a valid email name");
            //}
            //else if (NPassBox.Text != REENPassBox.Text && string.IsNullOrWhiteSpace(NPassBox.Text))
            //{
            //    MessageBox.Show("Passwords do not match");
            //}
            //else if (Int32.TryParse(FNBox.Text, out trashcan) && string.IsNullOrWhiteSpace(FNBox.Text) && Regex.IsMatch(FNBox.Text, pattern))
            //{
            //    MessageBox.Show("enter a valid first name");
            //}
            //else if (Int32.TryParse(LNBox.Text, out trashcan) && string.IsNullOrWhiteSpace(LNBox.Text) && Regex.IsMatch(LNBox.Text, pattern))
            //{
            //    MessageBox.Show("enter a valid last name");
            //}
            //else if (!Int32.TryParse(PHBox.Text, out trashcan) && PHBox.Text.Length != 11)
            //{
            //    MessageBox.Show("enter a valid phone name");
            //}
            string patternemail = @"[^a-zA-Z0-9\s,.-@]";
            string pattern = @"[^a-zA-Z\s]";
            int trashcan = 0;
            if (!(string.IsNullOrWhiteSpace(first_name.Text)&& !Int32.TryParse(first_name.Text, out trashcan) ))
            {
                if ( !Regex.IsMatch(first_name.Text, pattern)&&controller.update_cust_info(ID, "Fname", first_name.Text) == 1)
                {
                    MessageBox.Show("first name updated");
                }
            }
            if (!(!Int32.TryParse(Lname.Text, out trashcan) && string.IsNullOrWhiteSpace(Lname.Text) ))
            {
                if (!Regex.IsMatch(Lname.Text, pattern)&&controller.update_cust_info(ID, "Lname", Lname.Text) == 1)
                {
                    MessageBox.Show("last name updated");
                }
            }
            if (checkBox1.Checked)
            {
                if (controller.update_cust_info(ID, "BDate", dateTimePicker1.Value.ToString("yyyy/MM/dd")) == 1)
                {
                    MessageBox.Show("Birthdate updated");
                }
            }
            if (!(!Int32.TryParse(phone_number.Text, out trashcan) && phone_number.Text.Length != 11))
            {
                if (controller.update_cust_info(ID, "phone_number", phone_number.Text) == 1)
                {
                    MessageBox.Show("phone number updated");
                }
            }
            if (!(!email.Text.Contains('@') && string.IsNullOrWhiteSpace(email.Text) && !Regex.IsMatch(email.Text, patternemail)))
            {
                if (controller.update_cust_info(ID, "Email", email.Text) == 1)
                {
                    MessageBox.Show("email updated");
                }
            }
            if (!string.IsNullOrWhiteSpace(haicutdetails.Text))
            {
                if (controller.update_cust_info(ID, "haircut_details", haicutdetails.Text) == 1)
                {
                    MessageBox.Show("haircut details updated");
                }
            }
            if (!string.IsNullOrWhiteSpace(password.Text))
            {
                if (controller.update_cust_info(ID, "password", password.Text) == 1)
                {
                    MessageBox.Show("password updated");
                }
            }
        }
    }
}
