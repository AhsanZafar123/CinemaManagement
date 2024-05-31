using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Web.SiteMap;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace cinemamangement_1
{
    public partial class Form7 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form7()
        {
            InitializeComponent();
        }

        private void display5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from seats", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into seats(seat_id,row,seat_no,theatre_id)" + "values(@seat_id,@row,@seat_no, @theatre_id)", con))
                {
                    com.Parameters.AddWithValue("@seat_id", seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@row", row_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_no", seat_no_text_box.Text.Trim());
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update seats set row = @row, seat_no= @seat_no,theatre_id = @theatre_id where seat_id = @seat_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@seat_id", seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@row", row_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_no", seat_no_text_box.Text.Trim());
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from seats Where seat_id = @seat_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@seat_id", seat_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from seats where theatre_id='" + searchbar_seats_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
