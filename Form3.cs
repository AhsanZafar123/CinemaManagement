using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemamangement_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void setmovie_Click(object sender, EventArgs e)
        {
            Form4 fourthform = new Form4();
            fourthform.Show();
        }

        private void settheatre_Click(object sender, EventArgs e)
        {
            Form5 fifthform = new Form5();
            fifthform.Show();
        }

        private void setscreening_Click(object sender, EventArgs e)
        {
            Form6 sixthform = new Form6();
            sixthform.Show();
        }

        private void setseats_Click(object sender, EventArgs e)
        {
            Form7 seventhform = new Form7();
            seventhform.Show();
        }

        private void setemployee_Click(object sender, EventArgs e)
        {
            Form8 eighthform = new Form8();
            eighthform.Show();
        }

        private void setreservationtype_Click(object sender, EventArgs e)
        {
            Form9 ninthform = new Form9();
            ninthform.Show();
        }

        private void setreservation_Click(object sender, EventArgs e)
        {
            Form10 tenthform = new Form10();
            tenthform.Show();
        }

        private void setreservedseats_Click(object sender, EventArgs e)
        {
            Form11 eleventhform = new Form11();
            eleventhform.Show();
        }
    }
}
