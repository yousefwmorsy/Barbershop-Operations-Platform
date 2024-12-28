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
    public partial class CreatOffera : Form
    {
        ManagerClassController controller = new ManagerClassController();
        public CreatOffera()
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.GetServices();
            dataGridView2.DataSource = controller.GetOffers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string EDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int ID = int.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            if (DateTime.Parse(SDate) >= DateTime.Parse(EDate))
            {
                MessageBox.Show("Failed To Add Offer\nStart Date Can't be Grater than End Date");
            }
            else
            {
                controller.AddOffer(ID, SDate, EDate);
                dataGridView2.DataSource = controller.GetOffers();
                MessageBox.Show("Offer Has Added Successfully");
            }
        }
    }
}
