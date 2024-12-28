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
    public partial class history : Form
    {
        private int ID;
        private Cust_controller controller = new Cust_controller();
        public history(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void history_Load(object sender, EventArgs e)
        {
            DataTable dt = controller.Get_cust_history(ID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            appointment.DataSource = controller.get_unrated(ID);
            appointment.DisplayMember = "indetifer";
            appointment.ValueMember = "appointmentid";

            for (int i = 0; i < 6; i++)
            {
                rating.Items.Add(i);
            }

            //comboBox1.DataSource = control.ShowEmailCombo();
            //comboBox1.DisplayMember = "";
            //comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rating.SelectedIndex == -1 ||string.IsNullOrWhiteSpace(feedback.Text) ) {
            MessageBox.Show("Please fill all fields");
            }
            else
            {
                MessageBox.Show("Feedback submitted");
                controller.give_feedback(appointment.SelectedValue.ToString(), rating.SelectedItem.ToString(), feedback.Text.ToString());
                dataGridView1.Refresh();
                appointment.Refresh();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
