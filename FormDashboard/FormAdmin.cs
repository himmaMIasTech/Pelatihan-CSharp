﻿using Pelatihan_CSharp.FormMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelatihan_CSharp.FormDashboard
{
    public partial class FormAdmin : Form
    {

        private Panel leftBorderBtn;
        private Form currchildform;

        public FormAdmin(string[] Data)
        {
            InitializeComponent();

            // mendapat data user yang login
            lblNama.Text = Data[0];
            lblJabatan.Text = Data[1];

            // untuk membuat window penuh pada layar
            WindowState = FormWindowState.Maximized;
        }

        private void openChildForm(Form childForm)
        {
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            panelView.Controls.Add(childForm);
            panelView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "LogOut!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new LoginForm().Show();
                //kill this
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAkun());
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBarang());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                currchildform.Close();
            }
            catch { }
        }
    }
}
