namespace QLTV
{
    partial class frmUpdateNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvUpdateNhanvien = new System.Windows.Forms.DataGridView();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTendn = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.grb_thongtinhanvien = new System.Windows.Forms.GroupBox();
            this.cmb_chucvu = new System.Windows.Forms.ComboBox();
            this.cmb_gioitinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateNhanvien)).BeginInit();
            this.grb_thongtinhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 32);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(265, 423);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 32);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(151, 423);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 32);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 423);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 32);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvUpdateNhanvien
            // 
            this.dgvUpdateNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateNhanvien.Location = new System.Drawing.Point(12, 207);
            this.dgvUpdateNhanvien.Name = "dgvUpdateNhanvien";
            this.dgvUpdateNhanvien.Size = new System.Drawing.Size(619, 157);
            this.dgvUpdateNhanvien.TabIndex = 42;
            this.dgvUpdateNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateNhanvien_CellContentClick);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(71, 80);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(181, 20);
            this.dtpNgaysinh.TabIndex = 41;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(362, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(193, 20);
            this.txtPass.TabIndex = 40;
            // 
            // txtTendn
            // 
            this.txtTendn.Location = new System.Drawing.Point(362, 78);
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.ReadOnly = true;
            this.txtTendn.Size = new System.Drawing.Size(193, 20);
            this.txtTendn.TabIndex = 37;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(71, 140);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Size = new System.Drawing.Size(181, 20);
            this.txtSdt.TabIndex = 36;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(362, 15);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(193, 20);
            this.txt_email.TabIndex = 35;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(71, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(181, 20);
            this.txtTen.TabIndex = 34;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(71, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(181, 20);
            this.txtMa.TabIndex = 33;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(282, 113);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(56, 13);
            this.lbPass.TabIndex = 32;
            this.lbPass.Text = "PassWord";
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(6, 113);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioitinh.TabIndex = 31;
            this.lbGioitinh.Text = "Giới tính";
            this.lbGioitinh.Click += new System.EventHandler(this.lbGioitinh_Click);
            // 
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Location = new System.Drawing.Point(282, 80);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(45, 13);
            this.lbTenDN.TabIndex = 30;
            this.lbTenDN.Text = "Tên ĐN";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Location = new System.Drawing.Point(282, 47);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(47, 13);
            this.lbChucvu.TabIndex = 29;
            this.lbChucvu.Text = "Chức vụ";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(6, 140);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(29, 13);
            this.lbSdt.TabIndex = 28;
            this.lbSdt.Text = "SĐT";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(282, 17);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 27;
            this.lbl_email.Text = "Email";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(6, 80);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaysinh.TabIndex = 26;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(6, 47);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(26, 13);
            this.lbTen.TabIndex = 25;
            this.lbTen.Text = "Tên";
            this.lbTen.Click += new System.EventHandler(this.lbTen_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(6, 18);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(22, 13);
            this.lbMa.TabIndex = 24;
            this.lbMa.Text = "Mã";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(362, 140);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.ReadOnly = true;
            this.txtDiachi.Size = new System.Drawing.Size(193, 20);
            this.txtDiachi.TabIndex = 49;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(282, 140);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(40, 13);
            this.lbDiachi.TabIndex = 48;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // grb_thongtinhanvien
            // 
            this.grb_thongtinhanvien.Controls.Add(this.cmb_chucvu);
            this.grb_thongtinhanvien.Controls.Add(this.cmb_gioitinh);
            this.grb_thongtinhanvien.Controls.Add(this.txtMa);
            this.grb_thongtinhanvien.Controls.Add(this.txtDiachi);
            this.grb_thongtinhanvien.Controls.Add(this.lbMa);
            this.grb_thongtinhanvien.Controls.Add(this.lbDiachi);
            this.grb_thongtinhanvien.Controls.Add(this.lbTen);
            this.grb_thongtinhanvien.Controls.Add(this.txtTen);
            this.grb_thongtinhanvien.Controls.Add(this.lbNgaysinh);
            this.grb_thongtinhanvien.Controls.Add(this.dtpNgaysinh);
            this.grb_thongtinhanvien.Controls.Add(this.lbGioitinh);
            this.grb_thongtinhanvien.Controls.Add(this.txtPass);
            this.grb_thongtinhanvien.Controls.Add(this.txtTendn);
            this.grb_thongtinhanvien.Controls.Add(this.lbSdt);
            this.grb_thongtinhanvien.Controls.Add(this.txtSdt);
            this.grb_thongtinhanvien.Controls.Add(this.lbl_email);
            this.grb_thongtinhanvien.Controls.Add(this.txt_email);
            this.grb_thongtinhanvien.Controls.Add(this.lbPass);
            this.grb_thongtinhanvien.Controls.Add(this.lbChucvu);
            this.grb_thongtinhanvien.Controls.Add(this.lbTenDN);
            this.grb_thongtinhanvien.Location = new System.Drawing.Point(12, 8);
            this.grb_thongtinhanvien.Name = "grb_thongtinhanvien";
            this.grb_thongtinhanvien.Size = new System.Drawing.Size(619, 193);
            this.grb_thongtinhanvien.TabIndex = 50;
            this.grb_thongtinhanvien.TabStop = false;
            this.grb_thongtinhanvien.Text = "Thông tin nhân viên";
            // 
            // cmb_chucvu
            // 
            this.cmb_chucvu.FormattingEnabled = true;
            this.cmb_chucvu.Location = new System.Drawing.Point(362, 44);
            this.cmb_chucvu.Name = "cmb_chucvu";
            this.cmb_chucvu.Size = new System.Drawing.Size(193, 21);
            this.cmb_chucvu.TabIndex = 51;
            // 
            // cmb_gioitinh
            // 
            this.cmb_gioitinh.FormattingEnabled = true;
            this.cmb_gioitinh.Location = new System.Drawing.Point(71, 110);
            this.cmb_gioitinh.Name = "cmb_gioitinh";
            this.cmb_gioitinh.Size = new System.Drawing.Size(121, 21);
            this.cmb_gioitinh.TabIndex = 50;
            // 
            // frmUpdateNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 473);
            this.Controls.Add(this.grb_thongtinhanvien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvUpdateNhanvien);
            this.Name = "frmUpdateNhanvien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.UpdateNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateNhanvien)).EndInit();
            this.grb_thongtinhanvien.ResumeLayout(false);
            this.grb_thongtinhanvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvUpdateNhanvien;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTendn;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Label lbChucvu;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.GroupBox grb_thongtinhanvien;
        private System.Windows.Forms.ComboBox cmb_gioitinh;
        private System.Windows.Forms.ComboBox cmb_chucvu;
    }
}