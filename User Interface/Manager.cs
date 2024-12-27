using Barbershop_Operations_Platform.User_Interface.ManageEmployees;
using Barbershop_Operations_Platform.User_Interface.ManagersTools;
using Barbershop_Operations_Platform.User_Interface.ManageSupliesRequest;
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
    public partial class Manager : Form
    {
        bool t = false; int i;
        public Manager(bool type, int id)
        {
            InitializeComponent();
            t = type;
            i = id;
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void ManageEmployeesButton_Click(object sender, EventArgs e)
        {
            Form F = new ManageEmployees(t, i);
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ManageSupplysReqButton_Click(object sender, EventArgs e)
        {
            Form F = new ManageSuppliesRequest(i);
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ViewBHistoriesButton_Click(object sender, EventArgs e)
        {
            Form F = new ViewBarber_sHistrory();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ViewCHistoriesButton_Click(object sender, EventArgs e)
        {
            Form F = new ViewBarber_sHistrory();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }

        private void ViewCHistoriesButton_Click_1(object sender, EventArgs e)
        {
            Form F = new ViewCustomer_sHistories();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(F);
            F.Show();
        }
    }
}
