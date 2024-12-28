using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    public partial class ManageEmployees : Form
    {
        int ID;
        public ManageEmployees(bool type, int id)
        {
            InitializeComponent();
            ManageManagers.Hide();
            if (type)
            {
                ManageManagers.Show();
            }
            ID = id;
        }

        private void ManageBarbersButton_Click(object sender, EventArgs e)
        {
            Form F = new ManageBarber(ID);
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {

        }

        private void ManageReceptionistsButton_Click(object sender, EventArgs e)
        {
            Form F = new ManageReceptionist(ID);
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ManageManagers_Click(object sender, EventArgs e)
        {
            Form F = new ManageManagers(ID);
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ManageDaysOffButton_Click(object sender, EventArgs e)
        {
            Form F = new ManageDaysOff();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }
    }
}
