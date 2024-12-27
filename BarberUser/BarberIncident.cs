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
    public partial class BarberIncident : Form
    {
        BarberController controllerobject;
        int barberID;
        public BarberIncident(int barberid)
        {
            InitializeComponent();
            controllerobject = new BarberController();
            barberID = barberid;

        }

        private void BarberIncident_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerobject.TerminateConnection();
        }
    }
}
