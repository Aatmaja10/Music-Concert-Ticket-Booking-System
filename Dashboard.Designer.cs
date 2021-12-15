
namespace Concert_ticket_booking_system_final
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ticketsBtn = new System.Windows.Forms.Button();
            this.concertsBtn = new System.Windows.Forms.Button();
            this.seatBookingBtn = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.menuPanel.Controls.Add(this.logoutBtn);
            this.menuPanel.Controls.Add(this.ticketsBtn);
            this.menuPanel.Controls.Add(this.concertsBtn);
            this.menuPanel.Controls.Add(this.seatBookingBtn);
            this.menuPanel.Controls.Add(this.adminPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(148, 677);
            this.menuPanel.TabIndex = 0;
            // 
            // ticketsBtn
            // 
            this.ticketsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.ticketsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ticketsBtn.Location = new System.Drawing.Point(0, 212);
            this.ticketsBtn.Name = "ticketsBtn";
            this.ticketsBtn.Size = new System.Drawing.Size(148, 52);
            this.ticketsBtn.TabIndex = 2;
            this.ticketsBtn.Text = "Tickets";
            this.ticketsBtn.UseVisualStyleBackColor = false;
            this.ticketsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // concertsBtn
            // 
            this.concertsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.concertsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concertsBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.concertsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.concertsBtn.Location = new System.Drawing.Point(0, 100);
            this.concertsBtn.Name = "concertsBtn";
            this.concertsBtn.Size = new System.Drawing.Size(148, 52);
            this.concertsBtn.TabIndex = 0;
            this.concertsBtn.Text = "Concerts";
            this.concertsBtn.UseVisualStyleBackColor = false;
            this.concertsBtn.Click += new System.EventHandler(this.concertsBtn_Click);
            // 
            // seatBookingBtn
            // 
            this.seatBookingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.seatBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seatBookingBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seatBookingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seatBookingBtn.Location = new System.Drawing.Point(0, 156);
            this.seatBookingBtn.Name = "seatBookingBtn";
            this.seatBookingBtn.Size = new System.Drawing.Size(148, 52);
            this.seatBookingBtn.TabIndex = 1;
            this.seatBookingBtn.Text = "Seat Booking";
            this.seatBookingBtn.UseVisualStyleBackColor = false;
            this.seatBookingBtn.Click += new System.EventHandler(this.seatBookingBtn_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.adminPanel.Controls.Add(this.logoPanel);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPanel.Location = new System.Drawing.Point(0, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(148, 100);
            this.adminPanel.TabIndex = 3;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoPanel.Image = ((System.Drawing.Image)(resources.GetObject("logoPanel.Image")));
            this.logoPanel.Location = new System.Drawing.Point(53, 33);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(40, 33);
            this.logoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPanel.TabIndex = 0;
            this.logoPanel.TabStop = false;
            this.logoPanel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.titlePanel.Controls.Add(this.dashboardLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(148, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1047, 100);
            this.titlePanel.TabIndex = 1;
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboardLabel.Location = new System.Drawing.Point(435, 28);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(254, 53);
            this.dashboardLabel.TabIndex = 0;
            this.dashboardLabel.Text = "Dashboard";
            this.dashboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopPanel
            // 
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(148, 100);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1047, 577);
            this.desktopPanel.TabIndex = 2;
            this.desktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.desktopPanel_Paint);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(0, 268);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(148, 52);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 677);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Concert";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPanel)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button ticketsBtn;
        private System.Windows.Forms.Button seatBookingBtn;
        private System.Windows.Forms.Button concertsBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.PictureBox logoPanel;
        private System.Windows.Forms.Button logoutBtn;
    }
}