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
    public partial class ViewAppointments : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public ViewAppointments(int id, Receptionist_Controller controller)
        {
            InitializeComponent();
            controllerObj = controller;
            this.id = id;
            DataTable dt = controllerObj.ViewAllAppointments();
            dataGridView1.DataSource = dt;
        }

        private void ViewAppointments_Load(object sender, EventArgs e)
        {

        }
    }
}
