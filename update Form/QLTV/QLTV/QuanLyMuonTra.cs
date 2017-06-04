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
    public partial class frmQuanLyMuonTra : Form
    {
        QLTVModels context = new QLTVModels();

        public frmQuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void frmQuanLyMuonTra_Load(object sender, EventArgs e)
        {

        }
        public 
        private void tabTraSach_Click(object sender, EventArgs e)
        {
            this.dgvTraSach.DataSource = context.Muontras.Select(m => new
            {
                Sachma = m.sachma,
                Sothema = m.sothema,
                Ngaymuon = m.ngaymuon,
                Ngaytra = m.ngaytra,
                Ngayhentra = m.ngayphaitra,
                Soluongtra = m.soluongtra,
                Tinhtrangtra = m.tinhtrangtra
            }).ToList();
            this.dgvTraSach.Columns[0].HeaderText = "Mã Độc Giả";
            this.dgvTraSach.Columns[1].HeaderText = "Mã Sách";
            this.dgvTraSach.Columns[2].HeaderText = "Ngày Mượn";
            this.dgvTraSach.Columns[3].HeaderText = "Ngày Trả";
            this.dgvTraSach.Columns[4].HeaderText = "Ngày Hẹn Trả";
            this.dgvTraSach.Columns[5].HeaderText = "Số Lượng Trả";
            this.dgvTraSach.Columns[6].HeaderText = "Tình Trạng Trả";
        }
    }
}
