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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2();
            secondform.Show();
            //this.Hide();
        }

        private void login_admin_Click(object sender, EventArgs e)
        {
            Form3 thirdform = new Form3();
            thirdform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
