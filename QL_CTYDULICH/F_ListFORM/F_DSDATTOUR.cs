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
using QL_CTYDULICH.F_UpdateFORM;

namespace QL_CTYDULICH.F_ListFORM
{
    public partial class F_DSDATTOUR : DevExpress.XtraEditors.XtraForm
    {
        CHOADON tour = new CHOADON();
        public F_DSDATTOUR()
        {
            InitializeComponent();
        }
        public void loadDaTaSource()
        {
            var data = tour.layDSHD();
            gridControl1.DataSource = data;
        }
        private HOADONView getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as HOADONView;
        }
        private void F_DSDATTOUR_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            var form = new F_DATTOUR(this);
            form.Show();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_DATTOUR(this,data);
            form.Show();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu này không ???", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var data = getCurrentData();
                tour.xoaHOADON(data);
                loadDaTaSource();
            }
        }
    }
}