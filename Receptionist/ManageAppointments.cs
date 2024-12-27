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
            ViewAppointments app = new ViewAppointments(id, controllerObj);
            app.Dock = DockStyle.Fill;
            app.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(app);
            app.Show();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OfflineAppointment app = new OfflineAppointment(id, controllerObj);
            app.Dock = DockStyle.Fill;
            app.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(app);
            app.Show();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAppointments app = new ViewAppointments(id, controllerObj);
            app.Dock = DockStyle.Fill;
            app.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(app);
            app.Show();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            AssignBarber assign = new AssignBarber(id, controllerObj);
            assign.Dock = DockStyle.Fill;
            assign.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(assign);
            assign.Show();
        }

  
    }
}
