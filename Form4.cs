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
    public partial class Form4 : Form
    {
        string connectionString = @"Server=localhost;Database=cinemaproject;Uid=root;Pwd=root";

        public Form4()
        {
            InitializeComponent();
        }

        private void display2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Data Source=DESKTOP-4VBQ1K7\SQLEXPRESS;Initial Catalog=cinemaproject;Integrated Security=True))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from movie", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void insert2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Data Source=DESKTOP-4VBQ1K7\SQLEXPRESS;Initial Catalog=cinemaproject;Integrated Security=True))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand("Insert into movie(movie_id,title,director,actors,synopsis,duration_mins)" + "values(@movie_id, @title, @director,@actors,@synopsis,@duration_mins)", con))
                {
                    com.Parameters.AddWithValue("@movie_id", movie_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@title", movie_title_textox.Text.Trim());
                    com.Parameters.AddWithValue("@director", director_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@actors", staff_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@synopsis", synopsis_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@duration_mins", duration_textbox.Text.Trim());
                    com.ExecuteNonQuery();

                    MessageBox.Show("record saved successfully");
                }
            }
        }

        private void update2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Data Source=DESKTOP-4VBQ1K7\SQLEXPRESS;Initial Catalog=cinemaproject;Integrated Security=True))
            {
                using (MySqlCommand com = new MySqlCommand("Update movie set title = @title, director = @director, actors = @actors,synopsis = @synopsis,duration_mins=@duration_mins where movie_id = @movie_id", con))
                {
                    con.Open();

                    com.Parameters.AddWithValue("@movie_id", movie_id_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@title", movie_title_textox.Text.Trim());
                    com.Parameters.AddWithValue("@director", director_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@actors", staff_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@synopsis", synopsis_textbox.Text.Trim());
                    com.Parameters.AddWithValue("@duration_mins", duration_textbox.Text.Trim());
                    com.ExecuteNonQuery();
                    MessageBox.Show("record updated successfully");

                }
            }
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Data Source=DESKTOP-4VBQ1K7\SQLEXPRESS;Initial Catalog=cinemaproject;Integrated Security=True))
            {
                using (MySqlCommand com = new MySqlCommand("DELETE from movie Where movie_id = @movie_id", con))
                {
                con.Open();
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@movie_id", movie_id_textbox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("record deleted successfully");
                }
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Data Source=DESKTOP-4VBQ1K7\SQLEXPRESS;Initial Catalog=cinemaproject;Integrated Security=True))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from movie where title='"+searchbartext.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void movies_title_Click(object sender, EventArgs e)
        {

        }
    }
}
