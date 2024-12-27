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
    public partial class BarberSupplies : Form
    {
        BarberController controllerObject;
        int barberId;
        public BarberSupplies(int barber_id)
        {
            InitializeComponent();
            controllerObject = new BarberController();
            barberId = barber_id;

            DataTable dt = controllerObject.GetAvailableSupplies();
            if (dt != null)
            {
                DataTable filteredDt = dt.DefaultView.ToTable(false, "supply_Name", "Quantity");

                availableSupplies_datagrid.DataSource = filteredDt;
                supply_combo.DataSource = dt;
                supply_combo.DisplayMember = "supply_Name";
                supply_combo.ValueMember = "supplyID";
            }
            else
            {
                availableSupplies_datagrid.Visible = false;
                availablesupplies_label.Visible = true;
                supply_combo.Enabled = false;
                
            }
            
            dt = controllerObject.GetSupplyRequests(barberId);
            if (dt != null)
            {
                supplyRequests_datagrid.DataSource = dt;
            }
            else
            {
                supplyRequests_datagrid.Visible = false;
                supplyRequests_label.Visible = true;
            }
        }

        private void BarberSupplies_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObject.TerminateConnection();
        }

        private void quantity_text_TextChanged(object sender, EventArgs e)
        {
            if (quantity_text.Text.Length == 0)
            {
                numberValidation_label.Visible = false;
                sendRequest_button.Enabled = false;
                return; 
            }

            if (int.TryParse(quantity_text.Text, out int parsedNumber) && parsedNumber > 0)
            {
                numberValidation_label.Visible = false;
                sendRequest_button.Enabled = true;
            }
            else
            {
                numberValidation_label.Visible= true;
                sendRequest_button.Enabled= false;
            }

        }

        private void sendRequest_button_Click(object sender, EventArgs e)
        {
            if (supply_combo.SelectedItem == null)
            {
                MessageBox.Show("Select Supply");
                return;
            }
            if (quantity_text.Text.Length == 0)
            {
                MessageBox.Show("Insert Quantity");
                return;
            }
            int supplyid = int.Parse(supply_combo.SelectedValue.ToString());
            int quantity = int.Parse(quantity_text.Text);

            if (controllerObject.CheckSupplyRequestExistance(barberId, supplyid) > 0) 
            {
                int x = controllerObject.UpdateSupplyRequest(barberId, supplyid, quantity);
                if (x > 0) 
                {
                    MessageBox.Show("Updated Sucessfuly");
                }
                else
                {
                    MessageBox.Show("Can't Update Finished Request");
                }
            }
            else
            {
                int x = controllerObject.InsertSupplyRequest(barberId,supplyid, quantity);
                if (x > 0)
                {
                    MessageBox.Show("Inserted Sucessfuly");
                }
                else
                {
                    MessageBox.Show("Couldn't Insert");
                }
            }


            supplyRequests_datagrid.DataSource = controllerObject.GetSupplyRequests(barberId);
        }
    }
}
