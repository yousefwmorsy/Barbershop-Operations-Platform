using Barbershop_Operations_Platform.Receptionist;
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
            info.Dock = DockStyle.Fill;
            info.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(info);
            info.Show();
            //info_button.Enabled = false;
            //history.Enabled = true;
            //update.Enabled = true;
            //reserve.Enabled = true;
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                control.Enabled = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            Update_cust_data update = new Update_cust_data(ID);
            update.Dock = DockStyle.Fill;
            update.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(update);
            update.Show();
            //info_button.Enabled = true;
            //history.Enabled = true;
            //update.Enabled = false;
            //reserve.Enabled = false;
            //this.Hide();
            //update.ShowDialog();
            //this.Show();
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                control.Enabled = true;
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            history history = new history(ID);
            //this.Hide();
            //history.ShowDialog();
            //this.Show();
            history.Dock = DockStyle.Fill;
            history.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(history);
            history.Show();
            //info_button.Enabled = true;
            //history.Enabled = false;
            //update.Enabled = true;
            //reserve.Enabled = true;
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                control.Enabled = true;
            }
        }
        
        private void reserve_Click(object sender, EventArgs e)
        {
            reserve_appointment reserve = new reserve_appointment(ID);
            reserve.Dock = DockStyle.Fill;
            reserve.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(reserve);
            reserve.Show();
            //info_button.Enabled = true;
            //history.Enabled = true;
            //update.Enabled = true;
            //reserve.Enabled = false;
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                control.Enabled = true;
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
