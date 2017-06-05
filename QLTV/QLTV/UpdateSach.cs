
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
    public partial class UpdateSach : Form
    {
        TVEnti context = new TVEnti();
        public UpdateSach()
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
            cmbLoaiSach.Items.Clear();
            cmbLoaiSach.Items.Add("SGK");
            cmbLoaiSach.Items.Add("SBT");
            cmbLoaiSach.Items.Add("Tham Khảo");
            cmbLoaiSach.Items.Add("Slide");

            cmbNhaxuatban.DataSource = context.Nhaxuatbans.ToList();
            cmbNhaxuatban.ValueMember = "ma";
            cmbNhaxuatban.DisplayMember = "ten";

            cmbVitri.DataSource = context.Khosaches.ToList();
            cmbVitri.ValueMember = "ma";
            cmbVitri.DisplayMember = "ten";
            dgvUpdateSach.DataSource = context.Saches.Select(c=>new {
               Ma=c.ma,
               ten=c.ten,
               Tacgia=c.tacgia,
               Loaisach=c.loaisach,
               Nhaxuatban=c.nhaxuatbanma,
               Ngonngu=c.ngonngu,
               Sotrang=c.sotrang,
               Solanxb=c.solanxuatban,
               Soluong=c.soluong,
               Giatien=c.giatien,
               Vitri=c.khoma,
               Noidung=c.noidung
            }).ToList();
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
       

        private void dgvUpdateSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
            Sach book = context.Saches.Single(s => s.ma.Equals(ma));
            txtMa.Text = book.ma;
            txtTen.Text = book.ten;
            txtTacgia.Text = book.tacgia;
            cmbLoaiSach.Text = book.loaisach;
            cmbNhaxuatban.SelectedItem = book.nhaxuatbanma;
            txtNgonNgu.Text = book.ngonngu;
            txtSotrang.Text = book.sotrang.ToString();
            txtSolanxb.Text = book.solanxuatban.ToString();
            txtSoluong.Text = book.soluong.ToString();
            txtGiaTien.Text = book.giatien;
            cmbVitri.SelectedItem = book.khoma;
            txtNoidung.Text = book.noidung;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Sach book = new Sach();
                book.ma = txtMa.Text;
                book.ten = txtTen.Text;
                book.tacgia = txtTacgia.Text;
                book.loaisach = cmbLoaiSach.Text;
                book.nhaxuatbanma = cmbNhaxuatban.Text;
                book.ngonngu = txtNgonNgu.Text;
                //book.namxuatban = this.dtpNamxuatban.Text;
                book.sotrang = int.Parse(txtSotrang.Text);
                book.solanxuatban = int.Parse(txtSolanxb.Text);
                book.soluong = int.Parse(txtSoluong.Text);
                book.giatien = txtGiaTien.Text;
                book.khoma = cmbVitri.Text;
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            try
            {
                String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
                Sach book = context.Saches.FirstOrDefault(s => s.ma==ma);
                if (this.txtTen.Text.Length != 0)
                    book.ten = this.txtTen.Text;
                if (this.txtTacgia.Text.Length != 0)
                    book.tacgia = this.txtTacgia.Text;
                if (this.cmbLoaiSach.Text.Length != 0)
                    book.loaisach = this.cmbLoaiSach.Text;
                if (this.cmbNhaxuatban.Text.Length != 0)
                    book.nhaxuatbanma = this.cmbNhaxuatban.Text;
                if (this.txtNgonNgu.Text.Length != 0)
                    book.ngonngu = this.txtNgonNgu.Text;
                // book.namxuatban=this.
                book.sotrang = Int32.Parse(txtSotrang.Text);
                book.solanxuatban = Int32.Parse(txtSolanxb.Text);
                book.soluong = Int32.Parse(txtSoluong.Text);
                if (this.txtGiaTien.Text.Length != 0)
                    book.giatien = this.txtGiaTien.Text;
                book.khoma = this.cmbVitri.Text;
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    String ma = this.dgvUpdateSach.CurrentRow.Cells[0].Value.ToString();
                    Sach book = context.Saches.FirstOrDefault(s => s.ma.Equals(ma));
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            FormQLTV f = new FormQLTV();
            f.Show();
            this.Hide();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            TVEnti context = new TVEnti();
            var Lst = (from s in context.Saches where s.ma.Contains(txtTimKiem.Text) select s).ToList();
            dgvUpdateSach.DataSource = Lst;
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtTacgia.DataBindings.Clear();
            cmbLoaiSach.DataBindings.Clear();
            cmbNhaxuatban.DataBindings.Clear();
            txtMa.DataBindings.Add("text", Lst, "Ma");
            txtTen.DataBindings.Add("text", Lst, "Ten");
            txtTacgia.DataBindings.Add("text", Lst, "Tacgia");
            cmbLoaiSach.DataBindings.Add("text", Lst, "Loaisach");
            cmbNhaxuatban.DataBindings.Add("text", Lst, "Nhaxuatban");
        }
    }
}

