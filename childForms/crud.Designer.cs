
namespace Concert_ticket_booking_system_final.childForms
{
    partial class crud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.concertsDataGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.artistNameTextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updatesLabel = new System.Windows.Forms.Label();
            this.venueCombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.priceTextbox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // concertsDataGridView
            // 
            this.concertsDataGridView.AllowUserToAddRows = false;
            this.concertsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.concertsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.concertsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.concertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.concertsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.concertsDataGridView.EnableHeadersVisualStyles = false;
            this.concertsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.concertsDataGridView.Location = new System.Drawing.Point(343, 29);
            this.concertsDataGridView.Name = "concertsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.concertsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.concertsDataGridView.RowHeadersWidth = 48;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.concertsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.concertsDataGridView.RowTemplate.Height = 25;
            this.concertsDataGridView.Size = new System.Drawing.Size(692, 473);
            this.concertsDataGridView.TabIndex = 0;
            this.concertsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.concertsDataGridView_CellContentClick);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(33, 352);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(280, 29);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(948, 522);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(87, 29);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(85)))), ((int)(((byte)(102)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(840, 522);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // artistNameTextbox
            // 
            this.artistNameTextbox.Location = new System.Drawing.Point(36, 113);
            this.artistNameTextbox.Name = "artistNameTextbox";
            this.artistNameTextbox.PlaceholderText = "Artist Name";
            this.artistNameTextbox.Size = new System.Drawing.Size(277, 23);
            this.artistNameTextbox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 209);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // updatesLabel
            // 
            this.updatesLabel.AutoSize = true;
            this.updatesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(250)))), ((int)(((byte)(142)))));
            this.updatesLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatesLabel.Location = new System.Drawing.Point(64, 407);
            this.updatesLabel.Name = "updatesLabel";
            this.updatesLabel.Padding = new System.Windows.Forms.Padding(5);
            this.updatesLabel.Size = new System.Drawing.Size(10, 23);
            this.updatesLabel.TabIndex = 9;
            this.updatesLabel.Visible = false;
            // 
            // venueCombo
            // 
            this.venueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueCombo.FormattingEnabled = true;
            this.venueCombo.Location = new System.Drawing.Point(36, 161);
            this.venueCombo.Name = "venueCombo";
            this.venueCombo.Size = new System.Drawing.Size(277, 23);
            this.venueCombo.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(36, 258);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(277, 23);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(36, 307);
            this.priceTextbox.Mask = "0000";
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(277, 23);
            this.priceTextbox.TabIndex = 12;
            this.priceTextbox.ValidatingType = typeof(int);
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 577);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.venueCombo);
            this.Controls.Add(this.updatesLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.artistNameTextbox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.concertsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crud";
            this.Text = "crud";
            this.Load += new System.EventHandler(this.crud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView concertsDataGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox artistNameTextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label updatesLabel;
        private System.Windows.Forms.ComboBox venueCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox priceTextbox;
    }
}