using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelatihan_CSharp.FormMaster
{
    public partial class FormBarang : Form
    {
        //get connection from sql
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        public FormBarang()
        {
            InitializeComponent();
        }



        public void LoadData()
        {
            btnTambah.Visible = true; //BISA DIGUNAKAN KETIKA PERTAMA KALI DIBUKA
            btnUpdate.Visible = false; //TIDAK BISA DIGUNAKAN KETIKA PERTAMA KALI DIBUKA, MENGURANGI KESALAHAN SISTEM
            btnHapus.Visible = false;   ////TIDAK BISA DIGUNAKAN KETIKA PERTAMA KALI DIBUKA, MENGURANGI KESALAHAN SISTEM
            BindingSource bSource = new BindingSource();
            try
            {
                clear();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand load = new SqlCommand("mBarangLoad", con);
                    load.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(load);
                    adapter.Fill(dt);
                    bSource.DataSource = dt;
                    dgBarang.DataSource = bSource;
                    DataGridViewColumn column = dgBarang.Columns[1];
                    column.FillWeight = 200;
                    column.Width = 100;


                    ((DataGridViewImageColumn)dgBarang.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    this.dgBarang.DefaultCellStyle.NullValue = null;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dgBarang.Columns[0].HeaderCell.Value = "Nama Barang";
                dgBarang.Columns[1].HeaderCell.Value = "Jumlah";
                dgBarang.Columns[2].HeaderCell.Value = "Harga";
                dgBarang.Columns[3].HeaderCell.Value = "Gambar";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        public void clear()
        {
            txtNamaBarang.Text = "";
            txtKuantitas.Text = "";
            txtHarga.Text = "";
            txtCari.Text = "";
            txtId.Text = "";
            pbGambar.Image = null;
        }

        public Boolean validasi(String action)
        {
            Boolean[] mCheck = { false, false, false, false };

            if (!txtNamaBarang.Text.Equals(""))
            {
                mCheck[0] = true;
            }

            if (!txtKuantitas.Text.Equals(""))
            {
                mCheck[1] = true;
            }

            if (!txtHarga.Text.Equals(""))
            {
                mCheck[2] = true;
            }

            if (pbGambar.Image != null)
            {
                mCheck[3] = true;
            }

            if (action.Equals("Insert"))
            {
                if (mCheck[0] && mCheck[1] && mCheck[2] && mCheck[3])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (action.Equals("Update"))
            {
                if (mCheck[0] && mCheck[1] && mCheck[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(.jpg; *.jpeg; *.png) |  *.jpg;.jpeg; *.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string Filename = openFileDialog.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("The file size is too big! Please select a file with a maximum size of 5 MB!");
                        }
                        else
                        {
                            pbGambar.Load(Filename);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (validasi("Insert"))
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    pbGambar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("mBarangTambah", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text);
                    cmd.Parameters.AddWithValue("@qty", txtKuantitas.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@image", pic);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan");
                    LoadData();
                    clear();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validasi("Update")){
                try
                {
                    MemoryStream stream = new MemoryStream();
                    pbGambar.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("mBarangUpdate", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text);
                    cmd.Parameters.AddWithValue("@qty", txtKuantitas.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@image", pic);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diUbah");
                    LoadData();
                    clear();
                    connection.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("isikan data terlebih dahulu");
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Delete", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("mBarangHapus", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus");
                        LoadData();
                        clear();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data batal dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Data masih Kosong");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bSource = new BindingSource();
                
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand load = new SqlCommand("mBarangCari", con);
                    load.CommandType = CommandType.StoredProcedure;
                    load.Parameters.AddWithValue("@nama", txtCari.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(load);
                    adapter.Fill(dt);
                    //bSource.DataSource = dt;
                    dgBarang.DataSource = dt;
                    DataGridViewColumn column = dgBarang.Columns[1];
                    column.FillWeight = 200;
                    column.Width = 100;


                    ((DataGridViewImageColumn)dgBarang.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    con.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                dgBarang.Columns[0].HeaderCell.Value = "Nama Barang";
                dgBarang.Columns[1].HeaderCell.Value = "Gambar";
                dgBarang.Columns[2].HeaderCell.Value = "Jumlah";
                dgBarang.Columns[3].HeaderCell.Value = "Harga";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Visible = false;
            btnUpdate.Visible = true;
            btnHapus.Visible = true;
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgBarang.Rows[e.RowIndex]; //MENGAMBIL DATA DARI DATAGRIDVIEW SESUAI DENGAN BARIS YANG DIPILIH
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtNamaBarang.Text = row.Cells[2].Value.ToString();
                    txtKuantitas.Text = row.Cells[3].Value.ToString();
                    float tempharga = float.Parse(row.Cells[4].Value.ToString());
                    txtHarga.Text = tempharga.ToString();
                    byte[] img = (byte[])row.Cells[1].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pbGambar.Image = Image.FromStream(ms);

                }
            }catch(Exception ex)
            {
                clear();
                MessageBox.Show("Error");
            }
        }
    }
}
