using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (!string.IsNullOrWhiteSpace(first_name.Text))
            {
                controller.update_cust_info(ID, "Fname", first_name.Text);
            }
            if (!string.IsNullOrWhiteSpace(Lname.Text))
            {
                controller.update_cust_info(ID, "Lname", Lname.Text);
            }
            if (checkBox1.Checked)
            {
                controller.update_cust_info(ID, "BDate", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            }
            if (!string.IsNullOrWhiteSpace(phone_number.Text))
            {
                controller.update_cust_info(ID, "phone_number", phone_number.Text);
            }
            if (!string.IsNullOrWhiteSpace(email.Text))
            {
                controller.update_cust_info(ID, "Email", email.Text);
            }
            if (!string.IsNullOrWhiteSpace(haicutdetails.Text))
            {
                controller.update_cust_info(ID, "haircut_details", haicutdetails.Text);
            }
            if (!string.IsNullOrWhiteSpace(password.Text))
            {
                controller.update_cust_info(ID, "password", password.Text);
            }


            // controller.update_cust_info(ID,"email",email.Text);
        }
    }
}
