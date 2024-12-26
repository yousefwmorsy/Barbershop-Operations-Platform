using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            updateInfo_combo.DataSource = new string[] {"First Name", "Last Name", "Phone number", "Address", "Email", "Start_Time", "End_Time"};
            for (int i = 0; i < 24; i++)
            {
                hours_combo.Items.Add(i.ToString("D2") + ":00");
            }
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

        private void updateInfo_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (updateInfo_combo.SelectedItem)
            {
                case "Start_Time":
                    update_text.Visible = false;
                    hours_combo.Visible = true;
                    break;
                case "End_Time":
                    update_text.Visible = false;
                    hours_combo.Visible = true;
                    break;

                default:
                    hours_combo.Visible = false;
                    update_text.Visible = true;
                    update_text.Text = string.Empty;
                    break;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (updateInfo_combo.SelectedItem == null)
            {
                MessageBox.Show("Select a field to modify");
                return;
            }
            if (updateInfo_combo.SelectedItem.ToString() == "Start_Time" || updateInfo_combo.SelectedItem.ToString() == "End_Time")
            {
                controllerObject.UpdateStartOrEndTime(updateInfo_combo.SelectedItem.ToString(), hours_combo.Text.ToString(), barberID);
            }    

            UpdateInfo();
        }
    }
}
