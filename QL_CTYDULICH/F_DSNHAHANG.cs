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
    public partial class F_DSNHAHANG : DevExpress.XtraEditors.XtraForm
    {
        CNHAHANG nh = new CNHAHANG();
        public F_DSNHAHANG()
        {
            InitializeComponent();
        }

        private void F_DSNHAHANG_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }
         public void loadDaTaSource()
        {
            gridControl1.DataSource = nh.layDSNHAHANG();
        }

        private NHAHANG getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as NHAHANG;
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var form = new F_CAPNHATNHAHANG(this);
            form.Show();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
            var data = getCurrentData();
            var form = new F_CAPNHATNHAHANG(this, data);
            form.Show();
        }
    }
}