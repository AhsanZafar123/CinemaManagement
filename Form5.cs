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
    public partial class Form5 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form5()
        {
            InitializeComponent();
        }

        private void display3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from theatre", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void inset3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into theatre(theatre_id,name,seat_count)" + "values(@theatre_id, @name, @seat_count)", con))
                {
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@name", theatre_name_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_count", seat_count_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update theatre set name = @name, seat_count = @seat_count where theatre_id = @theatre_id", con))
                {
                    con.Open();

                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@name", theatre_name_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@seat_count", seat_count_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from theatre Where theatre_id = @theatre_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@theatre_id", theatre_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from theatre where name='" + searchbar_theatre_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
