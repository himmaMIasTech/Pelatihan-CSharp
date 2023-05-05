using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelatihan_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            timer1.Start();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 3;
            // kasih value ke progress bar
            guna2ProgressBar1.Value = startpoint;

            // validasi mengatasi value menjadi 102
            if (guna2ProgressBar1.Value == 99)
            {
                guna2ProgressBar1.Value = 100;
                timer1.Stop();

                // instansiasi class
                LoginForm fl = new LoginForm();

                // tutup form Form1 dan menampilkan LoginForm
                this.Hide();
                fl.Show();
            }
        }
    }
}
