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
    public partial class frmUpdateDocgia : Form
    {
        public frmUpdateDocgia()
        {
            InitializeComponent();
        }

        ModelQLTV db = new ModelQLTV();

        void LoaddataDG()
        {
            this.dgvUpdateDocgia.DataSource = db.Docgias.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Docgia dg = new Docgia();
                dg.hoten = txtTen.Text;
                dg.sothe = txtMa.Text;
                if (comboBox1.Text == "Nam")
                {
                    dg.gioitinh = false;
                }
                else dg.gioitinh = true;
                dg.ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
                dg.donvi = txtDonvi.Text;
                dg.chucvu = txtChucvu.Text;
                dg.ngaycapthe = DateTime.Parse(dateTimePicker1.Text);
                dg.hanthe = DateTime.Parse(dateTimePicker2.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại !");
            }
            LoaddataDG();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(this.dgvUpdateDocgia.CurrentRow.Cells[0].Value.ToString());
            Docgia dt = db.Docgias.Single(s => s.sothe.Equals(ma));
            if (this.txtMa.Text.Length != 0)
                dt.sothe = txtMa.Text;
            if (this.txtTen.Text.Length != 0)
                dt.hoten = this.txtTen.Text;
            if (this.txtChucvu.Text.Length != 0)
                dt.chucvu = this.txtChucvu.Text;
            if (this.txtDonvi.Text.Length != 0)
                dt.donvi = this.txtDonvi.Text;
            dt.ngaycapthe = DateTime.Parse(dateTimePicker1.Text);
            dt.ngaysinh = DateTime.Parse(dtpNgaysinh.Text);
            dt.hanthe = DateTime.Parse(dateTimePicker2.Text);

            db.SaveChanges();
            MessageBox.Show("Sửa thành công");
            LoaddataDG();
        }

        void Save()
        {
            DialogResult dlr = MessageBox.Show("Lưu tất cả thay đổi?",
                            "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                db.SaveChanges();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(this.dgvUpdateDocgia.CurrentRow.Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {

                Docgia gv = db.Docgias.Single(s => s.sothe.Equals(ma));
                db.Docgias.Remove(gv);
                Save();
            }
            LoaddataDG();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Save();
            LoaddataDG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTV f = new frmQLTV();
            f.Show();
        }

        private void dgvUpdateDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvUpdateDocgia.CurrentRow.Cells["sothe"].Value.ToString();
            txtTen.Text = dgvUpdateDocgia.CurrentRow.Cells["hoten"].Value.ToString();
            txtChucvu.Text = dgvUpdateDocgia.CurrentRow.Cells["chucvu"].Value.ToString();
            txtDonvi.Text = dgvUpdateDocgia.CurrentRow.Cells["donvi"].Value.ToString();
            dtpNgaysinh.Text= dgvUpdateDocgia.CurrentRow.Cells["ngaysinh"].Value.ToString();
            dateTimePicker1.Text = dgvUpdateDocgia.CurrentRow.Cells["ngaycapthe"].Value.ToString();
            dateTimePicker2.Text = dgvUpdateDocgia.CurrentRow.Cells["hanthe"].Value.ToString();
            if (bool.Parse(dgvUpdateDocgia.CurrentRow.Cells["GioiTinh"].Value.ToString()) == false)
            {
                comboBox1.SelectedItem = "Nam";
            }
            else comboBox1.SelectedItem = "Nữ";





        }

        private void frmUpdateDocgia_Load(object sender, EventArgs e)
        {
            LoaddataDG();
        }
    }
}
