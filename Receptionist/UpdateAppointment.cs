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

namespace Barbershop_Operations_Platform.Receptionist
{
    public partial class UpdateAppointment : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public UpdateAppointment(int id, Receptionist_Controller controller)
        {
            InitializeComponent();
            controllerObj = controller;
            this.id = id;
            DataTable comb = controllerObj.ViewAllAppointmentsID();
            if (comb == null) return;
            DataTable dt = comb.Copy();
            comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Customer");

            dataGridView1.DataSource = dt;
            comboBox1.DataSource = comb;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select!");
                return;
            }
            if (radioButton1.Checked) {
                if (controllerObj.Delete((int)comboBox1.SelectedValue) != 0)
                {
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Error Encountered!");
                }
            }
            else if (radioButton2.Checked) {
                if (controllerObj.MarkDone((int)comboBox1.SelectedValue)!=0)
                {
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Error Encountered!");
                }
            }
            else
            {
                MessageBox.Show("Please choose");
            }
            DataTable comb = controllerObj.ViewAllAppointmentsID();
            if (comb == null) return;
            DataTable dt = comb.Copy();
            comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Customer");

            dataGridView1.DataSource = dt;
            comboBox1.DataSource = comb;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "ID";
        }
    }
}
