namespace Barbershop_Operations_Platform
{
    partial class Customer
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
            this.info_button = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.info_button.Location = new System.Drawing.Point(13, 137);
            this.info_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(427, 134);
            this.info_button.TabIndex = 0;
            this.info_button.Text = "view information";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.update.Location = new System.Drawing.Point(13, 279);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(427, 142);
            this.update.TabIndex = 1;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // reserve
            // 
            this.reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.reserve.Location = new System.Drawing.Point(13, 429);
            this.reserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(427, 146);
            this.reserve.TabIndex = 2;
            this.reserve.Text = "reserve apppointment";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(13, 583);
            this.history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(427, 134);
            this.history.TabIndex = 3;
            this.history.Text = "history";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.history);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.reserve);
            this.splitContainer1.Panel1.Controls.Add(this.info_button);
            this.splitContainer1.Panel1.Controls.Add(this.update);
            this.splitContainer1.Size = new System.Drawing.Size(1603, 866);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(13, 763);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 866);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}