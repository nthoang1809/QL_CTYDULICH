using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_CTYDULICH.F_UpdateFORM;
using QL_CTYDULICHBAL;
using QL_CTYDULICHDAL;

namespace QL_CTYDULICH.F_ListFORM
{
    public partial class F_DSTAIXE : DevExpress.XtraEditors.XtraForm
    {
        CTAIXE tx = new CTAIXE();
        public F_DSTAIXE()
        {
            InitializeComponent();
        }

        public void loadDataSource()
        {
            var data = tx.layDSTAIXE();
            gridControl1.DataSource = data;

        }

        private TAIXE getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as TAIXE;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATTAIXE(this);
            form.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATTAIXE(this, data);
            form.Show();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var data = getCurrentData();
            tx.xoaTAIXE(data);
            loadDataSource();
        }

        private void F_DSTAIXE_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }
    }
}
