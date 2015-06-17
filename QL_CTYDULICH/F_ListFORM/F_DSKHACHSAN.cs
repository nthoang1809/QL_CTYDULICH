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
    public partial class F_DSKHACHSAN : DevExpress.XtraEditors.XtraForm
    {
        CKHACHSAN ks = new CKHACHSAN();
        public F_DSKHACHSAN()
        {
            InitializeComponent();
        }

        public void loadDaTaSource()
        {
            var data = ks.layDSKHACHSAN();
            gridControl1.DataSource = data;

            CDIADIEM dd = new CDIADIEM();
            lkeDiaDiem.DataSource = dd.layDSDiaDiem();
            lkeDiaDiem.ValueMember = "MADIADIEM";
            lkeDiaDiem.DisplayMember = "TENDIADIEM";
        }

        private KHACHSAN getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as KHACHSAN;
        }

        private void F_DSKHACHSAN_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATKHACHSAN(this);
            form.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATKHACHSAN(this, data);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var data = getCurrentData();
                ks.xoaKHACHSAN(data);
                loadDaTaSource();
            }
        }
    }
}
  

