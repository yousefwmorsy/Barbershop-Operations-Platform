﻿namespace Barbershop_Operations_Platform.User_Interface.ManageSupliesRequest
{
    partial class ManageSuppliesRequest
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
            this.ViewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ViewButton.Location = new System.Drawing.Point(12, 24);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(144, 107);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "View Supplies Requests";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(920, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AcceptButton.Location = new System.Drawing.Point(12, 137);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(144, 116);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept Selected Request";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeclineButton.Location = new System.Drawing.Point(12, 259);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(144, 100);
            this.DeclineButton.TabIndex = 0;
            this.DeclineButton.Text = "Decline Selected Request";
            this.DeclineButton.UseVisualStyleBackColor = true;
            // 
            // ManageSuppliesRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ViewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSuppliesRequest";
            this.Text = "ManageSuppliesRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button DeclineButton;
    }
}