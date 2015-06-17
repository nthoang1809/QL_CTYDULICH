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
    public partial class F_DSCHUCVU : DevExpress.XtraEditors.XtraForm
    {
        CCHUCVU cv = new CCHUCVU();
        public F_DSCHUCVU()
        {
            InitializeComponent();
        }

        public void loadDataSource()
        {
            var data = cv.layDSChucVu();
            gridControl1.DataSource = data;
        }

        private CHUCVU getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as CHUCVU;
        }

        private void F_DSCHUCVU_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATCHUCVU(this);
            form.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATCHUCVU(this, data);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var data = getCurrentData();
                cv.xoaCHUCVU(data);
                loadDataSource();
            }
        }
    }
}
