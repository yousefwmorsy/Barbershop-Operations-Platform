using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barbershop_Operations_Platform.Receptionist;

namespace Barbershop_Operations_Platform
{
    public partial class Receptionest : Form
    {
        int id;
        DBManager dbMan;
        Receptionist_Controller controllerObj;
        
        public Receptionest(int id)
        {
            InitializeComponent();
            dbMan = new DBManager();
            controllerObj = new Receptionist_Controller(dbMan);
            this.id = id;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OfflinePayment Payment = new OfflinePayment(id, controllerObj);
            Payment.Dock = DockStyle.Fill;
            Payment.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Payment);
            Payment.Show();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistInfo Info = new ReceptionistInfo(id, controllerObj);
            Info.Dock = DockStyle.Fill;
            Info.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Info);
            Info.Show();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageAppointments Manage = new ManageAppointments(id, controllerObj);
            Manage.Dock = DockStyle.Fill;
            Manage.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Manage);
            Manage.Show();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void Receptionest_Load(object sender, EventArgs e)
        {
            ReceptionistInfo Info = new ReceptionistInfo(id, controllerObj);
            Info.Dock = DockStyle.Fill;
            Info.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Info);
            Info.Show();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestDaysOff daysoff = new RequestDaysOff(id, controllerObj);
            daysoff.Dock = DockStyle.Fill;
            daysoff.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(daysoff);
            daysoff.Show();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
