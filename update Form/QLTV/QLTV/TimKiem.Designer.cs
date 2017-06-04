namespace QLTV
{
    partial class frmTimKiem
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
            this.tcrTimKiem = new System.Windows.Forms.TabControl();
            this.tpTKdocgia = new System.Windows.Forms.TabPage();
            this.dgvTKDG = new System.Windows.Forms.DataGridView();
            this.txtTKDG = new System.Windows.Forms.TextBox();
            this.btnTKDG = new System.Windows.Forms.Button();
            this.tpTKSach = new System.Windows.Forms.TabPage();
            this.dgvTKS = new System.Windows.Forms.DataGridView();
            this.txtTKS = new System.Windows.Forms.TextBox();
            this.btnTKS = new System.Windows.Forms.Button();
            this.tpTKtacgia = new System.Windows.Forms.TabPage();
            this.dgvTKTG = new System.Windows.Forms.DataGridView();
            this.txtTKTG = new System.Windows.Forms.TextBox();
            this.btnTKTG = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tcrTimKiem.SuspendLayout();
            this.tpTKdocgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).BeginInit();
            this.tpTKSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKS)).BeginInit();
            this.tpTKtacgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKTG)).BeginInit();
            this.SuspendLayout();
            // 
            // tcrTimKiem
            // 
            this.tcrTimKiem.Controls.Add(this.tpTKdocgia);
            this.tcrTimKiem.Controls.Add(this.tpTKSach);
            this.tcrTimKiem.Controls.Add(this.tpTKtacgia);
            this.tcrTimKiem.Location = new System.Drawing.Point(2, 1);
            this.tcrTimKiem.Name = "tcrTimKiem";
            this.tcrTimKiem.SelectedIndex = 0;
            this.tcrTimKiem.Size = new System.Drawing.Size(878, 366);
            this.tcrTimKiem.TabIndex = 0;
            // 
            // tpTKdocgia
            // 
            this.tpTKdocgia.Controls.Add(this.dgvTKDG);
            this.tpTKdocgia.Controls.Add(this.txtTKDG);
            this.tpTKdocgia.Controls.Add(this.btnTKDG);
            this.tpTKdocgia.Location = new System.Drawing.Point(4, 22);
            this.tpTKdocgia.Name = "tpTKdocgia";
            this.tpTKdocgia.Padding = new System.Windows.Forms.Padding(3);
            this.tpTKdocgia.Size = new System.Drawing.Size(870, 340);
            this.tpTKdocgia.TabIndex = 0;
            this.tpTKdocgia.Text = "Tìm Kiếm Độc Giả";
            this.tpTKdocgia.UseVisualStyleBackColor = true;
            // 
            // dgvTKDG
            // 
            this.dgvTKDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDG.Location = new System.Drawing.Point(3, 80);
            this.dgvTKDG.Name = "dgvTKDG";
            this.dgvTKDG.Size = new System.Drawing.Size(862, 245);
            this.dgvTKDG.TabIndex = 2;
            // 
            // txtTKDG
            // 
            this.txtTKDG.Location = new System.Drawing.Point(66, 24);
            this.txtTKDG.Name = "txtTKDG";
            this.txtTKDG.Size = new System.Drawing.Size(547, 20);
            this.txtTKDG.TabIndex = 1;
            this.txtTKDG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTKDG_MouseClick);
            this.txtTKDG.TextChanged += new System.EventHandler(this.txtTKDG_TextChanged);
            // 
            // btnTKDG
            // 
            this.btnTKDG.Location = new System.Drawing.Point(657, 15);
            this.btnTKDG.Name = "btnTKDG";
            this.btnTKDG.Size = new System.Drawing.Size(102, 37);
            this.btnTKDG.TabIndex = 0;
            this.btnTKDG.Text = "Tìm Kiếm";
            this.btnTKDG.UseVisualStyleBackColor = true;
            this.btnTKDG.Click += new System.EventHandler(this.btnTKDG_Click);
            // 
            // tpTKSach
            // 
            this.tpTKSach.Controls.Add(this.dgvTKS);
            this.tpTKSach.Controls.Add(this.txtTKS);
            this.tpTKSach.Controls.Add(this.btnTKS);
            this.tpTKSach.Location = new System.Drawing.Point(4, 22);
            this.tpTKSach.Name = "tpTKSach";
            this.tpTKSach.Padding = new System.Windows.Forms.Padding(3);
            this.tpTKSach.Size = new System.Drawing.Size(870, 340);
            this.tpTKSach.TabIndex = 1;
            this.tpTKSach.Text = "Tìm Kiếm Sách";
            this.tpTKSach.UseVisualStyleBackColor = true;
            // 
            // dgvTKS
            // 
            this.dgvTKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKS.Location = new System.Drawing.Point(4, 80);
            this.dgvTKS.Name = "dgvTKS";
            this.dgvTKS.Size = new System.Drawing.Size(862, 245);
            this.dgvTKS.TabIndex = 5;
            // 
            // txtTKS
            // 
            this.txtTKS.Location = new System.Drawing.Point(75, 24);
            this.txtTKS.Name = "txtTKS";
            this.txtTKS.Size = new System.Drawing.Size(547, 20);
            this.txtTKS.TabIndex = 4;
            // 
            // btnTKS
            // 
            this.btnTKS.Location = new System.Drawing.Point(666, 15);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(102, 37);
            this.btnTKS.TabIndex = 3;
            this.btnTKS.Text = "Tìm Kiếm";
            this.btnTKS.UseVisualStyleBackColor = true;
            this.btnTKS.Click += new System.EventHandler(this.btnTKS_Click);
            // 
            // tpTKtacgia
            // 
            this.tpTKtacgia.Controls.Add(this.dgvTKTG);
            this.tpTKtacgia.Controls.Add(this.txtTKTG);
            this.tpTKtacgia.Controls.Add(this.btnTKTG);
            this.tpTKtacgia.Location = new System.Drawing.Point(4, 22);
            this.tpTKtacgia.Name = "tpTKtacgia";
            this.tpTKtacgia.Padding = new System.Windows.Forms.Padding(3);
            this.tpTKtacgia.Size = new System.Drawing.Size(870, 340);
            this.tpTKtacgia.TabIndex = 2;
            this.tpTKtacgia.Text = "Tìm Kiếm Tác Giả";
            this.tpTKtacgia.UseVisualStyleBackColor = true;
            // 
            // dgvTKTG
            // 
            this.dgvTKTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKTG.Location = new System.Drawing.Point(4, 80);
            this.dgvTKTG.Name = "dgvTKTG";
            this.dgvTKTG.Size = new System.Drawing.Size(862, 245);
            this.dgvTKTG.TabIndex = 5;
            // 
            // txtTKTG
            // 
            this.txtTKTG.Location = new System.Drawing.Point(69, 24);
            this.txtTKTG.Name = "txtTKTG";
            this.txtTKTG.Size = new System.Drawing.Size(547, 20);
            this.txtTKTG.TabIndex = 4;
            // 
            // btnTKTG
            // 
            this.btnTKTG.Location = new System.Drawing.Point(670, 15);
            this.btnTKTG.Name = "btnTKTG";
            this.btnTKTG.Size = new System.Drawing.Size(102, 37);
            this.btnTKTG.TabIndex = 3;
            this.btnTKTG.Text = "Tìm Kiếm";
            this.btnTKTG.UseVisualStyleBackColor = true;
            this.btnTKTG.Click += new System.EventHandler(this.btnTKTG_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(717, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 424);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tcrTimKiem);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            this.tcrTimKiem.ResumeLayout(false);
            this.tpTKdocgia.ResumeLayout(false);
            this.tpTKdocgia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDG)).EndInit();
            this.tpTKSach.ResumeLayout(false);
            this.tpTKSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKS)).EndInit();
            this.tpTKtacgia.ResumeLayout(false);
            this.tpTKtacgia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcrTimKiem;
        private System.Windows.Forms.TabPage tpTKdocgia;
        private System.Windows.Forms.TabPage tpTKSach;
        private System.Windows.Forms.TabPage tpTKtacgia;
        private System.Windows.Forms.DataGridView dgvTKDG;
        private System.Windows.Forms.TextBox txtTKDG;
        private System.Windows.Forms.Button btnTKDG;
        private System.Windows.Forms.DataGridView dgvTKS;
        private System.Windows.Forms.TextBox txtTKS;
        private System.Windows.Forms.Button btnTKS;
        private System.Windows.Forms.DataGridView dgvTKTG;
        private System.Windows.Forms.TextBox txtTKTG;
        private System.Windows.Forms.Button btnTKTG;
        private System.Windows.Forms.Button btnThoat;
    }
}