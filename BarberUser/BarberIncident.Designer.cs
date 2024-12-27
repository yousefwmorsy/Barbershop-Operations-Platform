namespace Barbershop_Operations_Platform.BarberUser
{
    partial class BarberIncident
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incident_button = new System.Windows.Forms.Button();
            this.incident_text = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emptyDataGrid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // incident_button
            // 
            this.incident_button.Location = new System.Drawing.Point(601, 67);
            this.incident_button.Name = "incident_button";
            this.incident_button.Size = new System.Drawing.Size(128, 55);
            this.incident_button.TabIndex = 1;
            this.incident_button.Text = "Send Incident Report";
            this.incident_button.UseVisualStyleBackColor = true;
            this.incident_button.Click += new System.EventHandler(this.incident_button_Click);
            // 
            // incident_text
            // 
            this.incident_text.Location = new System.Drawing.Point(143, 85);
            this.incident_text.Name = "incident_text";
            this.incident_text.Size = new System.Drawing.Size(372, 20);
            this.incident_text.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // emptyDataGrid_label
            // 
            this.emptyDataGrid_label.AutoSize = true;
            this.emptyDataGrid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyDataGrid_label.ForeColor = System.Drawing.Color.Red;
            this.emptyDataGrid_label.Location = new System.Drawing.Point(221, 124);
            this.emptyDataGrid_label.Name = "emptyDataGrid_label";
            this.emptyDataGrid_label.Size = new System.Drawing.Size(207, 24);
            this.emptyDataGrid_label.TabIndex = 5;
            this.emptyDataGrid_label.Text = "No Appointments Done";
            this.emptyDataGrid_label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Appointment";
            // 
            // BarberIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emptyDataGrid_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.incident_text);
            this.Controls.Add(this.incident_button);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarberIncident";
            this.Text = "BarberIncident";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarberIncident_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button incident_button;
        private System.Windows.Forms.TextBox incident_text;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label emptyDataGrid_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}