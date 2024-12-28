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
    public partial class ManageDaysOff : Form
    {
        DaysOffController daysOff = new DaysOffController();
        public ManageDaysOff()
        {
            InitializeComponent();
        }

        private void ManageDaysOff_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daysOff.ViewDaysOff();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            int ColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (ColumnIndex != 0)
            {
                MessageBox.Show("Invalid Request's ID");
            }
            else
            {
                daysOff.DeclineRequest((int)dataGridView1.CurrentCell.Value);
                dataGridView1.DataSource = daysOff.ViewDaysOff();

            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int ColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (ColumnIndex != 0)
            {
                MessageBox.Show("Invalid Request's ID");
            }
            else
            {
                daysOff.AcceptRequest((int)dataGridView1.Rows[RowIndex].Cells[ColumnIndex].Value, (int)dataGridView1.Rows[RowIndex].Cells[ColumnIndex + 1].Value);
                dataGridView1.DataSource = daysOff.ViewDaysOff();

            }

        }
    }
}
