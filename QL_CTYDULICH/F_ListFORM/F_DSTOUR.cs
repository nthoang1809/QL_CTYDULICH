using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_CTYDULICHBAL;
using QL_CTYDULICHDAL;
using QL_CTYDULICH.F_UpdateFORM;

namespace QL_CTYDULICH.F_ListFORM
{
    public partial class F_DSTOUR : DevExpress.XtraEditors.XtraForm
    {
        CTOUR tour = new CTOUR();
        CPHUONGTIEN pt = new CPHUONGTIEN();
        CNHAHANG nh = new CNHAHANG();
        CKHACHSAN ks = new CKHACHSAN();
        CDIADIEM dd = new CDIADIEM();
        CTAIXE tx = new CTAIXE();
        CXE xe = new CXE();

        public F_DSTOUR()
        {
            InitializeComponent();
        }

        public void loadDaTaSource()
        {
            var data = tour.layDSTOUR();
            gridControl1.DataSource = data;

            lkeNhaHang.DataSource =  nh.layDSNHAHANG();
            lkeNhaHang.ValueMember = "MANH";
            lkeNhaHang.DisplayMember = "TENNH";

            lkeKhachSan.DataSource = ks.layDSKHACHSAN();
            lkeKhachSan.ValueMember = "MAKS";
            lkeKhachSan.DisplayMember = "TENKS";

            lkeDiaDiem.DataSource = dd.layDSDiaDiem();
            lkeDiaDiem.ValueMember = "MADIADIEM";
            lkeDiaDiem.DisplayMember = "TENDIADIEM";

            lkeTX.DataSource = tx.layDSTAIXE();
            lkeTX.ValueMember = "MATX";
            lkeTX.DisplayMember = "TENTX";

            lkeXe.DataSource = xe.layDSXE();
            lkeXe.ValueMember = "MAXE";
            lkeXe.DisplayMember = "TENXE";
        }

        private TOURView getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as TOURView;
        }
        private void F_DSTOUR_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATTOUR(this, data);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không ???","Thông Báo",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                var data = getCurrentData();
                tour.xoaTOUR(data);
                loadDaTaSource();
            }
          
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var form = new F_CAPNHATTOUR(this);
            form.Show();
        }
    }
}
