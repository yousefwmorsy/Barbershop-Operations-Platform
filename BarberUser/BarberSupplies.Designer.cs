namespace Barbershop_Operations_Platform.BarberUser
{
    partial class BarberSupplies
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
            this.availableSupplies_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.availablesupplies_label = new System.Windows.Forms.Label();
            this.supply_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberValidation_label = new System.Windows.Forms.Label();
            this.sendRequest_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.supplyRequests_datagrid = new System.Windows.Forms.DataGridView();
            this.supplyRequests_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableSupplies_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRequests_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // availableSupplies_datagrid
            // 
            this.availableSupplies_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableSupplies_datagrid.Location = new System.Drawing.Point(158, 40);
            this.availableSupplies_datagrid.Name = "availableSupplies_datagrid";
            this.availableSupplies_datagrid.Size = new System.Drawing.Size(536, 118);
            this.availableSupplies_datagrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Supplies";
            // 
            // availablesupplies_label
            // 
            this.availablesupplies_label.AutoSize = true;
            this.availablesupplies_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablesupplies_label.ForeColor = System.Drawing.Color.Red;
            this.availablesupplies_label.Location = new System.Drawing.Point(301, 64);
            this.availablesupplies_label.Name = "availablesupplies_label";
            this.availablesupplies_label.Size = new System.Drawing.Size(161, 20);
            this.availablesupplies_label.TabIndex = 2;
            this.availablesupplies_label.Text = "No Available Supplies";
            this.availablesupplies_label.Visible = false;
            // 
            // supply_combo
            // 
            this.supply_combo.FormattingEnabled = true;
            this.supply_combo.Location = new System.Drawing.Point(140, 339);
            this.supply_combo.Name = "supply_combo";
            this.supply_combo.Size = new System.Drawing.Size(121, 21);
            this.supply_combo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Request Supply";
            // 
            // quantity_text
            // 
            this.quantity_text.Location = new System.Drawing.Point(398, 340);
            this.quantity_text.Name = "quantity_text";
            this.quantity_text.Size = new System.Drawing.Size(138, 20);
            this.quantity_text.TabIndex = 5;
            this.quantity_text.TextChanged += new System.EventHandler(this.quantity_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // numberValidation_label
            // 
            this.numberValidation_label.AutoSize = true;
            this.numberValidation_label.ForeColor = System.Drawing.Color.Red;
            this.numberValidation_label.Location = new System.Drawing.Point(557, 343);
            this.numberValidation_label.Name = "numberValidation_label";
            this.numberValidation_label.Size = new System.Drawing.Size(137, 13);
            this.numberValidation_label.TabIndex = 7;
            this.numberValidation_label.Text = "Enter Positive Integers Only";
            this.numberValidation_label.Visible = false;
            // 
            // sendRequest_button
            // 
            this.sendRequest_button.Location = new System.Drawing.Point(290, 379);
            this.sendRequest_button.Name = "sendRequest_button";
            this.sendRequest_button.Size = new System.Drawing.Size(172, 42);
            this.sendRequest_button.TabIndex = 8;
            this.sendRequest_button.Text = "Send Or Update Request";
            this.sendRequest_button.UseVisualStyleBackColor = true;
            this.sendRequest_button.Click += new System.EventHandler(this.sendRequest_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Supply Requests";
            // 
            // supplyRequests_datagrid
            // 
            this.supplyRequests_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyRequests_datagrid.Location = new System.Drawing.Point(158, 164);
            this.supplyRequests_datagrid.Name = "supplyRequests_datagrid";
            this.supplyRequests_datagrid.Size = new System.Drawing.Size(536, 118);
            this.supplyRequests_datagrid.TabIndex = 9;
            // 
            // supplyRequests_label
            // 
            this.supplyRequests_label.AutoSize = true;
            this.supplyRequests_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyRequests_label.ForeColor = System.Drawing.Color.Red;
            this.supplyRequests_label.Location = new System.Drawing.Point(301, 181);
            this.supplyRequests_label.Name = "supplyRequests_label";
            this.supplyRequests_label.Size = new System.Drawing.Size(221, 20);
            this.supplyRequests_label.TabIndex = 11;
            this.supplyRequests_label.Text = "No Available Supply Requests";
            this.supplyRequests_label.Visible = false;
            // 
            // BarberSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supplyRequests_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplyRequests_datagrid);
            this.Controls.Add(this.sendRequest_button);
            this.Controls.Add(this.numberValidation_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supply_combo);
            this.Controls.Add(this.availablesupplies_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availableSupplies_datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarberSupplies";
            this.Text = "BarberSupplies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarberSupplies_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.availableSupplies_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyRequests_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availableSupplies_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availablesupplies_label;
        private System.Windows.Forms.ComboBox supply_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberValidation_label;
        private System.Windows.Forms.Button sendRequest_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView supplyRequests_datagrid;
        private System.Windows.Forms.Label supplyRequests_label;
    }
}