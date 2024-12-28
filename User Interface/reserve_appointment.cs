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
            for (int i = 0; i < 24; i++)
            {
                time.Items.Add(i.ToString("D2") + ":00");
            }
        }



        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                price_.Text = controller.getprice(service.SelectedValue.ToString(),dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
            }

        }

        private void service_ValueMemberChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (time.SelectedIndex == -1)
            {
                MessageBox.Show("select a time");
            }
            else if (method.SelectedIndex==-1)
            {
                MessageBox.Show("select a payment method");
            }
            else if (price_.Text == "0")
            {
                MessageBox.Show("select a service");
            }
            else
            {

            int temp = controller.addpayment(method.SelectedItem.ToString(), Int32.Parse(service.SelectedValue.ToString()));

                if (method.SelectedItem.ToString() == "online")
                {
                    Random random = new Random();
                    string randomNumber = "";
                    for (int i = 0; i < 10; i++)
                    {
                        randomNumber += random.Next(0, 10).ToString(); // Generates digits 0-9
                    }
                    MessageBox.Show($"pay with the code \n {randomNumber}\n Appointment will be cancelled if not paid within 3 hours");
                }
                else if (method.SelectedItem.ToString() == "points") {
                    int current =controller.getpoints(id);
                    if(current< Int32.Parse(price_.Text))
                    {
                        MessageBox.Show("you do not have enough points");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("you have enough points");
                        controller.updatepoints(id, current -Int32.Parse(price_.Text));
                    }
                }
            DateTime appointmentDate = dateTimePicker1.Value.Date; // Get only the date part
            TimeSpan appointmentTime = TimeSpan.Parse(time.SelectedItem.ToString()); // Parse the time string

            DateTime appointmentDateTime = appointmentDate.Add(appointmentTime);

            string appointmentDateTimeString = appointmentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            int excuted = controller.add_appointment(id, Int32.Parse(service.SelectedValue.ToString()), temp, appointmentDateTimeString);
            if (excuted == 1)
            {
                MessageBox.Show("Appointment reserved successfully");
            }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (service.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                price_.Text = controller.getprice(service.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy/MM/dd")).ToString();
            }
        }
    }
}
