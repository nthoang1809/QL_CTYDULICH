using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QL_CTYDULICHBAL;
using QL_CTYDULICHDAL;


namespace QL_CTYDULICH
{
    public partial class F_DSNHANVIEN : DevExpress.XtraEditors.XtraForm
    {
        CNHANVIEN nv = new CNHANVIEN();
        CCHUCVU cv = new CCHUCVU();

        public F_DSNHANVIEN()
        {
            InitializeComponent();
        }

        private void F_DSNHANVIEN_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATNHANVIEN(this, data);
            form.Show();
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATNHANVIEN(this);
            form.Show();
        }
        //Load data in gridcontrol before closed Form child
        private NHANVIEN getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as NHANVIEN;
        }
        //Load data in gridcontrol open Form parent
        public void loadDataSource()
        {
            gridControl1.DataSource = nv.layDSNhanVien();


            var data2 = cv.layDSChucVu();
            LookUpEditCHUCVUNV.DataSource = data2;
            LookUpEditCHUCVUNV.ValueMember = "MACV";
            LookUpEditCHUCVUNV.DisplayMember = "TENCV";
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            nv.xoaNhanVien(data);
            loadDataSource();
        }
    }
}