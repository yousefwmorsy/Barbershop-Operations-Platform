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
        public BarberAttendence()
        {
            InitializeComponent();
            controllerObject = new BarberController();  
        }

        private void BarberAttendence_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }
    }
}
