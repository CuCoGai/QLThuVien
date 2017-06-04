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
    public partial class frm_login : Form
    {
        QLTVModels db = new QLTVModels();
        public frm_login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            QLTVModels db = new QLTVModels();
            this.AcceptButton = btnDangnhap;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //var n = from s in db.Thuthus
            //             where txtUsername.Text == s.tendangnhap && txtPassword.Text == s.matkhau
            //             select s;
           var n = db.Thuthus.Where(s=>s.chucvu== "Quản lí").Single();
                         //   Thuthu n = new Thuthu();

        //    n.tendangnhap = txtUsername.Text;
         //   n.matkhau = txtPassword.Text;

           if ((n.tendangnhap == txtUsername.Text) && (n.matkhau == txtPassword.Text))
      
            {

                frmUpdateNhanvien fr = new frmUpdateNhanvien();

             //   fr.EnableMenu();
                fr.Show();

                Hide();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLTV fr = new frmQLTV();
            fr.Show();
            Hide();
        }
    }
    }

