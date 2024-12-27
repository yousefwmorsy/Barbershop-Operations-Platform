using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barbershop_Operations_Platform.User_Interface
{
    public partial class reserve_appointment : Form
    {
        private int id;
        private Cust_controller controller = new Cust_controller();
        public reserve_appointment(int ID)
        {
            InitializeComponent();
            id = ID;    
        }

        private void reserve_appointment_Load(object sender, EventArgs e)
        {
            service.DataSource = controller.getservices();
            service.DisplayMember = "service_name";
            service.ValueMember = "Service_id";
            service.Text = "Select Service";
            List<string> methods_payment = new List<string>()
    {
                "cash",
                "points",
                "online",

    };

            method.Items.AddRange(methods_payment.ToArray());
        }



        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                price_.Text = controller.getprice(service.SelectedValue.ToString()).ToString();
            }

        }

        private void service_ValueMemberChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (price_.Text == "0") {
                MessageBox.Show("select a service");
            }
           int temp=controller.addpayment(method.SelectedItem.ToString(),Int32.Parse(service.SelectedValue.ToString()));
            controller.add_appointment(id,Int32.Parse(service.SelectedValue.ToString()),temp, dateTimePicker1.Value.ToString("yyyy/MM/dd"));
        }
    }
}
