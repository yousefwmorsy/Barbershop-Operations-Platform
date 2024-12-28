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
    public partial class AssignBarber : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public AssignBarber(int id, Receptionist_Controller control)
        {
            InitializeComponent();
            this.id = id;
            controllerObj = control;

            if (controllerObj.ViewTodayUnassignedAppointments() == null || controllerObj.ViewAvailableBarbers() == null) return;

            DataTable dt = controllerObj.ViewTodayUnassignedAppointments();
            dataGridView1.DataSource = dt;

            DataTable comb2 = controllerObj.ViewAvailableBarbers();
            DataTable dt2 = comb2.Copy();
            dt2.Columns.Remove("BarberID");
            dataGridView2.DataSource = dt2;

            

            DataTable comb = dt.Copy();
            comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Service");

            comboBox1.DataSource = comb;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "DisplayName";

            comboBox2.DataSource = comb2;
            comboBox2.ValueMember = "BarberID";
            comboBox2.DisplayMember = "Barber";
        }

        private void AssignBarber_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select!");
                return;
            }
            
            if (controllerObj.CheckBarberFree((int)comboBox2.SelectedValue, (int)comboBox1.SelectedValue) == 0)
            {
                TimeSpan start = controllerObj.GetBarberStart((int)comboBox2.SelectedValue);
                TimeSpan end = controllerObj.GetBarberEnd((int)comboBox2.SelectedValue);
                DateTime apptime1 = controllerObj.GetAppTime((int)comboBox1.SelectedValue);
                TimeSpan apptime = apptime1 - DateTime.Now.Date;
                if (apptime < start || apptime > end)
                {
                    MessageBox.Show("Barber is not available at this time!");
                }
                else
                {
                    if (controllerObj.AssignBarber((int)comboBox2.SelectedValue, (int)comboBox1.SelectedValue)!=0)
                    {
                        MessageBox.Show("Assignment Successful");
                        if (controllerObj.ViewTodayUnassignedAppointments() == null || controllerObj.ViewAvailableBarbers() == null) return;

                        DataTable dt = controllerObj.ViewTodayUnassignedAppointments();
                        dataGridView1.DataSource = dt;

                        DataTable comb2 = controllerObj.ViewAvailableBarbers();
                        DataTable dt2 = comb2.Copy();
                        dt2.Columns.Remove("BarberID");
                        dataGridView2.DataSource = dt2;



                        DataTable comb = dt.Copy();
                        comb.Columns.Add("DisplayName", typeof(string), "ID + ' - ' + Service");

                        comboBox1.DataSource = comb;
                        comboBox1.ValueMember = "ID";
                        comboBox1.DisplayMember = "DisplayName";

                        comboBox2.DataSource = comb2;
                        comboBox2.ValueMember = "BarberID";
                        comboBox2.DisplayMember = "Barber";
                    }
                    else
                    {
                        MessageBox.Show("Error Occurred!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Barber is busy at this time!");
            }
        }
    }
}
