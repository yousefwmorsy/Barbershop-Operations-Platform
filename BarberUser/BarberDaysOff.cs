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
        public BarberDaysOff()
        {
            InitializeComponent();
            controllerObject = new BarberController();
        }

        private void BarberDaysOff_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }

        private void availability_button_Click(object sender, EventArgs e)
        {

        }

        private void reqDaysOff_button_Click(object sender, EventArgs e)
        {
            string startTime = startDate_datePicker.Value.ToString("yyyy-MM-dd");
            string endTime = endDate_datePicker.Value.ToString("yyyy-MM-dd");
        }
    }
}
