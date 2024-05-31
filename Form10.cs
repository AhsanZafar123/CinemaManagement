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
    public partial class Form10 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form10()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void display8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reservation", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into reservation(reservation_id,screening_id,employee_reserved_id,reservation_type_id,customer_phone_no,employee_paid_id,reservation_date)" + "values(@reservation_id,@screening_id,@employee_reserved_id,@reservation_type_id,@customer_phone_no,@employee_paid_id,@reservation_date)", con))
                {
                    com.Parameters.AddWithValue("@reservation_id", reservation_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@employee_reserved_id", employee_reserved_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_type_id", reservation_type_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@customer_phone_no", customer_phone_no_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@employee_paid_id", employee_paid_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_date", reservation_date_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update reservation set screening_id = @screening_id, employee_reserved_id= @employee_reserved_id,reservation_type_id = @reservation_type_id,customer_phone_no = @customer_phone_no,employee_paid_id=@employee_paid_id,reservation_date=@reservation_date where reservation_id = @reservation_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@reservation_id", reservation_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@screening_id", screening_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@employee_reserved_id", employee_reserved_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_type_id", reservation_type_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@customer_phone_no", customer_phone_no_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@employee_paid_id", employee_paid_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@reservation_date", reservation_date_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from reservation Where reservation_id = @reservation_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@reservation_id", reservation_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from reservation where screening_id='" + searchbox_reservation_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
