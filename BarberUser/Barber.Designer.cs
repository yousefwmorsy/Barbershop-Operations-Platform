namespace Barbershop_Operations_Platform
{
    partial class Barber
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
            this.schedule_button = new System.Windows.Forms.Button();
            this.requestDaysOff_button = new System.Windows.Forms.Button();
            this.attendence_button = new System.Windows.Forms.Button();
            this.reqSupplies_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.incident_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // schedule_button
            // 
            this.schedule_button.Location = new System.Drawing.Point(12, 84);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(112, 67);
            this.schedule_button.TabIndex = 0;
            this.schedule_button.Text = "View Schedule";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // requestDaysOff_button
            // 
            this.requestDaysOff_button.Location = new System.Drawing.Point(12, 154);
            this.requestDaysOff_button.Name = "requestDaysOff_button";
            this.requestDaysOff_button.Size = new System.Drawing.Size(112, 66);
            this.requestDaysOff_button.TabIndex = 1;
            this.requestDaysOff_button.Text = "Request Days off";
            this.requestDaysOff_button.UseVisualStyleBackColor = true;
            this.requestDaysOff_button.Click += new System.EventHandler(this.requestDaysOff_button_Click);
            // 
            // attendence_button
            // 
            this.attendence_button.Location = new System.Drawing.Point(12, 299);
            this.attendence_button.Name = "attendence_button";
            this.attendence_button.Size = new System.Drawing.Size(112, 66);
            this.attendence_button.TabIndex = 3;
            this.attendence_button.Text = "Log Attendence";
            this.attendence_button.UseVisualStyleBackColor = true;
            this.attendence_button.Click += new System.EventHandler(this.attendence_button_Click);
            // 
            // reqSupplies_button
            // 
            this.reqSupplies_button.Location = new System.Drawing.Point(12, 226);
            this.reqSupplies_button.Name = "reqSupplies_button";
            this.reqSupplies_button.Size = new System.Drawing.Size(112, 67);
            this.reqSupplies_button.TabIndex = 2;
            this.reqSupplies_button.Text = "Request Supplies";
            this.reqSupplies_button.UseVisualStyleBackColor = true;
            this.reqSupplies_button.Click += new System.EventHandler(this.reqSupplies_button_Click);
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(12, 12);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(112, 66);
            this.info_button.TabIndex = 5;
            this.info_button.Text = "Personal Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // incident_button
            // 
            this.incident_button.Location = new System.Drawing.Point(12, 371);
            this.incident_button.Name = "incident_button";
            this.incident_button.Size = new System.Drawing.Size(112, 67);
            this.incident_button.TabIndex = 4;
            this.incident_button.Text = "Submit Incident Report";
            this.incident_button.UseVisualStyleBackColor = true;
            this.incident_button.Click += new System.EventHandler(this.incident_button_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 426);
            this.panel1.TabIndex = 6;
            // 
            // Barber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.incident_button);
            this.Controls.Add(this.attendence_button);
            this.Controls.Add(this.reqSupplies_button);
            this.Controls.Add(this.requestDaysOff_button);
            this.Controls.Add(this.schedule_button);
            this.Name = "Barber";
            this.Text = "Barber";
            this.Load += new System.EventHandler(this.Barber_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.Button requestDaysOff_button;
        private System.Windows.Forms.Button attendence_button;
        private System.Windows.Forms.Button reqSupplies_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button incident_button;
        private System.Windows.Forms.Panel panel1;
    }
}