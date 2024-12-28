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
    public partial class OfflinePayment : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public OfflinePayment(int id, Receptionist_Controller control)
        {
            InitializeComponent();
            this.id = id;
            controllerObj = control;

            DataTable dt = controllerObj.GetOfflinePayments();
            dataGridView1.DataSource = dt;
            if (dt == null) return;
            DataTable comb = dt.Copy();
            comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Customer + ' - ' + Service");
            comboBox1.DataSource = comb;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "ID";

        }

        private void OfflinePayment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select!");
                return;
            }
            if (controllerObj.CustPaid(id, (int)comboBox1.SelectedValue) != 0)
            {
                MessageBox.Show("Successfull!");
                DataTable dt = controllerObj.GetOfflinePayments();
                dataGridView1.DataSource = dt;
                if (dt == null) return;
                DataTable comb = dt.Copy();
                comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Customer + ' - ' + Service");
                comboBox1.DataSource = comb;
                comboBox1.DisplayMember = "DisplayName";
                comboBox1.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Error Encountered!");
            }
        }
    }
}
