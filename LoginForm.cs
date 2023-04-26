using Pelatihan_CSharp.FormDashboard;
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
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string result = reader["result"].ToString();
                            if (result == "Success")
                            {
                                string jabatan = reader["jabatan"].ToString();
                                string nama = reader["nama"].ToString();
                                string[] data = { nama, jabatan };
                                // lakukan tindakan setelah login berhasil
                                MessageBox.Show("Login berhasil! Jabatan: " + jabatan);
                                if (jabatan.Equals("Admin"))
                                {
                                    new FormAdmin(data).Show();
                                    this.Hide();
                                }
                                else if (jabatan.Equals("Manager"))
                                {
                                    new FormManager(data).Show();                                    
                                    this.Hide();
                                }else if (jabatan.Equals("Kasir"))
                                {
                                    new FormKasir(data).Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Login gagal. Silakan coba lagi.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login gagal. Silakan coba lagi.");
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
