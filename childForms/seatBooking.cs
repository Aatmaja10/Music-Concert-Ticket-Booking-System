using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Concert_ticket_booking_system_final.childForms
{
    public partial class seatBooking : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Click Concert;Integrated Security=True");
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        public seatBooking()
        {
            InitializeComponent();
        }

        private void seatBooking_Load(object sender, EventArgs e)
        {
            //LABEL STYLING
            concertNameLabel.BackColor = Color.FromArgb(230, 230, 230);
            venueNameLabel.BackColor = Color.FromArgb(230, 230, 230);
            dateNameLabel.BackColor = Color.FromArgb(230, 230, 230);
            timeNameLabel.BackColor = Color.FromArgb(230, 230, 230);
            //ON FORM LOAD POPULATE THE COMBO BOX WITH CURRENT CONCERTS 
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string showCurrentConcerts = "SELECT concert_artist FROM concert_details;";
                    SqlCommand cmd = new SqlCommand(showCurrentConcerts, conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        artistCombo.Items.Add(dr[0]);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void artistCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = artistCombo.SelectedItem;
            concertNameLabel.Text = selected.ToString();
            string artistTable = concertNameLabel.Text.Replace(" ", String.Empty);
            //GET THE SEAT BOOKING TABLE OF THE SELECTED ARTIST
            string select = "SELECT * FROM " + artistTable + ";";
            //GET CONCERT DETAILS
            string selectQuery = "SELECT concert_artist, concert_venue, concert_date, concert_time, concert_price FROM concert_details WHERE concert_artist = '" + selected.ToString() + "';";
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    //DISPLAY CONCERT DETAILS OF CURRENT SELECTED ARTIST
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        concertNameLabel.Text = dr[0].ToString();
                        venueNameLabel.Text = dr[1].ToString();
                        dateNameLabel.Text = dr[2].ToString();
                        timeNameLabel.Text = dr[3].ToString();
                        priceNameLabel.Text = dr[4].ToString();
                    }
                    dr.Close();
                    //NEW DATA TABLE FOR EACH CB INDEX CHANGE TO ENSURE CORRECT SEAT BOOKING TABLE TO BE DISPLAYED
                    DataTable dt = new DataTable();
                    da = new SqlDataAdapter(select, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //CHANGE COL NAME
                    dataGridView1.Columns[0].HeaderText = "Seat No.";
                    dataGridView1.Columns[1].HeaderText = "Status";
                    //DISPLAY IN CUSTOMER INFO SECTION
                    custPriceLabel.Text = priceNameLabel.Text;
                    custVenueLabel.Text = venueNameLabel.Text;
                    custConcertDateLabel.Text = dateNameLabel.Text;
                    custConcertTimeLabel.Text = timeNameLabel.Text;
                    custConcertLable.Text = concertNameLabel.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void venueLabel_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //ALLOW ONLY ONE ROW TO BE SELECTED AT A TIME AND GET THE SEAT NO OF SELECTED ROW
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int indexSeat = cell.ColumnIndex;
                        if (indexSeat == 0)
                        {
                            //MessageBox.Show(cell.Value.ToString());
                            custSeatLabel.Text = cell.Value.ToString();
                        }
                    }
                }
            }
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)//CHANGE SEAT STATUS
        {
            //change status from unbooked to booked
            //add customer details to customer table
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    //IF USER SELECTS AN UNBOOKED SEAT, SELECT THAT SEAT TO BOOK AND REFLECT IT IN DGV
                    conn.Open();
                    string artistTable = concertNameLabel.Text.Replace(" ", String.Empty);
                    string updateQuery = "UPDATE " + artistTable + " SET status = 'booked' WHERE seat_no = '" + Int32.Parse(custSeatLabel.Text) + "'; ";
                    da = new SqlDataAdapter(updateQuery, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //DISPLAY RECENTLY BOOKED SEAT
                    string showRecentBooking = " SELECT * FROM " + artistTable + ";";
                    da = new SqlDataAdapter(showRecentBooking, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //SHOW CUSTOMER NAME IN INFO SECTION AFTER SAVING
            custNameLabel.Text = custNameTextbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CHECK FOR EMPTY TEXTBOXES
            if (custNameTextbox.Text != "" || custEmailTextbox.Text != "")
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        //BOOK THE SELECTED TICKET
                        conn.Open();
                        string bookTicketQuery = "INSERT INTO concert_tickets VALUES ( '" + custNameLabel.Text + "','" + custEmailTextbox.Text + "', '" + custConcertLable.Text + "', '" + custVenueLabel.Text + "', '" + custConcertTimeLabel.Text + "', '" + custConcertDateLabel.Text + "', '" + Int32.Parse(custPriceLabel.Text) + "', '" + Int32.Parse(custSeatLabel.Text) + "');";
                        SqlCommand cmd = new SqlCommand(bookTicketQuery, conn);
                        cmd.ExecuteNonQuery();
                        //NOTIFY THE CUSTOMER BY SENDING EMAIL AND BOOKING DETAILS
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("clickconcert00@gmail.com");
                            mail.To.Add(custEmailTextbox.Text);
                            mail.Subject = "Thankyou for booking your tickets from Click Concert!";
                            mail.Body = "<h3>Hi," + custNameLabel.Text +  "</h3>" + "<h3>Your tickets for " + custConcertLable.Text + " Concert has been booked sucessfully!</h3>" +
                                "<h4>Concert name: " + custConcertLable.Text + "</h4>" + "<h4>" + "Concert Venue: " + custVenueLabel.Text + "</h4>" + "<h4>" + "Seat No: " + custSeatLabel.Text + "<h4>" + "<h4>" + "Thankyou for your purchase! </h4>";
                            mail.IsBodyHtml = true;
                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new NetworkCredential("clickconcert00@gmail.com", "clickconcert123");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }
                        MessageBox.Show("Your ticket has been successfully booked!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter all the details");
            }
        }
    }
}
