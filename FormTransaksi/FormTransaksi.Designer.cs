namespace Pelatihan_CSharp.FormTransaksi
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHasilTransaksi = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTunai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTanggal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelFormTransaksi = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTambahPesanan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapusPesanan = new Guna.UI2.WinForms.Guna2Button();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlahPesanan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.panelGambar = new System.Windows.Forms.Panel();
            this.panelButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBatalkan = new Guna.UI2.WinForms.Guna2Button();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDataTransaksi = new Guna.UI2.WinForms.Guna2Panel();
            this.dgTransaksi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelDataBarang = new Guna.UI2.WinForms.Guna2Panel();
            this.dgBarang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTop.SuspendLayout();
            this.panelHasilTransaksi.SuspendLayout();
            this.panelFormTransaksi.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDataTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaksi)).BeginInit();
            this.panelDataBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelHasilTransaksi);
            this.panelTop.Controls.Add(this.panelFormTransaksi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.ShadowDecoration.Parent = this.panelTop;
            this.panelTop.Size = new System.Drawing.Size(1618, 402);
            this.panelTop.TabIndex = 0;
            // 
            // panelHasilTransaksi
            // 
            this.panelHasilTransaksi.Controls.Add(this.txtTunai);
            this.panelHasilTransaksi.Controls.Add(this.lblTotal);
            this.panelHasilTransaksi.Controls.Add(this.lblTanggal);
            this.panelHasilTransaksi.Controls.Add(this.guna2HtmlLabel3);
            this.panelHasilTransaksi.Controls.Add(this.guna2HtmlLabel2);
            this.panelHasilTransaksi.Controls.Add(this.guna2HtmlLabel1);
            this.panelHasilTransaksi.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHasilTransaksi.Location = new System.Drawing.Point(862, 0);
            this.panelHasilTransaksi.Name = "panelHasilTransaksi";
            this.panelHasilTransaksi.ShadowDecoration.Parent = this.panelHasilTransaksi;
            this.panelHasilTransaksi.Size = new System.Drawing.Size(756, 402);
            this.panelHasilTransaksi.TabIndex = 1;
            // 
            // txtTunai
            // 
            this.txtTunai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTunai.DefaultText = "";
            this.txtTunai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTunai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTunai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunai.DisabledState.Parent = this.txtTunai;
            this.txtTunai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTunai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunai.FocusedState.Parent = this.txtTunai;
            this.txtTunai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTunai.HoverState.Parent = this.txtTunai;
            this.txtTunai.Location = new System.Drawing.Point(226, 233);
            this.txtTunai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTunai.Name = "txtTunai";
            this.txtTunai.PasswordChar = '\0';
            this.txtTunai.PlaceholderText = "";
            this.txtTunai.SelectedText = "";
            this.txtTunai.ShadowDecoration.Parent = this.txtTunai;
            this.txtTunai.Size = new System.Drawing.Size(359, 46);
            this.txtTunai.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(226, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 46);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Rp. 0";
            // 
            // lblTanggal
            // 
            this.lblTanggal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTanggal.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(226, 53);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(140, 46);
            this.lblTanggal.TabIndex = 11;
            this.lblTanggal.Text = "Tanggal";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(45, 233);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(103, 46);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Tunai";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 143);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 46);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Total";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(45, 53);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(147, 46);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Tanggal";
            // 
            // panelFormTransaksi
            // 
            this.panelFormTransaksi.Controls.Add(this.btnTambahPesanan);
            this.panelFormTransaksi.Controls.Add(this.btnHapusPesanan);
            this.panelFormTransaksi.Controls.Add(this.txtHarga);
            this.panelFormTransaksi.Controls.Add(this.txtJumlahPesanan);
            this.panelFormTransaksi.Controls.Add(this.label3);
            this.panelFormTransaksi.Controls.Add(this.label4);
            this.panelFormTransaksi.Controls.Add(this.txtNamaBarang);
            this.panelFormTransaksi.Controls.Add(this.txtStock);
            this.panelFormTransaksi.Controls.Add(this.txtID);
            this.panelFormTransaksi.Controls.Add(this.label2);
            this.panelFormTransaksi.Controls.Add(this.label1);
            this.panelFormTransaksi.Controls.Add(this.lblNama);
            this.panelFormTransaksi.Controls.Add(this.panelGambar);
            this.panelFormTransaksi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFormTransaksi.Location = new System.Drawing.Point(0, 0);
            this.panelFormTransaksi.Name = "panelFormTransaksi";
            this.panelFormTransaksi.ShadowDecoration.Parent = this.panelFormTransaksi;
            this.panelFormTransaksi.Size = new System.Drawing.Size(856, 402);
            this.panelFormTransaksi.TabIndex = 0;
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.CheckedState.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.CustomImages.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnTambahPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.ForeColor = System.Drawing.Color.White;
            this.btnTambahPesanan.HoverState.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.Location = new System.Drawing.Point(291, 329);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.ShadowDecoration.Parent = this.btnTambahPesanan;
            this.btnTambahPesanan.Size = new System.Drawing.Size(240, 49);
            this.btnTambahPesanan.TabIndex = 21;
            this.btnTambahPesanan.Text = "Tambah Pesanan";
            // 
            // btnHapusPesanan
            // 
            this.btnHapusPesanan.CheckedState.Parent = this.btnHapusPesanan;
            this.btnHapusPesanan.CustomImages.Parent = this.btnHapusPesanan;
            this.btnHapusPesanan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnHapusPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusPesanan.ForeColor = System.Drawing.Color.White;
            this.btnHapusPesanan.HoverState.Parent = this.btnHapusPesanan;
            this.btnHapusPesanan.Location = new System.Drawing.Point(556, 329);
            this.btnHapusPesanan.Name = "btnHapusPesanan";
            this.btnHapusPesanan.ShadowDecoration.Parent = this.btnHapusPesanan;
            this.btnHapusPesanan.Size = new System.Drawing.Size(240, 49);
            this.btnHapusPesanan.TabIndex = 20;
            this.btnHapusPesanan.Text = "Hapus Pesanan";
            // 
            // txtHarga
            // 
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.Parent = this.txtHarga;
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.FocusedState.Parent = this.txtHarga;
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.HoverState.Parent = this.txtHarga;
            this.txtHarga.Location = new System.Drawing.Point(470, 215);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderText = "";
            this.txtHarga.SelectedText = "";
            this.txtHarga.ShadowDecoration.Parent = this.txtHarga;
            this.txtHarga.Size = new System.Drawing.Size(326, 36);
            this.txtHarga.TabIndex = 18;
            // 
            // txtJumlahPesanan
            // 
            this.txtJumlahPesanan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlahPesanan.DefaultText = "";
            this.txtJumlahPesanan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlahPesanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlahPesanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahPesanan.DisabledState.Parent = this.txtJumlahPesanan;
            this.txtJumlahPesanan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahPesanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahPesanan.FocusedState.Parent = this.txtJumlahPesanan;
            this.txtJumlahPesanan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahPesanan.HoverState.Parent = this.txtJumlahPesanan;
            this.txtJumlahPesanan.Location = new System.Drawing.Point(470, 270);
            this.txtJumlahPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlahPesanan.Name = "txtJumlahPesanan";
            this.txtJumlahPesanan.PasswordChar = '\0';
            this.txtJumlahPesanan.PlaceholderText = "";
            this.txtJumlahPesanan.SelectedText = "";
            this.txtJumlahPesanan.ShadowDecoration.Parent = this.txtJumlahPesanan;
            this.txtJumlahPesanan.Size = new System.Drawing.Size(326, 36);
            this.txtJumlahPesanan.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jumlah Pesanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Harga";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaBarang.DefaultText = "";
            this.txtNamaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.DisabledState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.FocusedState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.HoverState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.Location = new System.Drawing.Point(470, 105);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.PlaceholderText = "";
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.ShadowDecoration.Parent = this.txtNamaBarang;
            this.txtNamaBarang.Size = new System.Drawing.Size(326, 36);
            this.txtNamaBarang.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.DisabledState.Parent = this.txtStock;
            this.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.FocusedState.Parent = this.txtStock;
            this.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.HoverState.Parent = this.txtStock;
            this.txtStock.Location = new System.Drawing.Point(470, 160);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.PlaceholderText = "";
            this.txtStock.SelectedText = "";
            this.txtStock.ShadowDecoration.Parent = this.txtStock;
            this.txtStock.Size = new System.Drawing.Size(326, 36);
            this.txtStock.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(470, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(326, 36);
            this.txtID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Barang";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(286, 53);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(34, 26);
            this.lblNama.TabIndex = 9;
            this.lblNama.Text = "ID";
            // 
            // panelGambar
            // 
            this.panelGambar.Location = new System.Drawing.Point(51, 51);
            this.panelGambar.Name = "panelGambar";
            this.panelGambar.Size = new System.Drawing.Size(200, 200);
            this.panelGambar.TabIndex = 1;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnBatalkan);
            this.panelButton.Controls.Add(this.btnCari);
            this.panelButton.Controls.Add(this.btnBayar);
            this.panelButton.Controls.Add(this.btnRefresh);
            this.panelButton.Controls.Add(this.txtCari);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.FillColor = System.Drawing.Color.Transparent;
            this.panelButton.Location = new System.Drawing.Point(0, 402);
            this.panelButton.Name = "panelButton";
            this.panelButton.ShadowDecoration.Parent = this.panelButton;
            this.panelButton.Size = new System.Drawing.Size(1618, 675);
            this.panelButton.TabIndex = 1;
            // 
            // btnBatalkan
            // 
            this.btnBatalkan.CheckedState.Parent = this.btnBatalkan;
            this.btnBatalkan.CustomImages.Parent = this.btnBatalkan;
            this.btnBatalkan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnBatalkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatalkan.ForeColor = System.Drawing.Color.White;
            this.btnBatalkan.HoverState.Parent = this.btnBatalkan;
            this.btnBatalkan.Location = new System.Drawing.Point(1064, 84);
            this.btnBatalkan.Name = "btnBatalkan";
            this.btnBatalkan.ShadowDecoration.Parent = this.btnBatalkan;
            this.btnBatalkan.Size = new System.Drawing.Size(383, 49);
            this.btnBatalkan.TabIndex = 16;
            this.btnBatalkan.Text = "Batalkan";
            this.btnBatalkan.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.CheckedState.Parent = this.btnCari;
            this.btnCari.CustomImages.Parent = this.btnCari;
            this.btnCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.HoverState.Parent = this.btnCari;
            this.btnCari.Location = new System.Drawing.Point(597, 56);
            this.btnCari.Name = "btnCari";
            this.btnCari.ShadowDecoration.Parent = this.btnCari;
            this.btnCari.Size = new System.Drawing.Size(112, 49);
            this.btnCari.TabIndex = 19;
            this.btnCari.Text = "Cari";
            // 
            // btnBayar
            // 
            this.btnBayar.CheckedState.Parent = this.btnBayar;
            this.btnBayar.CustomImages.Parent = this.btnBayar;
            this.btnBayar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.HoverState.Parent = this.btnBayar;
            this.btnBayar.Location = new System.Drawing.Point(1064, 25);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.ShadowDecoration.Parent = this.btnBayar;
            this.btnBayar.Size = new System.Drawing.Size(383, 49);
            this.btnBayar.TabIndex = 15;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(724, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(112, 49);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            // 
            // txtCari
            // 
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.Parent = this.txtCari;
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.FocusedState.Parent = this.txtCari;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.HoverState.Parent = this.txtCari;
            this.txtCari.Location = new System.Drawing.Point(29, 62);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "Cari Data";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(540, 36);
            this.txtCari.TabIndex = 14;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelDataTransaksi);
            this.panelBottom.Controls.Add(this.panelDataBarang);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 557);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.ShadowDecoration.Parent = this.panelBottom;
            this.panelBottom.Size = new System.Drawing.Size(1618, 520);
            this.panelBottom.TabIndex = 1;
            // 
            // panelDataTransaksi
            // 
            this.panelDataTransaksi.Controls.Add(this.dgTransaksi);
            this.panelDataTransaksi.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDataTransaksi.Location = new System.Drawing.Point(862, 0);
            this.panelDataTransaksi.Name = "panelDataTransaksi";
            this.panelDataTransaksi.ShadowDecoration.Parent = this.panelDataTransaksi;
            this.panelDataTransaksi.Size = new System.Drawing.Size(756, 520);
            this.panelDataTransaksi.TabIndex = 3;
            // 
            // dgTransaksi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTransaksi.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTransaksi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTransaksi.EnableHeadersVisualStyles = false;
            this.dgTransaksi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTransaksi.Location = new System.Drawing.Point(61, 57);
            this.dgTransaksi.Name = "dgTransaksi";
            this.dgTransaksi.RowHeadersVisible = false;
            this.dgTransaksi.RowHeadersWidth = 62;
            this.dgTransaksi.RowTemplate.Height = 28;
            this.dgTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransaksi.Size = new System.Drawing.Size(634, 407);
            this.dgTransaksi.TabIndex = 2;
            this.dgTransaksi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgTransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTransaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgTransaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgTransaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgTransaksi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTransaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgTransaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgTransaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgTransaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgTransaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgTransaksi.ThemeStyle.HeaderStyle.Height = 4;
            this.dgTransaksi.ThemeStyle.ReadOnly = false;
            this.dgTransaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTransaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTransaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgTransaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTransaksi.ThemeStyle.RowsStyle.Height = 28;
            this.dgTransaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTransaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelDataBarang
            // 
            this.panelDataBarang.Controls.Add(this.dgBarang);
            this.panelDataBarang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataBarang.Location = new System.Drawing.Point(0, 0);
            this.panelDataBarang.Name = "panelDataBarang";
            this.panelDataBarang.ShadowDecoration.Parent = this.panelDataBarang;
            this.panelDataBarang.Size = new System.Drawing.Size(856, 520);
            this.panelDataBarang.TabIndex = 2;
            // 
            // dgBarang
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgBarang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgBarang.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBarang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgBarang.EnableHeadersVisualStyles = false;
            this.dgBarang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBarang.Location = new System.Drawing.Point(61, 57);
            this.dgBarang.Name = "dgBarang";
            this.dgBarang.RowHeadersVisible = false;
            this.dgBarang.RowHeadersWidth = 62;
            this.dgBarang.RowTemplate.Height = 28;
            this.dgBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBarang.Size = new System.Drawing.Size(735, 407);
            this.dgBarang.TabIndex = 1;
            this.dgBarang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgBarang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBarang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgBarang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgBarang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgBarang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgBarang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgBarang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBarang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgBarang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgBarang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgBarang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgBarang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBarang.ThemeStyle.HeaderStyle.Height = 4;
            this.dgBarang.ThemeStyle.ReadOnly = false;
            this.dgBarang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBarang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBarang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgBarang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgBarang.ThemeStyle.RowsStyle.Height = 28;
            this.dgBarang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBarang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1077);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelTop);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.panelTop.ResumeLayout(false);
            this.panelHasilTransaksi.ResumeLayout(false);
            this.panelHasilTransaksi.PerformLayout();
            this.panelFormTransaksi.ResumeLayout(false);
            this.panelFormTransaksi.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelDataTransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaksi)).EndInit();
            this.panelDataBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelHasilTransaksi;
        private Guna.UI2.WinForms.Guna2Panel panelFormTransaksi;
        private Guna.UI2.WinForms.Guna2Panel panelButton;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Panel panelDataTransaksi;
        private Guna.UI2.WinForms.Guna2Panel panelDataBarang;
        private Guna.UI2.WinForms.Guna2Button btnBatalkan;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2DataGridView dgTransaksi;
        private Guna.UI2.WinForms.Guna2DataGridView dgBarang;
        private System.Windows.Forms.Panel panelGambar;
        private Guna.UI2.WinForms.Guna2Button btnTambahPesanan;
        private Guna.UI2.WinForms.Guna2Button btnHapusPesanan;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahPesanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private Guna.UI2.WinForms.Guna2TextBox txtTunai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTanggal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}