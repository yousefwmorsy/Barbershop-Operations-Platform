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
    public partial class cust_info : Form
    {
        private Cust_controller control = new Cust_controller();
        private int ID;
        public cust_info(int id)
        {
            InitializeComponent();
            this.ID = id;

        }

        private void cust_info_Load(object sender, EventArgs e)
        {
            DataTable dt = control.Get_cust_info(ID);
            name.Text = dt.Rows[0]["fullname"].ToString();
            BDATE.Text = dt.Rows[0]["BDATE"].ToString();
            phone.Text = dt.Rows[0]["phone_number"].ToString();
            email.Text = dt.Rows[0]["Email"].ToString();
            if (dt.Rows[0]["points"].ToString() == "")
            {
                point.Text = "0";
            }
            else
            {
                point.Text = dt.Rows[0]["points"].ToString();
            }
            haircut.Text = dt.Rows[0]["haircut_details"].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
