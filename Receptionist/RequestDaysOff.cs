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
    public partial class RequestDaysOff : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public RequestDaysOff(int id, Receptionist_Controller control)
        {
            InitializeComponent();
            controllerObj = control;
            this.id = id;
            DataTable dt = controllerObj.ViewPrevRequests(id);
            dataGridView1.DataSource = dt;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string startTime = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string endTime = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Error encountered. End date must be after start date!");
                return;
            }
            if (controllerObj.CheckRepeatedRequests(id, startTime, endTime)!=0)
            {
                MessageBox.Show("Error encountered. Request already submitted!");

            }
            else
            {
                if (controllerObj.InsertDayOffRequest(id, startTime, endTime) != 0)
                {
                    DataTable dt = controllerObj.ViewPrevRequests(id);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Request Done Successfully");
                }
                else
                {
                    MessageBox.Show("Error encountered please try again");
                }
            }
        }
    }
}
