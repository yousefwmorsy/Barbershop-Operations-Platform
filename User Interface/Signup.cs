﻿using Barbershop_Operations_Platform.User_Interface;
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
using static System.Net.Mime.MediaTypeNames;

namespace Barbershop_Operations_Platform
{
    public partial class Signup : Form
    {
        Cust_controller controller = new Cust_controller();
        public Signup()
        {
            InitializeComponent();
            
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            //string date = dateTimePicker1.Value.ToString("yyyy/MM/dd"); // converting to time 
            //MessageBox.Show(date);
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            int trashcan = 0;
            string pattern = @"[^a-zA-Z0-9\s,.-@]";
            if (!EmailBox.Text.Contains('@') && string.IsNullOrWhiteSpace(EmailBox.Text) && Regex.IsMatch(EmailBox.Text, pattern))
            {
                MessageBox.Show("enter a valid email name");
            }
            else if (NPassBox.Text != REENPassBox.Text && string.IsNullOrWhiteSpace(NPassBox.Text))
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (Int32.TryParse(FNBox.Text, out trashcan) && string.IsNullOrWhiteSpace(FNBox.Text) && Regex.IsMatch(FNBox.Text, pattern))
            {
                MessageBox.Show("enter a valid first name");
            }
            else if (Int32.TryParse(LNBox.Text, out trashcan) && string.IsNullOrWhiteSpace(LNBox.Text) && Regex.IsMatch(LNBox.Text, pattern))
            {
                MessageBox.Show("enter a valid last name");
            }
            else if (!Int32.TryParse(PHBox.Text, out trashcan) && PHBox.Text.Length != 11)
            {
                MessageBox.Show("enter a valid phone name");
            }
            else
            {
                if (controller.add_customer(FNBox.Text, LNBox.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), PHBox.Text, EmailBox.Text, NPassBox.Text) != 0)
                {
                    MessageBox.Show("Account created successfully");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
            //Customer customer = new Customer(5);
            //customer.ShowDialog();

        }

        private void Firstnamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
