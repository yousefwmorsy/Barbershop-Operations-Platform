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
    public partial class Login_Form : Form
    {
        LoginController loginController = new LoginController();
        public Login_Form()
        {
            InitializeComponent();
            label3.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form F = new Signup();
            this.Hide();
            F.ShowDialog();
            this.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int u = loginController.GetSignedUser(Usernamebox.Text, PasswoedBox.Text);
            switch (u){
                case 0:
                    Form FC = new Customer(loginController.GetUserID(Usernamebox.Text));
                    this.Hide();
                    FC.ShowDialog();
                    this.Show();
                    break;
                case 1:
                    Form FB = new Barber(loginController.GetEmployeeID(Usernamebox.Text));
                    this.Hide();
                    FB.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    Form FR = new Receptionest(loginController.GetEmployeeID(Usernamebox.Text));
                    this.Hide();
                    FR.ShowDialog();
                    this.Show();
                    break;
                case 3:
                    Form FM = new Manager(false, loginController.GetEmployeeID(Usernamebox.Text));
                    this.Hide();
                    FM.ShowDialog();
                    this.Show();
                    break;
                case 4:
                    Form FSM = new Manager(true, loginController.GetEmployeeID(Usernamebox.Text));
                    this.Hide();
                    FSM.ShowDialog();
                    this.Show();
                    break;
                default:
                    label3.Show();
                    break;
            }
        }

        private void Usernamebox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
