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
    public partial class F_DSDIADIEM : DevExpress.XtraEditors.XtraForm
    {
        CDIADIEM dd = new CDIADIEM();
        public F_DSDIADIEM()
        {
            InitializeComponent();
        }

        public void loadDaTaSource()
        {
            var data = dd.layDSDiaDiem();
            gridControl1.DataSource = data;
        }
        private DIADIEM getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as DIADIEM;
        }
        private void F_DSDIADIEM_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa không ???","THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var data = getCurrentData();
                dd.xoaDiaDiem(data);
                loadDaTaSource();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATDIADIEM(this);
            form.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATDIADIEM(this, data);
            form.Show();
        }
    }
}
