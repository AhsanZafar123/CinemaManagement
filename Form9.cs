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
    public partial class Form9 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";
        public Form9()
        {
            InitializeComponent();
        }

        private void display7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reservation_type", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into reservation_type(reservation_type_id,reservation_type)" + "values(@reservation_type_id,@reservation_type)", con))
                {
                    com.Parameters.AddWithValue("@reservation_type_id", reservation_type_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_type", reservation_type_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update reservation_type set reservation_type = @reservation_type where reservation_type_id = @reservation_type_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@reservation_type_id", reservation_type_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_type", reservation_type_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from reservation_type Where reservation_type_id = @reservation_type_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@reservation_type_id", reservation_type_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reservation_type where reservation_type='" + searchbar_reservationtype_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
