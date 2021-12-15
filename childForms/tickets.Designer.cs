
namespace Concert_ticket_booking_system_final.childForms
{
    partial class tickets
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
            this.customerDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDgv
            // 
            this.customerDgv.AllowUserToAddRows = false;
            this.customerDgv.AllowUserToDeleteRows = false;
            this.customerDgv.BackgroundColor = System.Drawing.Color.White;
            this.customerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgv.Location = new System.Drawing.Point(128, 60);
            this.customerDgv.Name = "customerDgv";
            this.customerDgv.ReadOnly = true;
            this.customerDgv.RowTemplate.Height = 25;
            this.customerDgv.Size = new System.Drawing.Size(771, 502);
            this.customerDgv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(128, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booked Tickets";
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tickets";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}