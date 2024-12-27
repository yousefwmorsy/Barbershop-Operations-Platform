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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
