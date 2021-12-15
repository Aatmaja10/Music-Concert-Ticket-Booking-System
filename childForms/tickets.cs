using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Concert_ticket_booking_system_final.childForms
{
    public partial class tickets : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Click Concert;Integrated Security=True");
        DataTable dt = new DataTable();
        public tickets()
        {
            InitializeComponent();
        }

        private void tickets_Load(object sender, EventArgs e)
        {
            //DATAGRIDVIEW STYLING
            customerDgv.EnableHeadersVisualStyles = false;
            customerDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 34);
            customerDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //DISPLAY CONTENTS OF CONCERT_TICKETS ON FORM LOAD
            string selectQuery = "SELECT * FROM concert_tickets";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
            da.Fill(dt);
            customerDgv.DataSource = dt;
            customerDgv.Columns[0].HeaderText = "Ticket Id";
            customerDgv.Columns[1].HeaderText = "Customer Name";
            customerDgv.Columns[2].HeaderText = "Customer Email";
            customerDgv.Columns[3].HeaderText = "Concert";
            customerDgv.Columns[4].HeaderText = "Venue";
            customerDgv.Columns[5].HeaderText = "Time";
            customerDgv.Columns[6].HeaderText = "Date";
            customerDgv.Columns[7].HeaderText = "Price";
            customerDgv.Columns[8].HeaderText = "Seat No";

            //AUTOSIZE COLUMNS
            customerDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
