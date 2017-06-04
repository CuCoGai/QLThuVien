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
    public partial class frmUpdateNhanvien : Form
    {
        QLTVModels db = new QLTVModels();
        DataGridView dt;
        public frmUpdateNhanvien()
        {
            InitializeComponent();
            
        }
        
        public frmUpdateNhanvien(DataGridView dgvUpdateNhanvien)
        {
            InitializeComponent();
            dgvUpdateNhanvien = dt;
        }

        private void UpdateNhanvien_Load(object sender, EventArgs e)
        {


            load();
        }
        public void load()
        {
            QLTVModels db = new QLTVModels();
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            cmb_chucvu.Items.Clear();
            cmb_chucvu.Items.Add("Quản lí");
            cmb_chucvu.Items.Add("Tổ trưởng");
            cmb_chucvu.Items.Add("Nhân viên");


            //var list1 = (from s in db.Thuthus select s.chucvu).ToList();
            //cmb_chucvu.DataSource = list1;
            //cmb_chucvu.DisplayMember = "chucvu";
            //var list = (from s in db.Thuthus select s).ToList();
            //dgvUpdateNhanvien.DataSource = list;
            dgvUpdateNhanvien.DataSource = db.Thuthus.Where(d => d.status == null).Select(d => new
            {
                ID = d.ma,
                Name = d.ten,
                Email = d.email,
                Gender = d.gioitinh == true ? "Nam" : "Nữ",
                Add = d.diachi,
                Tendn = d.tendangnhap,
                Pass = d.matkhau,
                SDT = d.sodienthoai,
                Chucvu = d.chucvu
            }).ToList();
        dgvUpdateNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvUpdateNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvUpdateNhanvien.Columns[2].HeaderText = "Email";
            dgvUpdateNhanvien.Columns[3].HeaderText = "Giới Tính";
            dgvUpdateNhanvien.Columns[4].HeaderText = "Địa chỉ";
            dgvUpdateNhanvien.Columns[5].HeaderText = "Tên đăng nhập";
            dgvUpdateNhanvien.Columns[6].HeaderText = "Mật khẩu";
            dgvUpdateNhanvien.Columns[7].HeaderText = "SĐT";
        }

        private void lbTen_Click(object sender, EventArgs e)
        {

        }

        private void lbGioitinh_Click(object sender, EventArgs e)
        {

        }

        private void dgvUpdateNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvUpdateNhanvien.CurrentRow.Cells[0].Value.ToString();
            Thuthu tt = db.Thuthus.SingleOrDefault(s => s.ma == id);
            txtMa.Text = tt.ma;
            txtTen.Text = tt.ten;
            txtDiachi.Text = tt.diachi;
            if (tt.gioitinh.Value == false)
            {
                cmb_gioitinh.Text = "Nữ";
            }
            else
            {
                cmb_gioitinh.Text = "Nam";
            }
            txt_email.Text = tt.email;
            txtTendn.Text = tt.tendangnhap;
            txtPass.Text = tt.matkhau;
            txtSdt.Text = tt.sodienthoai;
            cmb_chucvu.Text = tt.chucvu;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_themnv fr = new frm_themnv();
            fr.Show();
            Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = dgvUpdateNhanvien.CurrentRow.Cells[0].Value.ToString();
          Sưa_NV fr = new Sưa_NV(id);
           fr.Show(this);
            Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUpdateNhanvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn dữ liệu để xóa!", "Thông báo");
                return;
            }
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                string id = dgvUpdateNhanvien.CurrentRow.Cells[0].Value.ToString();
               Thuthu tt = db.Thuthus.Single(s => s.ma == id);
                tt.status = 0;
                db.SaveChanges();
                load();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLTV fr = new frmQLTV();
            fr.Show();
            Hide();
        }
    }
}
