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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        ModelQLTV db = new ModelQLTV();



        private void dgvCapnhatkhosach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.dgvCapnhatkhosach.DataSource = db.Saches.ToList();
            dgvCapnhatkhosach.Columns["ma"].HeaderText = "Mã";
            dgvCapnhatkhosach.Columns["ten"].HeaderText = "Tên";
            dgvCapnhatkhosach.Columns["tacgia"].HeaderText = "Tác giả";
            dgvCapnhatkhosach.Columns["loaisach"].HeaderText = "Loại sách";
            dgvCapnhatkhosach.Columns["nhaxuatbanma"].HeaderText = "NXB";
            dgvCapnhatkhosach.Columns["sotrang"].HeaderText = "Số trang";
            dgvCapnhatkhosach.Columns["solanxuatban"].HeaderText = "Số lần XB";
            dgvCapnhatkhosach.Columns["soluong"].HeaderText = "SỐ LƯỢNG";
            dgvCapnhatkhosach.Columns["noidung"].HeaderText = "Nội Dung";
            dgvCapnhatkhosach.Columns["giatien"].HeaderText = "Giá tiền";
            dgvCapnhatkhosach.Columns["ngonngu"].HeaderText = "Ngôn ngữ";
            dgvCapnhatkhosach.Columns["khoma"].HeaderText = "Mã kho";





        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTV f = new frmQLTV();
            f.Show();
        }
    }
}
