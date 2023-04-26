﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                connection.Open();
                // Kode untuk melakukan query atau manipulasi data di database

                if (connection.State == ConnectionState.Open)
                {
                    label1.Text = "Koneksi berhasil";
                }
                else
                {
                    label1.Text = "Koneksi gagal";
                }
            }
            catch (Exception ex)
            {
                // Tangani exception
                label1.Text = ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
