using Barbershop_Operations_Platform.User_Interface;
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
    public partial class Customer : Form
    {
        private int ID;
        private Cust_controller controller = new Cust_controller();
        public Customer(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            cust_info info = new cust_info(ID);
            info.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Update_cust_data update = new Update_cust_data(ID);
            update.ShowDialog();
        }

        private void history_Click(object sender, EventArgs e)
        {
            history history = new history(ID);
            history.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            reserve_appointment reserve = new reserve_appointment(5);
            reserve.ShowDialog();

        }
    }
}
