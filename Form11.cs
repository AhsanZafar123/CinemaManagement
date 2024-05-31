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
    public partial class Form11 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form11()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void display9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reserved_seats", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into reserved_seats(reserved_seat_id,seat_id,screening_id,reservation_id)" + "values(@reserved_seat_id,@seat_id,@screening_id,@reservation_id)", con))
                {
                    com.Parameters.AddWithValue("@reserved_seat_id", reserved_seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_id", seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_id", reservation_id_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update reserved_seats set seat_id = @seat_id, screening_id= @screening_id,reservation_id = @reservation_id where reserved_seat_id = @reserved_seat_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@reserved_seat_id", reserved_seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_id", seat_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_id", reservation_id_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from reserved_seats Where reserved_seat_id = @reserved_seat_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@reserved_seat_id", reserved_seat_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reserved_seats where screening_id='" + searchbar_reservedseats_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
