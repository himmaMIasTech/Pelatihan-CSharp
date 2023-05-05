namespace Pelatihan_CSharp.FormMaster
{
    partial class FormBarang
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelGambar = new System.Windows.Forms.Panel();
            this.btnPilihGambar = new Guna.UI2.WinForms.Guna2Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKuantitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgBarang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelButton.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnCari);
            this.panelButton.Controls.Add(this.btnRefresh);
            this.panelButton.Controls.Add(this.txtCari);
            this.panelButton.Controls.Add(this.btnUpdate);
            this.panelButton.Controls.Add(this.btnHapus);
            this.panelButton.Controls.Add(this.btnTambah);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 397);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1618, 133);
            this.panelButton.TabIndex = 5;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dgBarang);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTable.Location = new System.Drawing.Point(0, 530);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1618, 547);
            this.panelTable.TabIndex = 4;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.txtKuantitas);
            this.panelForm.Controls.Add(this.txtHarga);
            this.panelForm.Controls.Add(this.txtNamaBarang);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.lblNama);
            this.panelForm.Controls.Add(this.btnPilihGambar);
            this.panelForm.Controls.Add(this.panelGambar);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1618, 397);
            this.panelForm.TabIndex = 3;
            // 
            // panelGambar
            // 
            this.panelGambar.Location = new System.Drawing.Point(71, 55);
            this.panelGambar.Name = "panelGambar";
            this.panelGambar.Size = new System.Drawing.Size(200, 200);
            this.panelGambar.TabIndex = 0;
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.CheckedState.Parent = this.btnPilihGambar;
            this.btnPilihGambar.CustomImages.Parent = this.btnPilihGambar;
            this.btnPilihGambar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnPilihGambar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilihGambar.ForeColor = System.Drawing.Color.White;
            this.btnPilihGambar.HoverState.Parent = this.btnPilihGambar;
            this.btnPilihGambar.Location = new System.Drawing.Point(71, 287);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.ShadowDecoration.Parent = this.btnPilihGambar;
            this.btnPilihGambar.Size = new System.Drawing.Size(200, 49);
            this.btnPilihGambar.TabIndex = 2;
            this.btnPilihGambar.Text = "Pilih Gambar";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(311, 55);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(147, 26);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama Barang";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kuantitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harga";
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
            this.txtNamaBarang.Location = new System.Drawing.Point(495, 53);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.PlaceholderText = "";
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.ShadowDecoration.Parent = this.txtNamaBarang;
            this.txtNamaBarang.Size = new System.Drawing.Size(731, 36);
            this.txtNamaBarang.TabIndex = 6;
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
            this.txtHarga.Location = new System.Drawing.Point(495, 162);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderText = "";
            this.txtHarga.SelectedText = "";
            this.txtHarga.ShadowDecoration.Parent = this.txtHarga;
            this.txtHarga.Size = new System.Drawing.Size(731, 36);
            this.txtHarga.TabIndex = 7;
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKuantitas.DefaultText = "";
            this.txtKuantitas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKuantitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKuantitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.DisabledState.Parent = this.txtKuantitas;
            this.txtKuantitas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKuantitas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.FocusedState.Parent = this.txtKuantitas;
            this.txtKuantitas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKuantitas.HoverState.Parent = this.txtKuantitas;
            this.txtKuantitas.Location = new System.Drawing.Point(495, 107);
            this.txtKuantitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.PasswordChar = '\0';
            this.txtKuantitas.PlaceholderText = "";
            this.txtKuantitas.SelectedText = "";
            this.txtKuantitas.ShadowDecoration.Parent = this.txtKuantitas;
            this.txtKuantitas.Size = new System.Drawing.Size(731, 36);
            this.txtKuantitas.TabIndex = 8;
            // 
            // btnTambah
            // 
            this.btnTambah.CheckedState.Parent = this.btnTambah;
            this.btnTambah.CustomImages.Parent = this.btnTambah;
            this.btnTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.HoverState.Parent = this.btnTambah;
            this.btnTambah.Location = new System.Drawing.Point(94, 46);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(112, 49);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            // 
            // btnHapus
            // 
            this.btnHapus.CheckedState.Parent = this.btnHapus;
            this.btnHapus.CustomImages.Parent = this.btnHapus;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.Parent = this.btnHapus;
            this.btnHapus.Location = new System.Drawing.Point(349, 46);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(112, 49);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(222, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(112, 49);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
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
            this.txtCari.Location = new System.Drawing.Point(499, 51);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "Cari Data";
            this.txtCari.SelectedText = "";
            this.txtCari.ShadowDecoration.Parent = this.txtCari;
            this.txtCari.Size = new System.Drawing.Size(731, 36);
            this.txtCari.TabIndex = 9;
            // 
            // btnCari
            // 
            this.btnCari.CheckedState.Parent = this.btnCari;
            this.btnCari.CustomImages.Parent = this.btnCari;
            this.btnCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.HoverState.Parent = this.btnCari;
            this.btnCari.Location = new System.Drawing.Point(1267, 46);
            this.btnCari.Name = "btnCari";
            this.btnCari.ShadowDecoration.Parent = this.btnCari;
            this.btnCari.Size = new System.Drawing.Size(112, 49);
            this.btnCari.TabIndex = 13;
            this.btnCari.Text = "Cari";
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(123)))), ((int)(((byte)(172)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(1394, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(112, 49);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            // 
            // dgBarang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgBarang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBarang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgBarang.EnableHeadersVisualStyles = false;
            this.dgBarang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgBarang.Location = new System.Drawing.Point(94, 65);
            this.dgBarang.Name = "dgBarang";
            this.dgBarang.RowHeadersVisible = false;
            this.dgBarang.RowHeadersWidth = 62;
            this.dgBarang.RowTemplate.Height = 28;
            this.dgBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBarang.Size = new System.Drawing.Size(1412, 386);
            this.dgBarang.TabIndex = 0;
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
            this.dgBarang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1077);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelForm);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.panelButton.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelGambar;
        private Guna.UI2.WinForms.Guna2Button btnPilihGambar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private Guna.UI2.WinForms.Guna2TextBox txtKuantitas;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaBarang;
        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
        private Guna.UI2.WinForms.Guna2DataGridView dgBarang;
    }
}