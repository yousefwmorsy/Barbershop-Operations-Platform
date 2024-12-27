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
    public partial class ViewBarber_sHistrory : Form
    {
        ManagerClassController controller = new ManagerClassController();
        public ViewBarber_sHistrory()
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.GetBarbers();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = int.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            dataGridView2.DataSource = controller.GetBarberHistory(id);
        }
    }
}
