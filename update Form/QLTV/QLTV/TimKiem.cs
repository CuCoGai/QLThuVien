using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.EF;

namespace QLTV
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        ModelQLTV db = new ModelQLTV();

        private void txtTKDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTKDG_MouseClick(object sender, MouseEventArgs e)
        {
            txtTKDG.Text = null;

        }

        private void btnTKDG_Click(object sender, EventArgs e)
        {
            var query = from s in db.Docgias
                        where s.hoten.Contains(txtTKDG.Text)
                        select s;

            dgvTKDG.DataSource = query.ToList();
                        
            
        }

        private void btnTKS_Click(object sender, EventArgs e)
        {
            var query = from s in db.Saches
                        where s.ten.Contains(txtTKS.Text)
                        select s;

            dgvTKS.DataSource = query.ToList();
        }    

        private void btnTKTG_Click(object sender, EventArgs e)
        {
            var query = from s in db.Saches
                        where s.tacgia.Contains(txtTKTG.Text)
                        select s;

            dgvTKTG.DataSource = query.ToList();
        }
    }
}
