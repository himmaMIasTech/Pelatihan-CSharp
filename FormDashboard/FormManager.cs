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
    public partial class FormManager : Form
    {
        public FormManager(string[] Data)
        {
            InitializeComponent();
            lblNama.Text = Data[0];
            lblJabatan.Text = Data[1];

        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
