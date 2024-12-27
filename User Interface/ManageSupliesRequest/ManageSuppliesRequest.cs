using Barbershop_Operations_Platform.User_Interface.ManageEmployees.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManageSupliesRequest
{
    public partial class ManageSuppliesRequest : Form
    {
        int MID; DataTable dt;
        SuppReqController controller = new SuppReqController();
        public ManageSuppliesRequest(int id)
        {
            InitializeComponent();
            MID = id;
            dt = controller.ViewRequests(MID);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            dt = controller.ViewRequests(MID);
            dataGridView1.DataSource = dt.DefaultView.ToTable(false, "BName", "SupplyName", "Date", "Quantity", "Status");
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int ColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (RowIndex == -1 || ColumnIndex != 0)
            {
                MessageBox.Show("Please Select the SupplyRequest's id");
            }
            else
            {
                int s = controller.AcceptRequest(int.Parse(dt.Rows[RowIndex][0].ToString())
                    , int.Parse(dt.Rows[RowIndex][ColumnIndex + 2].ToString())
                    , DateTime.Parse(dt.Rows[RowIndex][ColumnIndex + 4].ToString())
                    , int.Parse(dt.Rows[RowIndex][ColumnIndex + 5].ToString()));
                if (s != 0)
                {
                    MessageBox.Show("Request is Accepted Successfully");
                }
            }
            
        }
    }
}
