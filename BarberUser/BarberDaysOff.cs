using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.BarberUser
{
    public partial class BarberDaysOff : Form
    {
        BarberController controllerObject;
        int barberID;
        public BarberDaysOff(int barberid)
        {
            InitializeComponent();
            controllerObject = new BarberController();
            barberID = barberid;

            dataGridView2.DataSource = controllerObject.GetDaysOffRequests(barberID);
        }

        private void BarberDaysOff_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }

        private void reqDaysOff_button_Click(object sender, EventArgs e)
        {
            DateTime start = startDate_datePicker.Value.Date;
            DateTime end = endDate_datePicker.Value.Date;
            DateTime today = DateTime.Today;
            if (start <= today || end <= today)
            {
                MessageBox.Show("Enter Valid Dates");
                return;
            }
            string startString = start.ToString("yyyy-MM-dd");
            string endString = end.ToString("yyyy-MM-dd");

            if (controllerObject.CheckDaysOffEligiblitiy(startString, endString, barberID) > 0)
            {
                dataGridView1.DataSource = controllerObject.GetDaysOffClashes(startString, endString, barberID);
                MessageBox.Show("Days requested overlap another request");

                return;
            }
            int x = controllerObject.InsertDaysOffRequest(barberID, startString, endString);
            dataGridView2.DataSource = controllerObject.GetDaysOffRequests(barberID);
            if (x > 0)
            {
                MessageBox.Show("Inserted Successfuly");
            }
        }
    }
}
