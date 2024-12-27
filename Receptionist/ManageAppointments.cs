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
    public partial class ManageAppointments : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public ManageAppointments(int id, Receptionist_Controller controllerObj)
        {
            InitializeComponent();
            this.id = id;
            this.controllerObj = controllerObj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignBarber assign = new AssignBarber();
            assign.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OfflineAppointment appointment = new OfflineAppointment();
            appointment.Show();
        }
    }
}
