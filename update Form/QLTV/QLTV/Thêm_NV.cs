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
    public partial class frm_themnv : Form
    {
        ModelQLTV db = new ModelQLTV();
        public frm_themnv()
        {
            InitializeComponent();
        }

        private void frm_themnv_Load(object sender, EventArgs e)
        {
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

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ModelQLTV db = new ModelQLTV();
            Thuthu tt = new Thuthu();
            tt.ma = txtMa.Text;
            tt.ten = txtTen.Text;
            Boolean gioiTinh = false;
            if (cmb_gioitinh.Text == "Nam")
            {
                gioiTinh = true;
            }
            tt.gioitinh = gioiTinh;
             tt.diachi = txtDiachi.Text;
            tt.email = txt_email.Text;
            tt.tendangnhap = txtTendn.Text;
            tt.matkhau = txtPass.Text;
            tt.sodienthoai = txtSdt.Text;
            tt.chucvu = cmb_chucvu.Text;
            db.Thuthus.Add(tt);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hhh" + ex);
            }
            frmUpdateNhanvien fr = new frmUpdateNhanvien();
            fr.Show(this);
            Hide();
            fr.load();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frmUpdateNhanvien fr = new frmUpdateNhanvien();
            fr.Show();
            Hide();
        }
    }
    }

