namespace Barbershop_Operations_Platform
{
    partial class Signup
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
            this.Firstnamelabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.Birthdatelabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.ReEnterPassLabel = new System.Windows.Forms.Label();
            this.FNBox = new System.Windows.Forms.TextBox();
            this.LNBox = new System.Windows.Forms.TextBox();
            this.PHBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NPassBox = new System.Windows.Forms.TextBox();
            this.REENPassBox = new System.Windows.Forms.TextBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Firstnamelabel
            // 
            this.Firstnamelabel.AutoSize = true;
            this.Firstnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnamelabel.Location = new System.Drawing.Point(57, 53);
            this.Firstnamelabel.Name = "Firstnamelabel";
            this.Firstnamelabel.Size = new System.Drawing.Size(106, 25);
            this.Firstnamelabel.TabIndex = 0;
            this.Firstnamelabel.Text = "First Name";
            this.Firstnamelabel.Click += new System.EventHandler(this.Firstnamelabel_Click);
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.Location = new System.Drawing.Point(57, 130);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(95, 20);
            this.LastNamelabel.TabIndex = 0;
            this.LastNamelabel.Text = "Last Name";
            // 
            // Birthdatelabel
            // 
            this.Birthdatelabel.AutoSize = true;
            this.Birthdatelabel.Location = new System.Drawing.Point(558, 59);
            this.Birthdatelabel.Name = "Birthdatelabel";
            this.Birthdatelabel.Size = new System.Drawing.Size(74, 20);
            this.Birthdatelabel.TabIndex = 0;
            this.Birthdatelabel.Text = "Birthdate";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(558, 130);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(115, 20);
            this.PhoneNumLabel.TabIndex = 0;
            this.PhoneNumLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(558, 192);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(57, 198);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(125, 20);
            this.Passwordlabel.TabIndex = 0;
            this.Passwordlabel.Text = "New Password";
            // 
            // ReEnterPassLabel
            // 
            this.ReEnterPassLabel.AutoSize = true;
            this.ReEnterPassLabel.Location = new System.Drawing.Point(57, 267);
            this.ReEnterPassLabel.Name = "ReEnterPassLabel";
            this.ReEnterPassLabel.Size = new System.Drawing.Size(147, 20);
            this.ReEnterPassLabel.TabIndex = 0;
            this.ReEnterPassLabel.Text = "Re-Enter Password";
            // 
            // FNBox
            // 
            this.FNBox.Location = new System.Drawing.Point(224, 58);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(192, 26);
            this.FNBox.TabIndex = 1;
            // 
            // LNBox
            // 
            this.LNBox.Location = new System.Drawing.Point(224, 127);
            this.LNBox.Name = "LNBox";
            this.LNBox.Size = new System.Drawing.Size(192, 26);
            this.LNBox.TabIndex = 1;
            // 
            // PHBox
            // 
            this.PHBox.Location = new System.Drawing.Point(695, 124);
            this.PHBox.Name = "PHBox";
            this.PHBox.Size = new System.Drawing.Size(204, 26);
            this.PHBox.TabIndex = 1;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(695, 186);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(204, 26);
            this.EmailBox.TabIndex = 1;
            // 
            // NPassBox
            // 
            this.NPassBox.Location = new System.Drawing.Point(224, 195);
            this.NPassBox.Name = "NPassBox";
            this.NPassBox.PasswordChar = '*';
            this.NPassBox.Size = new System.Drawing.Size(192, 26);
            this.NPassBox.TabIndex = 1;
            // 
            // REENPassBox
            // 
            this.REENPassBox.Location = new System.Drawing.Point(224, 264);
            this.REENPassBox.Name = "REENPassBox";
            this.REENPassBox.PasswordChar = '*';
            this.REENPassBox.Size = new System.Drawing.Size(192, 26);
            this.REENPassBox.TabIndex = 1;
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(562, 237);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(337, 53);
            this.SignupButton.TabIndex = 2;
            this.SignupButton.Text = "Signup";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(695, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 341);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PHBox);
            this.Controls.Add(this.REENPassBox);
            this.Controls.Add(this.NPassBox);
            this.Controls.Add(this.LNBox);
            this.Controls.Add(this.FNBox);
            this.Controls.Add(this.ReEnterPassLabel);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumLabel);
            this.Controls.Add(this.Birthdatelabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.Firstnamelabel);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firstnamelabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label Birthdatelabel;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label ReEnterPassLabel;
        private System.Windows.Forms.TextBox FNBox;
        private System.Windows.Forms.TextBox LNBox;
        private System.Windows.Forms.TextBox PHBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NPassBox;
        private System.Windows.Forms.TextBox REENPassBox;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}