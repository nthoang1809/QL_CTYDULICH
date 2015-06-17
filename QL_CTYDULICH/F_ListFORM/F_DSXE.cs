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
    public partial class F_DSXE : DevExpress.XtraEditors.XtraForm
    {
        CXE cx = new CXE();
        public F_DSXE()
        {
            InitializeComponent();
        }

         public void loadDataSource()
        {
            var data = cx.layDSXE();
            gridControl1.DataSource = data;

        }

         private XE getCurrentData()
         {
             var current_row = gridView1.GetSelectedRows()[0];
             return gridView1.GetRow(current_row) as XE;
         }
        private void F_XE_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATXE(this);
            form.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATXE(this, data);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Thật Sự Muốn Xóa Thông Tin Này Không ???", "Xác Nhận",MessageBoxButtons.YesNo , MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var data = getCurrentData();
                cx.xoaXE(data);
                loadDataSource();
            }
        }
    }
}
