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
    public partial class F_DSPHUONGTIEN : DevExpress.XtraEditors.XtraForm
    {
        CPHUONGTIEN pt = new CPHUONGTIEN();
        CTAIXE tx = new CTAIXE();
        CXE xe = new CXE();
        public F_DSPHUONGTIEN()
        {
            InitializeComponent();
        }
        public void loadDataSource()
        {
            var data = pt.layDSPHUONGTIENAll();
            gridControl1.DataSource = data;
        }
        private void F_DSPHUONGTIEN_Load(object sender, EventArgs e)
        {
            loadDataSource();
        }
        private PHUONGTIENView getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as PHUONGTIENView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new F_CAPNHATPHUONGTIEN(this);
            form.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            var form = new F_CAPNHATPHUONGTIEN(this, data);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            pt.xoaPHUONGTIEN(data);
            loadDataSource();
        }
    }
}
