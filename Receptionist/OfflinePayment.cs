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
    public partial class OfflinePayment : Form
    {
        int id;
        Receptionist_Controller controllerObj;
        public OfflinePayment(int id, Receptionist_Controller control)
        {
            InitializeComponent();
            this.id = id;
            controllerObj = control;
        }

        private void OfflinePayment_Load(object sender, EventArgs e)
        {

        }
    }
}
