using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Barbershop_Operations_Platform.User_Interface
{
    public partial class history : Form
    {
        private int ID;
        private Cust_controller controller = new Cust_controller();
        public history(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void history_Load(object sender, EventArgs e)
        {
            DataTable dt = controller.Get_cust_history(ID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();


            //comboBox1.DataSource = control.ShowEmailCombo();
            //comboBox1.DisplayMember = "";
            //comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
