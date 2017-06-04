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
        QLTVModels context = new QLTVModels();
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
            this.dgvUpdateSach.Columns[5].HeaderText = "Ngôn Ngữ";
            this.dgvUpdateSach.Columns[6].HeaderText = "Số Trang";
            this.dgvUpdateSach.Columns[7].HeaderText = "Số Lần XB";
            this.dgvUpdateSach.Columns[8].HeaderText = "Số Lượng";
            this.dgvUpdateSach.Columns[9].HeaderText = "Giá Tiền";
            this.dgvUpdateSach.Columns[10].HeaderText = "Vị Trí";
            this.dgvUpdateSach.Columns[11].HeaderText = "Nội Dung";
        }

        private void dgvUpdateSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
            Sach book = context.Saches.Single(s => s.ma.Equals(ma));
            txtMa.Text = book.ma;
            txtTen.Text = book.ten;
            txtTacgia.Text = book.tacgia;
            txtLoaisach.Text = book.loaisach;
            txtNhaxuatban.Text = book.nhaxuatbanma;
            txtNgonngu.Text = book.ngonngu;
            txtSotrang.Text = book.sotrang.ToString();
            txtSolanxuatban.Text = book.solanxuatban.ToString();
            txtSoluong.Text = book.soluong.ToString();
            txtGiatien.Text = book.giatien;
            txtKhoma.Text = book.khoma;
            txtNoidung.Text = book.noidung;
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
                book.ngonngu = this.txtNgonngu.Text;
                //book.namxuatban = this.dtpNamxuatban.Text;
                book.sotrang = int.Parse(txtSotrang.Text);
                book.solanxuatban = int.Parse(txtSolanxuatban.Text);
                book.soluong = int.Parse(txtSoluong.Text);
                book.giatien = this.txtGiatien.Text;
                book.khoma = this.txtKhoma.Text;
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
            try
            {
                String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
                Sach book = context.Saches.Single(s => s.ma.Equals(ma));
                if (this.txtTen.Text.Length != 0)
                    book.ten = this.txtTen.Text;
                if (this.txtTacgia.Text.Length != 0)
                    book.tacgia = this.txtTacgia.Text;
                if (this.txtLoaisach.Text.Length != 0)
                    book.loaisach = this.txtLoaisach.Text;
                if (this.txtNhaxuatban.Text.Length != 0)
                    book.nhaxuatbanma = this.txtNhaxuatban.Text;
                if (this.txtNgonngu.Text.Length != 0)
                    book.ngonngu = this.txtNgonngu.Text;
                // book.namxuatban=this.
                book.sotrang = Int32.Parse(txtSotrang.Text);
                book.solanxuatban = Int32.Parse(txtSolanxuatban.Text);
                book.soluong = Int32.Parse(txtSoluong.Text);
                if (this.txtGiatien.Text.Length != 0)
                    book.giatien = this.txtGiatien.Text;
                book.khoma = this.txtKhoma.Text;
                if (this.txtNoidung.Text.Length != 0)
                    book.noidung = txtNoidung.Text;
                context.SaveChanges();
                FillData();
                MessageBox.Show("Fix Success!!");
            }
            catch
            {
                MessageBox.Show("Fix fail!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLTV f = new frmQLTV();
            f.Show();
            this.Hide();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            QLTVModels context = new QLTVModels();
            var Lst = (from s in context.Saches where s.ma.Contains(txtTimkiem.Text) select s).ToList();
            dgvUpdateSach.DataSource = Lst;
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtTacgia.DataBindings.Clear();
            txtLoaisach.DataBindings.Clear();
            txtNhaxuatban.DataBindings.Clear();
            txtMa.DataBindings.Add("text", Lst, "Ma");
            txtTen.DataBindings.Add("text", Lst, "Ten");
            txtTacgia.DataBindings.Add("text", Lst, "Tacgia");
            txtLoaisach.DataBindings.Add("text", Lst, "Loaisach");
            txtNhaxuatban.DataBindings.Add("text", Lst, "Nhaxuatban");
        }
    }
}
