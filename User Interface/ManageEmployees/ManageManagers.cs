using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    public partial class ManageManagers : Form
    {
        MManagerController managerController = new MManagerController();
        int MID;
        public ManageManagers(int id)
        {
            InitializeComponent();
            MID = id;
        }

        private void AddNewManagerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text) || string.IsNullOrEmpty(LNameBox.Text) || string.IsNullOrEmpty(MID.ToString()) || string.IsNullOrEmpty(PNumberBox.Text) || string.IsNullOrEmpty(AddressBox.Text)
                || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Can't Insert a Barber\nOne or More Fields is Empty");
            }
            else
            {
                if (!(LNameBox.Text.All(char.IsLetter) && LNameBox.Text.All(char.IsLetter)))
                {
                    MessageBox.Show("Names must contain only letters.");
                    return;
                }
                if (!Regex.IsMatch(EmailBox.Text, @"^[a-zA-Z0-9_]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Enter Valid Email");
                    return;
                }
                if (!(REPasswordBox.Text.All(char.IsLetter) && LNameBox.Text.All(char.IsLetter)))
                {
                    MessageBox.Show("Password must contain only letters.");
                    return;
                }
                if (!(PasswordBox.Text.All(char.IsLetter) && LNameBox.Text.All(char.IsLetter)))
                {
                    MessageBox.Show("Re-Password must contain only letters.");
                    return;
                }
                if (PasswordBox.Text != REPasswordBox.Text)
                {
                    MessageBox.Show("Password Doesn't Match");
                    return;
                }


                int r = managerController.InsertManager(FNameBox.Text, LNameBox.Text, MID, PNumberBox.Text, AddressBox.Text, EmailBox.Text, PasswordBox.Text);
                if (r != 0)
                {
                    MessageBox.Show("Employee has been added successfully");
                }
            }
        }

        private void ViewManagerButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = managerController.ViewManagers();
        }

        private void FireManagerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIDBox.Text))
            {
                MessageBox.Show("Deleted Employee's ID Can't be empty");
            }
            else
            {

                int v = managerController.Delete(int.Parse(FIDBox.Text));
                if (v != 0)
                {
                    MessageBox.Show("Employee has deleted Successfully");
                }
            }
        }
    }
}
