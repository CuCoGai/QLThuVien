using QLTV.EF;
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
    public partial class frmDangNhap : Form
    {
        QLTVModels context = new QLTVModels();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            ////FormQLTV frmTrangchu = new FormQLTV();
            ////frmTrangchu.Show();
            ////this.Hide();  //Ẩn
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        
    }
}
