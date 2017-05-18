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
        public frmUpdateNhanvien()
        {
            InitializeComponent();
        }

        private void UpdateNhanvien_Load(object sender, EventArgs e)
        {
            ModelQLTV context = new ModelQLTV();
            var query = context.Thuthus;  //context.table
            dgvUpdateNhanvien.DataSource = query.ToList();
        }
    }
}
