using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManagersTools
{
    public partial class ViewFinancialsStatistics : Form
    {
        ManagerClassController controller;
        public ViewFinancialsStatistics()
        {
            InitializeComponent();
            
            controller = new ManagerClassController();
            numDaysOff_label.Text = controller.GetNumberOfAcceptedDaysOff().ToString();
            avgRequestCost_label.Text = controller.GetAvgSupplyRequestPrice().ToString("F3");

            DataTable appointment_dt = controller.GetMostAppointmentsCustomer();
            string custName = appointment_dt.Rows[0]["Name"].ToString();
            string numOfAppointments = appointment_dt.Rows[0]["appointment count"].ToString();
            maxAppointments_label.Text = "Name: " + custName + " \nNumber of Appointments: " + numOfAppointments;


            DataTable customer_dt = controller.GetCustomersTotalProfit();
            dataGridView1.DataSource = customer_dt.DefaultView.ToTable(false, "Customer Name", "Total Profit");

            DataTable supply_dt = controller.GetSupplyTotalCost();
            dataGridView2.DataSource = supply_dt.DefaultView.ToTable(false, "Supply Name", "Total Supply Cost");

            totalProfit_label.Text = controller.GetTotalProfit().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
