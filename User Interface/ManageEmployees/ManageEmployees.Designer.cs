namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    partial class ManageEmployees
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
            this.ManageBarbersButton = new System.Windows.Forms.Button();
            this.ManageReceptionistsButton = new System.Windows.Forms.Button();
            this.ManageDaysOffButton = new System.Windows.Forms.Button();
            this.ManageManagers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ManageBarbersButton
            // 
            this.ManageBarbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageBarbersButton.Location = new System.Drawing.Point(12, 213);
            this.ManageBarbersButton.Name = "ManageBarbersButton";
            this.ManageBarbersButton.Size = new System.Drawing.Size(277, 74);
            this.ManageBarbersButton.TabIndex = 0;
            this.ManageBarbersButton.Text = "Manage Barbers";
            this.ManageBarbersButton.UseVisualStyleBackColor = true;
            this.ManageBarbersButton.Click += new System.EventHandler(this.ManageBarbersButton_Click);
            // 
            // ManageReceptionistsButton
            // 
            this.ManageReceptionistsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageReceptionistsButton.Location = new System.Drawing.Point(12, 317);
            this.ManageReceptionistsButton.Name = "ManageReceptionistsButton";
            this.ManageReceptionistsButton.Size = new System.Drawing.Size(277, 74);
            this.ManageReceptionistsButton.TabIndex = 0;
            this.ManageReceptionistsButton.Text = "Manage Receptionists";
            this.ManageReceptionistsButton.UseVisualStyleBackColor = true;
            this.ManageReceptionistsButton.Click += new System.EventHandler(this.ManageReceptionistsButton_Click);
            // 
            // ManageDaysOffButton
            // 
            this.ManageDaysOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageDaysOffButton.Location = new System.Drawing.Point(12, 422);
            this.ManageDaysOffButton.Name = "ManageDaysOffButton";
            this.ManageDaysOffButton.Size = new System.Drawing.Size(277, 74);
            this.ManageDaysOffButton.TabIndex = 0;
            this.ManageDaysOffButton.Text = "Manage Days-Off";
            this.ManageDaysOffButton.UseVisualStyleBackColor = true;
            this.ManageDaysOffButton.Click += new System.EventHandler(this.ManageDaysOffButton_Click);
            // 
            // ManageManagers
            // 
            this.ManageManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageManagers.Location = new System.Drawing.Point(12, 528);
            this.ManageManagers.Name = "ManageManagers";
            this.ManageManagers.Size = new System.Drawing.Size(277, 74);
            this.ManageManagers.TabIndex = 0;
            this.ManageManagers.Text = "Manage Managers";
            this.ManageManagers.UseVisualStyleBackColor = true;
            this.ManageManagers.Click += new System.EventHandler(this.ManageManagers_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(295, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 875);
            this.panel1.TabIndex = 1;
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 899);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManageManagers);
            this.Controls.Add(this.ManageDaysOffButton);
            this.Controls.Add(this.ManageReceptionistsButton);
            this.Controls.Add(this.ManageBarbersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageBarbersButton;
        private System.Windows.Forms.Button ManageReceptionistsButton;
        private System.Windows.Forms.Button ManageDaysOffButton;
        private System.Windows.Forms.Button ManageManagers;
        private System.Windows.Forms.Panel panel1;
    }
}