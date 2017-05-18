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
    public partial class frmUpdateSach : Form
    {
        ModelQLTV context = new ModelQLTV();
        public frmUpdateSach()
        {
            InitializeComponent();
        }

        private void UpdateSach_Load(object sender, EventArgs e)
        {
            //ham nay khi xoa se upload lai du lieu len bang
            FillData();

        }

        public void FillData()
        {
            this.dgvUpdateSach.DataSource = context.Saches.ToList();
            this.dgvUpdateSach.Columns[0].HeaderText = "Mã";
            this.dgvUpdateSach.Columns[1].HeaderText = "Tên";
            this.dgvUpdateSach.Columns[2].HeaderText = "Tác Giả";
            this.dgvUpdateSach.Columns[3].HeaderText = "Loại Sách";
            this.dgvUpdateSach.Columns[4].HeaderText = "Nhà Xuất Bản";
            this.dgvUpdateSach.Columns[5].HeaderText = "Năm Xuất Bản";
            this.dgvUpdateSach.Columns[6].HeaderText = "Số Trang";
            this.dgvUpdateSach.Columns[7].HeaderText = "Số Lượng";
            this.dgvUpdateSach.Columns[8].HeaderText = "Vị Trí";
            this.dgvUpdateSach.Columns[9].HeaderText = "Nội Dung";
        }

        private void dgvUpdateSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
            Sach book = context.Saches.Single(s => s.ma.Equals(ma));
            this.txtMa.Text = book.ma;
            this.txtTen.Text = book.ten;
            this.txtTacgia.Text = book.tacgia;
            this.txtLoaisach.Text = book.loaisach;
            this.txtNhaxuatban.Text = book.nhaxuatbanma;
           // this.dtpNamxuatban.Text = book.namxuatban.ToString();
            this.txtSotrang.Text = book.sotrang.ToString();
            this.txtSoluong.Text = book.soluong.ToString();
           // this.txtVitri.Text = book.vitrima;
            this.txtNoidung.Text = book.noidung;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Sach book = new Sach();
                book.ma = this.txtMa.Text;
                book.ten = this.txtTen.Text;
                book.tacgia = this.txtTacgia.Text;
                book.loaisach = this.txtLoaisach.Text;
                book.nhaxuatbanma = this.txtNhaxuatban.Text;
               // book.namxuatban.ToString() = this.dtpNamxuatban.Text;
                //book.sotrang = this.txtSotrang.Text;
                //book.soluong = this.txtSoluong.Text;
                //book.vitri
                book.noidung = txtNoidung.Text;
                context.Saches.Add(book);
                context.SaveChanges();
                FillData();
                MessageBox.Show("Insert Success!!!");
            }
            catch
            {
                MessageBox.Show("Insert fail!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr= MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Sach book = context.Saches.Single(s => s.ma.Equals(ma));
                    context.Saches.Remove(book);
                    context.SaveChanges();
                    FillData();
                    MessageBox.Show("Delete Success");
                }
                catch
                {
                    MessageBox.Show("Delete fail!!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
                Sach book = context.Saches.Single(s => s.ma.Equals(ma));
                book.ma = this.txtMa.Text;
                book.ten = this.txtTen.Text;
                book.tacgia = this.txtTacgia.Text;
                book.loaisach = this.txtLoaisach.Text;
                book.nhaxuatbanma = this.txtNhaxuatban.Text;
                // book.namxuatban=this.
                //book.sotrang = this.txtSotrang.Text;
                //book.soluong = this.txtSoluong.Text;
                //book.vitri
                book.noidung = txtNoidung.Text;
                context.SaveChanges();
                FillData();
                MessageBox.Show("Updte Success!!");
            }
            catch
            {
                MessageBox.Show("Update fail!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
