using Barbershop_Operations_Platform.User_Interface.ManageEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManagersTools
{
    public partial class EditPersonalInfo : Form
    {
        ManagerClassController controller = new ManagerClassController();
        int MID;
        public EditPersonalInfo(int ID)
        {
            InitializeComponent();
            DataTable DT = controller.GetPersonalInformation(ID);
            MID = ID;
            FNameBox.Text = DT.Rows[0][0].ToString();
            LNameBox.Text = DT.Rows[0][1].ToString();
            PhoneNumBox.Text = DT.Rows[0][2].ToString();
            AddressBox.Text = DT.Rows[0][3].ToString();
            EmailBox.Text = DT.Rows[0][4].ToString();
        }

        private void EditPersonalInfo_Load(object sender, EventArgs e)
        {
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text) || string.IsNullOrEmpty(LNameBox.Text) || string.IsNullOrEmpty(MID.ToString()) || string.IsNullOrEmpty(PhoneNumBox.Text) || string.IsNullOrEmpty(AddressBox.Text)
                || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(RePassword.Text))
            {
                MessageBox.Show("Can't Update\nOne or More Fields is Empty");
            }
            else
            {
                if (!FNameBox.Text.All(char.IsLetter))
                {
                    MessageBox.Show("First Name is not valid");
                    return;
                }
                if (!LNameBox.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Last Name is not valid");
                    return;
                }
                if (PasswordBox.Text.ToString() != RePassword.Text.ToString())
                {
                    MessageBox.Show("Password Is not Matched");
                    return;
                }


                int r = controller.EditPersonalInfo(MID ,FNameBox.Text, LNameBox.Text, PhoneNumBox.Text, AddressBox.Text, EmailBox.Text, Password.Text);
                if (r != 0)
                {
                    MessageBox.Show("Employee has been added successfully");
                }
            }
        }
    }
}
