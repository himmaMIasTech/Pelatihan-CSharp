namespace Pelatihan_CSharp.FormDashboard
{
    partial class FormAdmin
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
            this.panelView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnBarang = new Guna.UI2.WinForms.Guna2Button();
            this.btnAkun = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.SteelBlue;
            this.panelView.Location = new System.Drawing.Point(289, 11);
            this.panelView.Name = "panelView";
            this.panelView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelView.Size = new System.Drawing.Size(985, 609);
            this.panelView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBarang);
            this.panel1.Controls.Add(this.btnAkun);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.lblJabatan);
            this.panel1.Controls.Add(this.lblNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 635);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(3, 367);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(283, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.CheckedState.Parent = this.btnBarang;
            this.btnBarang.CustomImages.Parent = this.btnBarang;
            this.btnBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBarang.ForeColor = System.Drawing.Color.White;
            this.btnBarang.HoverState.Parent = this.btnBarang;
            this.btnBarang.Location = new System.Drawing.Point(0, 316);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.ShadowDecoration.Parent = this.btnBarang;
            this.btnBarang.Size = new System.Drawing.Size(283, 45);
            this.btnBarang.TabIndex = 3;
            this.btnBarang.Text = "Master Barang";
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // btnAkun
            // 
            this.btnAkun.CheckedState.Parent = this.btnAkun;
            this.btnAkun.CustomImages.Parent = this.btnAkun;
            this.btnAkun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAkun.ForeColor = System.Drawing.Color.White;
            this.btnAkun.HoverState.Parent = this.btnAkun;
            this.btnAkun.Location = new System.Drawing.Point(0, 265);
            this.btnAkun.Name = "btnAkun";
            this.btnAkun.ShadowDecoration.Parent = this.btnAkun;
            this.btnAkun.Size = new System.Drawing.Size(283, 45);
            this.btnAkun.TabIndex = 1;
            this.btnAkun.Text = "Master Akun";
            this.btnAkun.Click += new System.EventHandler(this.btnAkun_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 214);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(283, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.Location = new System.Drawing.Point(126, 135);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(56, 16);
            this.lblJabatan.TabIndex = 2;
            this.lblJabatan.Text = "Jabatan";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(126, 110);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Pelatihan CSharp";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 633);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnBarang;
        private Guna.UI2.WinForms.Guna2Button btnAkun;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label1;
    }
}