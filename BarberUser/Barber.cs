using Barbershop_Operations_Platform.BarberUser;
using Barbershop_Operations_Platform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform
{
    public partial class Barber : Form
    {
        private BarberController controllerObj;
        private Button currentClickedButton;
        private int barberID;
        public static Panel BarberMainPanel;
        public Barber(int barber_id)
        {
            InitializeComponent();
            controllerObj = new BarberController();
            barberID = barber_id;
            BarberMainPanel = panel1;
            currentClickedButton = info_button;
            currentClickedButton.Enabled = false;
            MessageBox.Show(barber_id.ToString());
        }

        private void Barber_Load(object sender, EventArgs e)
        {
            BarberInfo barberInfo = new BarberInfo(barberID);
            SwitchFormButton(barberInfo);
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            BarberInfo barberInfo = new BarberInfo(barberID);
            SwitchFormButton(barberInfo);
            currentClickedButton.Enabled = true;
            currentClickedButton = info_button;
            currentClickedButton.Enabled = false;
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            BarberSchedule barberSchedule = new BarberSchedule(barberID);
            SwitchFormButton(barberSchedule);
            currentClickedButton.Enabled = true;
            currentClickedButton = schedule_button;
            currentClickedButton.Enabled = false;
        }

        private void SwitchFormButton(Form f)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Form)
                {
                    // Close the form if it's already in the panel
                    ((Form)ctrl).Close();  // Close the form
                }
            }
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }

        private void requestDaysOff_button_Click(object sender, EventArgs e)
        {
            BarberDaysOff barberDaysOff = new BarberDaysOff();
            SwitchFormButton(barberDaysOff);
            currentClickedButton.Enabled = true;
            currentClickedButton = requestDaysOff_button;
            currentClickedButton.Enabled = false;
        }

        private void reqSupplies_button_Click(object sender, EventArgs e)
        {
            BarberSupplies barberSupplies = new BarberSupplies(barberID);
            SwitchFormButton(barberSupplies);
            currentClickedButton.Enabled = true;
            currentClickedButton = reqSupplies_button;
            currentClickedButton.Enabled = false;
        }

        private void attendence_button_Click(object sender, EventArgs e)
        {
            BarberAttendence barberAttendence = new BarberAttendence();
            SwitchFormButton(barberAttendence);
            currentClickedButton.Enabled = true;
            currentClickedButton = attendence_button;
            currentClickedButton.Enabled = false;
        }

        private void incident_button_Click(object sender, EventArgs e)
        {
            BarberIncident barberIncident = new BarberIncident();
            SwitchFormButton(barberIncident);
            currentClickedButton.Enabled = true;
            currentClickedButton = incident_button;
            currentClickedButton.Enabled = false;
        }
    }
}
