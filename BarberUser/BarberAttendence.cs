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
    public partial class BarberAttendence : Form
    {
        BarberController controllerObject;
        int barberID;
        public BarberAttendence(int barberid)
        {
            InitializeComponent();
            controllerObject = new BarberController();  
            barberID = barberid;

            dataGridView1.DataSource = controllerObject.GetAttendanceLog(barberID);
        }

        private void BarberAttendence_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int hour = DateTime.Now.Hour;

            DataTable info_dt = controllerObject.GetPersonalInfo(barberID);
            int startHour = DateTime.Parse(info_dt.Rows[0]["Start_Time"].ToString()).Hour;
            int endHour = DateTime.Parse(info_dt.Rows[0]["End_Time"].ToString()).Hour;


            if ((hour >= startHour && hour < endHour) == false)    // Assuming start < end Always
            {
                MessageBox.Show("Can't Log Attendence, Wait for your shift");
                return;
            }

            DataTable log_dt = controllerObject.GetAttendanceLog(barberID);
            if (log_dt == null)
            {
                controllerObject.InsertAttendance(barberID);
                dataGridView1.DataSource = controllerObject.GetAttendanceLog(barberID);
                MessageBox.Show("Logged Attendance Successfuly");
                return;
            }

            DateTime dt_date = DateTime.Parse(log_dt.Rows[0]["date"].ToString());

            if (dt_date == today)
            {
                MessageBox.Show("Attendance Already Logged For Today");
                return;
            }

            controllerObject.InsertAttendance(barberID);
            dataGridView1.DataSource = controllerObject.GetAttendanceLog(barberID);
            MessageBox.Show("Logged Attendance Successfuly");
        }
    }
}
