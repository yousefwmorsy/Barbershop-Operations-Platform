namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    partial class ManageBarber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewBarbersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FireBurberButton = new System.Windows.Forms.Button();
            this.AddNewBarberButton = new System.Windows.Forms.Button();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HoursComboBox1 = new System.Windows.Forms.ComboBox();
            this.HoursComboBox2 = new System.Windows.Forms.ComboBox();
            this.REPasswordBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewBarbersButton
            // 
            this.ViewBarbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBarbersButton.Location = new System.Drawing.Point(21, 26);
            this.ViewBarbersButton.Name = "ViewBarbersButton";
            this.ViewBarbersButton.Size = new System.Drawing.Size(647, 48);
            this.ViewBarbersButton.TabIndex = 0;
            this.ViewBarbersButton.Text = "View Barbers";
            this.ViewBarbersButton.UseVisualStyleBackColor = true;
            this.ViewBarbersButton.Click += new System.EventHandler(this.ViewBarbersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(647, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // FireBurberButton
            // 
            this.FireBurberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireBurberButton.Location = new System.Drawing.Point(347, 741);
            this.FireBurberButton.Name = "FireBurberButton";
            this.FireBurberButton.Size = new System.Drawing.Size(127, 48);
            this.FireBurberButton.TabIndex = 0;
            this.FireBurberButton.Text = "Fire Barber";
            this.FireBurberButton.UseVisualStyleBackColor = true;
            this.FireBurberButton.Click += new System.EventHandler(this.FireBurberButton_Click);
            // 
            // AddNewBarberButton
            // 
            this.AddNewBarberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBarberButton.Location = new System.Drawing.Point(21, 416);
            this.AddNewBarberButton.Name = "AddNewBarberButton";
            this.AddNewBarberButton.Size = new System.Drawing.Size(647, 48);
            this.AddNewBarberButton.TabIndex = 0;
            this.AddNewBarberButton.Text = "Add New Barber";
            this.AddNewBarberButton.UseVisualStyleBackColor = true;
            this.AddNewBarberButton.Click += new System.EventHandler(this.AddNewBarberButton_Click);
            // 
            // FNameBox
            // 
            this.FNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameBox.Location = new System.Drawing.Point(173, 508);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(158, 30);
            this.FNameBox.TabIndex = 2;
            this.FNameBox.TextChanged += new System.EventHandler(this.FNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // LNameBox
            // 
            this.LNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameBox.Location = new System.Drawing.Point(510, 499);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(158, 30);
            this.LNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // PNumberBox
            // 
            this.PNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNumberBox.Location = new System.Drawing.Point(173, 577);
            this.PNumberBox.Name = "PNumberBox";
            this.PNumberBox.Size = new System.Drawing.Size(158, 30);
            this.PNumberBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Numer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.Location = new System.Drawing.Point(510, 568);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(158, 30);
            this.AddressBox.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(358, 577);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(85, 25);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(173, 639);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(158, 30);
            this.EmailBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(510, 630);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(158, 30);
            this.PasswordBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // FIDBox
            // 
            this.FIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIDBox.Location = new System.Drawing.Point(510, 747);
            this.FIDBox.Name = "FIDBox";
            this.FIDBox.Size = new System.Drawing.Size(158, 30);
            this.FIDBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sart Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 747);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "End Time";
            // 
            // HoursComboBox1
            // 
            this.HoursComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursComboBox1.FormattingEnabled = true;
            this.HoursComboBox1.Location = new System.Drawing.Point(173, 693);
            this.HoursComboBox1.Name = "HoursComboBox1";
            this.HoursComboBox1.Size = new System.Drawing.Size(157, 33);
            this.HoursComboBox1.TabIndex = 5;
            // 
            // HoursComboBox2
            // 
            this.HoursComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursComboBox2.FormattingEnabled = true;
            this.HoursComboBox2.Location = new System.Drawing.Point(173, 747);
            this.HoursComboBox2.Name = "HoursComboBox2";
            this.HoursComboBox2.Size = new System.Drawing.Size(157, 33);
            this.HoursComboBox2.TabIndex = 5;
            // 
            // REPasswordBox
            // 
            this.REPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPasswordBox.Location = new System.Drawing.Point(510, 687);
            this.REPasswordBox.Name = "REPasswordBox";
            this.REPasswordBox.Size = new System.Drawing.Size(158, 30);
            this.REPasswordBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 696);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Re-Password";
            // 
            // ManageBarber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 838);
            this.Controls.Add(this.HoursComboBox2);
            this.Controls.Add(this.HoursComboBox1);
            this.Controls.Add(this.FIDBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.REPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddNewBarberButton);
            this.Controls.Add(this.FireBurberButton);
            this.Controls.Add(this.ViewBarbersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBarber";
            this.Text = "ManageBarber";
            this.Load += new System.EventHandler(this.ManageBarber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewBarbersButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button FireBurberButton;
        private System.Windows.Forms.Button AddNewBarberButton;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FIDBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox HoursComboBox1;
        private System.Windows.Forms.ComboBox HoursComboBox2;
        private System.Windows.Forms.TextBox REPasswordBox;
        private System.Windows.Forms.Label label8;
    }
}