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
    public partial class FormQLTV : Form
    {
        public FormQLTV()
        {
            InitializeComponent();
        }

        private void FormQLTV_Load(object sender, EventArgs e)
        {

        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login fr = new frm_login();
            fr.Show();
            Hide();
        }
        public void EnableMenu()
        {
            tl_sach.Enabled = true;
            tl_docgia.Enabled = true;
            tl_huongdan.Enabled = true;
            tl_thongke.Enabled = true;

        }
        public void DisEnabledMenu()
        {
            tl_sach.Enabled = false;
            tl_docgia.Enabled = false;
            tl_huongdan.Enabled = false;
            tl_thongke.Enabled = false;

        }
        private void ctrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
