using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Barbershop_Operations_Platform.BarberUser
{
    public partial class BarberIncident : Form
    {
        BarberController controllerobject;
        int barberID;
        public BarberIncident(int barberid)
        {
            InitializeComponent();
            controllerobject = new BarberController();
            barberID = barberid;
            incident_text.MaxLength = 300;

            DataTable dt = controllerobject.GetAppointmentsWithoutIncidents(barberID);
            if (dt == null)
            {
                emptyDataGrid_label.Visible = true;
                dataGridView1.Visible = false;
                comboBox1.Visible = false;
                incident_button.Visible = false;
                incident_text.Visible = false;
            }
            else
            {
                dataGridView1.DataSource = dt;
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Appointment Number";
                comboBox1.ValueMember = "Appointment Number";
            }
        }

        private void BarberIncident_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerobject.TerminateConnection();
        }

        private void incident_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(incident_text.Text))
            {
                MessageBox.Show("Incident Report Can't be empty");
                return;
            }
            if (Regex.IsMatch(incident_text.Text, @"['"";-]")) 
            {
                MessageBox.Show("Can't Enter Special Characters");
                return;
            }

        }
    }
}
