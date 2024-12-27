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
    public partial class OfflineAppointment : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public OfflineAppointment(int id, Receptionist_Controller control)
        {
            InitializeComponent();
            this.id = id;
            controllerObj = control;
            dateTimePicker1.MinDate = DateTime.Now;
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString("D2") + ":00");
            }
            comboBox2.DataSource = controllerObj.GetServices();
            comboBox2.ValueMember = "service_id";
            comboBox2.DisplayMember = "service_name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OfflineAppointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter name");
                return;
            }
            string name = textBox1.Text;
            string apptime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " " + comboBox1.Text + ":00";
            int serviceid = (int)comboBox2.SelectedValue;
            if (controllerObj.AddOfflineAppointment(name, apptime, serviceid, id) != 0)
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Error encountered");
            }
        }
    }
}
