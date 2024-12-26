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
    public partial class BarberSchedule : Form
    {
        private BarberController controllerObject;
        int barberId;
        public BarberSchedule(int barberid)
        {
            InitializeComponent();
            barberId = barberid;
            controllerObject = new BarberController();
        }

        private void BarberSchedule_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObject.GetBarberSchedule(barberId);
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.Visible = false;
                emptyDataGrid_label.Visible = true;
            }    
        }

        private void BarberSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }
    }
}
