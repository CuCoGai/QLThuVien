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
   
    public partial class Sưa_NV : Form
    {
        ModelQLTV db = new ModelQLTV();
        public Sưa_NV()
        {
            InitializeComponent();
        }

        private void Sưa_NV_Load(object sender, EventArgs e)
        {
            load();
        }
        public Sưa_NV(string id)
        {
            InitializeComponent();
            Thuthu nv = db.Thuthus.Single(s => s.ma == id);
            txtMa.Text = nv.ma;
            txtTen.Text = nv.ten;
            txtDiachi.Text = nv.diachi;
            if (nv.gioitinh.Value == false)
            {
                cmb_gioitinh.Text = "Nữ";
            }
            else
            {
                cmb_gioitinh.Text = "Nam";
            }
            txt_email.Text = nv.email;
            txtTendn.Text = nv.tendangnhap;
            txtPass.Text = nv.matkhau;
            txtSdt.Text = nv.sodienthoai;
            cmb_chucvu.Text = nv.chucvu;
        }
        public void load()
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


        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            var nv = db.Thuthus.FirstOrDefault(x => x.ma ==txtMa.Text);
       
            nv.ma = txtMa.Text;
            nv.ten = txtTen.Text;

            Boolean gioiTinh = false;
            if (cmb_gioitinh.Text == "Nam")
            {
                gioiTinh = true;
            }
            nv.gioitinh = gioiTinh;
            nv.email = txt_email.Text;
            nv.diachi = txtDiachi.Text;
            nv.tendangnhap = txtTendn.Text;
            nv.matkhau = txtPass.Text;
            nv.sodienthoai = txtSdt.Text;
            nv.chucvu = cmb_chucvu.Text;
            db.SaveChanges();
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
