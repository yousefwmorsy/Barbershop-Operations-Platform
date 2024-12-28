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

namespace Barbershop_Operations_Platform.BarberUser
{
    public partial class BarberInfo : Form
    {
        BarberController controllerObject;
        int barberID;
        public BarberInfo(int barberid)
        {
            InitializeComponent();
            controllerObject = new BarberController();
            barberID = barberid;
            UpdateInfo();

            updateInfo_combo.DataSource = new string[] {"First Name", "Last Name", "Phone Number", "Address", "Email", "Password"};
        }
        
        public void UpdateInfo()
        {
            DataTable dt = controllerObject.GetPersonalInfo(barberID);
            if (dt == null)
            {
                return;
            }

            id_label.Text = dt.Rows[0]["Emp_id"].ToString();

            fname_label.Text = dt.Rows[0]["First_Name"].ToString();
            lname_label.Text = dt.Rows[0]["Last_Name"].ToString();

            phoneNumber_label.Text = dt.Rows[0]["Phone_Number"].ToString();

            if (string.IsNullOrEmpty(dt.Rows[0]["Address"].ToString()) == true)
            {
                address_label.Text = "No Address Entered";
            }
            else
            {
                address_label.Text = dt.Rows[0]["Address"].ToString();
            }

            email_label.Text = dt.Rows[0]["Email"].ToString();
            stime_label.Text = dt.Rows[0]["Start_Time"].ToString();
            etime_label.Text = dt.Rows[0]["End_Time"].ToString();
            managerName_label.Text = dt.Rows[0]["Manager_Name"].ToString();
        }

        private void BarberInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (updateInfo_combo.SelectedItem == null)
            {
                MessageBox.Show("Select a field to modify");
                return;
            }
            string selected = "";
            string text = update_text.Text.ToString();
            switch (updateInfo_combo.SelectedItem)
            {
                case "First Name":
                    selected = "First_name";
                    if (text.All(char.IsLetter) == false || text.Length == 0)
                    {
                        MessageBox.Show("Enter Valid Name");
                        return;
                    }
                    break;
                case "Last Name":
                    selected = "Last_name";
                    if (text.All(char.IsLetter) == false || text.Length == 0)
                    {
                        MessageBox.Show("Enter Valid Name");
                        return;
                    }
                    break;

                case "Phone Number":
                    selected = "Phone_number";
                    if (Regex.IsMatch(text, @"^01[0-9]{10}$") == false)
                    {
                        MessageBox.Show("Enter Valid Phone number (12 digits)");
                        return;
                    }
                    break;

                case "Email":
                    selected = "Email";
                    if (!Regex.IsMatch(text, @"^[a-zA-Z0-9_]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        MessageBox.Show("Enter Valid Email");
                        return;
                    }
                    break;
                case "Address":
                    selected = "Address";
                    string pattern = @"[^a-zA-Z0-9\s,.@_-]";
                    if (Regex.IsMatch(text, pattern))
                    {
                        MessageBox.Show("Donot Enter Special Characters");
                        return;
                    }
                    break;

                case "Password":
                    selected = "Password";
                    string passwordPattern = @"[^a-zA-Z0-9!@#$%^&*]";
                    if (text.Length < 8)
                    {
                        MessageBox.Show("Password Length Must be Longer than 8 chars");
                        return;
                    }
                    if (retypePassword_text.Text.ToString() != text)
                    {
                        MessageBox.Show("Password Mismatch");
                        return;
                    }
                    if (Regex.IsMatch(text, passwordPattern))
                    {
                        MessageBox.Show("Donot Enter Special Characters");
                        return;
                    }
                    break;
                default:
                    return;
            }

            int x = controllerObject.UpdatePersonalInfo(selected, text, barberID);
            if (x > 0)
            {
                UpdateInfo();
                MessageBox.Show("Updated Sucessfuly");
            }
            else
            {
                MessageBox.Show("Couldn't Update");
            }
        }

        private void updateInfo_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateInfo_combo.SelectedValue.ToString() == "Password")
            {
                retypePassword_label.Visible = true;
                retypePassword_text.Visible = true;
            }
            else
            {
                retypePassword_label.Visible = false;
                retypePassword_text.Visible = false;
            }
        }
    }
}
