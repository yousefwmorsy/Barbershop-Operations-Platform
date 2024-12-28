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
    public partial class ViewCustomer_sHistories : Form
    {
        ManagerClassController controller = new ManagerClassController();
        public ViewCustomer_sHistories()
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.GetCustomers();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = int.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            dataGridView2.DataSource = controller.GetCustomersHistory(id);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomer_sHistories_Load(object sender, EventArgs e)
        {

        }
    }
}
