
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
    public partial class frm_login : Form
    {
        TVEnti db = new TVEnti();
        public frm_login()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            TVEnti db = new TVEnti();
            this.AcceptButton = btn_Dangnhap;
        }
        private void disconnect()
        {
            //ngắt kết nối
            db.Dispose();//giải phóng tài nguyên
           db = null;//hủy đối tượng

        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            db.Thuthus.Single();
        }
    }
}