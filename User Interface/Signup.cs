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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy/MM/dd"); // converting to time 
            MessageBox.Show(date);
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
