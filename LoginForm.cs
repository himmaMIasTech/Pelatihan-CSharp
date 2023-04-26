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
    public partial class LoginForm : Form
    {
        //get connection from sql
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;




        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            try
            {
                connection.Open();
                //login form
                //cek username dan password
                //jika benar, message box
                //jika salah, message box
                //jika kosong, message box
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username atau password tidak boleh kosong");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("CheckUserLogin", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    //get result
                    String result = cmd.ExecuteScalar().ToString();
                    if (result == "Success")
                    {
                        MessageBox.Show("Login Berhasil");


                    }
                    else
                    {
                        MessageBox.Show("Login Gagal");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
