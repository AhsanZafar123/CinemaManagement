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
    public partial class Form8 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form8()
        {
            InitializeComponent();
        }

        private void display6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into employee(employee_id,first_name,last_name,job_title,username,password,last_login_time,last_logout_time)" + "values(@employee_id,@first_name,@last_name,@job_title,@username,@password,@last_login_time,@last_logout_time)", con))
                {
                    com.Parameters.AddWithValue("@employee_id", employee_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@first_name", first_name_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_name", last_name_text_box.Text.Trim());
                    com.Parameters.AddWithValue("@job_title", job_title_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@password", password_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_login_time", last_login_time_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_logout_time", last_logout_time_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("Update employee set first_name = @first_name, last_name= @last_name,job_title = @job_title,username = @username,password=@password,last_login_time=@last_login_time,last_logout_time=@last_logout_time where employee_id = @employee_id", con))
                {
                    con.Open();
                    com.Parameters.AddWithValue("@employee_id", employee_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@first_name", first_name_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_name", last_name_text_box.Text.Trim());
                    com.Parameters.AddWithValue("@job_title", job_title_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@password", password_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_login_time", last_login_time_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@last_logout_time", last_logout_time_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from employee Where employee_id = @employee_id", con))
                {
                    con.Open();
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@employee_id", employee_id_textbox.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from employee where job_title='" + searchbar_employees_textbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
