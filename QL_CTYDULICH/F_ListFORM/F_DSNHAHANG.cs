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
    public partial class F_DSNHAHANG : DevExpress.XtraEditors.XtraForm
    {
        CNHAHANG nh = new CNHAHANG();
        CDIADIEM dd = new CDIADIEM();
        public F_DSNHAHANG()
        {
            InitializeComponent();
        }

        public void loadDaTaSource()
        {
            var data = nh.layDSNHAHANG();
            gridControl1.DataSource = data;

            var data1 = dd.layDSDiaDiem();
            lkeDiaDiem.DataSource = data1;
            lkeDiaDiem.ValueMember = "MADIADIEM";
            lkeDiaDiem.DisplayMember = "TENDIADIEM";
        }

        private NHAHANG getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as NHAHANG;
        }

        private void F_DSNHAHANG_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATNHAHANG(this);
            form.Show();
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATNHAHANG(this, data);
            form.Show();
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            nh.xoaNHAHANG(data);
            loadDaTaSource();
        }
    }
}
