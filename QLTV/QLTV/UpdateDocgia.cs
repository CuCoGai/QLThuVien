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
    public partial class UpdateDocGia : Form
    {
        TVEnti context = new TVEnti();
        public UpdateDocGia()
        {
            InitializeComponent();
        }

        private void UpdateDocGia_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public void FillData()
        {
            cmbGioitinh.Items.Clear();
            cmbGioitinh.Items.Add("Nam");
            cmbGioitinh.Items.Add("Nữ");

            dgvDocGia.DataSource = context.Docgias.Select(d => new {
                Ma = d.sothe,
                Ten = d.hoten,
                ngaysinh = d.ngaysinh,
                gioitinh = d.gioitinh,
                email = d.email,
                donvi=d.donvi,
                chucvu=d.chucvu,
                ngaycapthe=d.ngaycapthe,
                hanthe=d.hanthe

            }).ToList();
            this.dgvDocGia.Columns[0].HeaderText = "Số thẻ";
            this.dgvDocGia.Columns[1].HeaderText = "Họ tên";
            this.dgvDocGia.Columns[2].HeaderText = "Ngày sinh";
            this.dgvDocGia.Columns[3].HeaderText = "Giới tính";
            this.dgvDocGia.Columns[4].HeaderText = "Email";
            this.dgvDocGia.Columns[5].HeaderText = "Đơn vị";
            this.dgvDocGia.Columns[6].HeaderText = "Chức vụ";
            this.dgvDocGia.Columns[7].HeaderText = "Ngày cấp thẻ";
            this.dgvDocGia.Columns[8].HeaderText = "Hạn thẻ";
           
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            Docgia dg = context.Docgias.FirstOrDefault(s => s.sothe.Equals(ma));
            txtSothe.Text = dg.sothe;
            txtTen.Text = dg.hoten;
            dtpNgaySinh.Text = dg.ngaysinh.Value.ToString();
            if (dg.gioitinh.Value == false)
            {
                cmbGioitinh.Text = "Nữ";
            }
            else
            {
                cmbGioitinh.Text = "Nam";
            }
            txtEmail.Text = dg.email;
            txtDonvi.Text = dg.donvi;
            txtChucvu.Text = dg.chucvu;
            dtpNgaycapthe.Text = dg.ngaycapthe.Value.ToString();
            dtpHanthe.Text = dg.hanthe.Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Docgia dg = new Docgia();
                dg.sothe = txtSothe.Text;
                dg.hoten = txtTen.Text;
                dg.ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                Boolean gioiTinh = false;
                if (cmbGioitinh.Text == "Nam")
                {
                    dg.gioitinh = true;
                }
                dg.gioitinh = gioiTinh;
                dg.email = txtEmail.Text;
                dg.donvi = txtDonvi.Text;
                dg.chucvu = txtChucvu.Text;
                dg.ngaycapthe = DateTime.Parse(dtpNgaycapthe.Text);
                dg.hanthe = DateTime.Parse(dtpHanthe.Text);
                context.Docgias.Add(dg);
                context.SaveChanges();
                FillData();
                MessageBox.Show("Seccess!!");
            }
            catch
            {
                MessageBox.Show("Fail!!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = this.dgvDocGia.CurrentRow.Cells[0].Value.ToString();
                Docgia dg = context.Docgias.FirstOrDefault(s => s.sothe == ma);
                if (this.txtTen.Text.Length != 0)
                    dg.hoten = this.txtTen.Text;
                dg.ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                Boolean gioiTinh = false;
                if (cmbGioitinh.Text == "Nam")
                {
                    dg.gioitinh = true;
                }
                dg.gioitinh = gioiTinh;
                dg.email = txtEmail.Text;
                dg.donvi = txtDonvi.Text;
                dg.chucvu = txtChucvu.Text;
                dg.ngaycapthe = DateTime.Parse(dtpNgaycapthe.Text);
                dg.hanthe = DateTime.Parse(dtpHanthe.Text);
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
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    String ma = this.dgvDocGia.CurrentRow.Cells[0].Value.ToString();
                    Docgia dg = context.Docgias.FirstOrDefault(s => s.sothe==ma);
                    context.Docgias.Remove(dg);
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
            FormQLTV f = new FormQLTV();
            f.Show();
            Hide();
        }

        private void txtTKDG_TextChanged(object sender, EventArgs e)
        {
            TVEnti context = new TVEnti();
            var Lst = (from s in context.Docgias where s.sothe.Contains(txtTKDG.Text) select s).ToList();
            dgvDocGia.DataSource = Lst;
            txtSothe.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDonvi.DataBindings.Clear();
            txtChucvu.DataBindings.Clear();
            txtSothe.DataBindings.Add("text", Lst, "Sothe");
            txtTen.DataBindings.Add("text", Lst, "Ten");
            txtEmail.DataBindings.Add("text", Lst, "Email");
            txtDonvi.DataBindings.Add("text", Lst, "DonVi");
            txtChucvu.DataBindings.Add("text", Lst, "ChucVu");
        }
    }
}
