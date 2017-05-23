using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmQLTV : Form
    {
        public frmQLTV()
        {
            InitializeComponent();
        }

        private void ctrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            //f.MdiParent = this;  //xác định đây là form cha
            f.Show();
            this.Hide();
        }

        private void mượnSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyMuonTra f = new frmQuanLyMuonTra();
            f.Show();
            this.Hide();
        }

        private void trảSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyMuonTra f = new frmQuanLyMuonTra();
            f.Show();
            this.Hide();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();
            this.Hide();
        }

        //private void updateSáchToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmUpdateSach f = new frmUpdateSach();
        //    f.Show();
        //    this.Hide();
        //}

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateNhanvien f = new frmUpdateNhanvien();
            f.Show();
            this.Hide();
        }

        private void tìmKiếmTheoTênSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDocgia f = new frmUpdateDocgia();
            f.Show();
            this.Hide();
        }

        private void tìmKiếmTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();
            this.Hide();
        }

        private void tìmKiếmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.Show();
            this.Hide();
        }

        private void menu_login_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
            Hide();

        }
    }
}
