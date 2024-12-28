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
            this.SuspendLayout();
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(30, 36);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(156, 46);
            this.info_button.TabIndex = 0;
            this.info_button.Text = "view information";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(33, 132);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(139, 45);
            this.update.TabIndex = 1;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(33, 241);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(189, 43);
            this.reserve.TabIndex = 2;
            this.reserve.Text = "reserve apppointment";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(33, 339);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(189, 43);
            this.history.TabIndex = 3;
            this.history.Text = "history";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.history);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.update);
            this.Controls.Add(this.info_button);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Button history;
    }
}