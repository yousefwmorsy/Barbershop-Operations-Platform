using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    public partial class ManageBarber : Form
    {
        int MID;
        MBarberController mBarberController = new MBarberController();
        public ManageBarber(int id)
        {
            InitializeComponent();
            MID = id;
            for (int i=8; i <= 23; i++)
            {
                HoursComboBox1.Items.Add(i.ToString("D2") + ":00");
                HoursComboBox2.Items.Add(i.ToString("D2") + ":00");
            }
        }

        private void FireBurberButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIDBox.Text))
            {
                MessageBox.Show("Deleted Employee's ID Can't be empty");
            }
            else
            {
                int v =  mBarberController.Delete(int.Parse(FIDBox.Text));
                if (v != 0)
                {
                    MessageBox.Show("Employee has deleted Successfully");
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewBarbersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mBarberController.ViewBarbers();
        }

        private void AddNewBarberButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FNameBox.Text)|| string.IsNullOrEmpty(LNameBox.Text) || string.IsNullOrEmpty(MID.ToString()) || string.IsNullOrEmpty(PNumberBox.Text) || string.IsNullOrEmpty(AddressBox.Text)
                || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text) || string.IsNullOrEmpty(HoursComboBox1.Text.ToString()) || string.IsNullOrEmpty(HoursComboBox2.Text.ToString()))
            {
                MessageBox.Show("Can't Insert a Barber\nOne or More Fields is Empty");
            }
            else
            {
                if (TimeSpan.Parse(HoursComboBox1.SelectedItem.ToString()) > TimeSpan.Parse(HoursComboBox2.SelectedItem.ToString()))
                {
                    MessageBox.Show("Can't Insert a Barber\nStarting time should be less than Ending time");
                }
                else
                {
                    int r = mBarberController.InsertBarber(FNameBox.Text, LNameBox.Text, MID, PNumberBox.Text, AddressBox.Text, EmailBox.Text, PasswordBox.Text, HoursComboBox1.Text, HoursComboBox2.Text);
                    if (r != 0)
                    {
                        MessageBox.Show("Employee has been added successfully");
                    }
                }
                
            }
            
        }

        private void ManageBarber_Load(object sender, EventArgs e)
        {

        }
    }
}
