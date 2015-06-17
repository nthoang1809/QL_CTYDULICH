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
    public partial class F_DSKHACHHANG : DevExpress.XtraEditors.XtraForm
    {
        CKHACHHANG da = new CKHACHHANG();
        CCHUCVU cv = new CCHUCVU();
        public F_DSKHACHHANG()
        {
            InitializeComponent();
        }

        public void loadDataSource()
        {
            var data = da.layDSKhachHang();
            gridControl1.DataSource = data;
        }

        private KHACHHANG getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as KHACHHANG;
        }

        private void F_DSKHACHHANG_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void btnsuakh_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATKHACHHANG(this, data);
            form.Show();
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATKHACHHANG(this);
            form.Show();
        }

        private void btnxoakh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var data = getCurrentData();
                da.xoaKhachHang(data);
                loadDataSource();
            }
        }
    }
}