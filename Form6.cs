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
    public partial class Form6 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form6()
        {
            InitializeComponent();
        }

        private void display4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from screening", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into screening(screening_id,movie_id,theatre_id,start_time,end_time)" + "values(@screening_id,@movie_id,@theatre_id, @start_time, @end_time)", con))
                {
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@movie_id", movie_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@start_time", start_time_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@end_time", end_time_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update screening set movie_id = @movie_id, theatre_id = @theatre_id,start_time = @start_time,end_time = @end_time where screening_id = @screening_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@movie_id", movie_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@start_time", start_time_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@end_time", end_time_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from screening Where screening_id = @screening_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from screening where start_time='" + searchbar_screenings_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
