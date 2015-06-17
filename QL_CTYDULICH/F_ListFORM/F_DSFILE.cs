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
    public partial class F_DSFILE : DevExpress.XtraEditors.XtraForm
    {
        CFILE file = new CFILE();
        public F_DSFILE()
        {
            InitializeComponent();
        }

        public void loadDaTaSource()
        {
            var data = file.layDSFILE();
            gridControl1.DataSource = data;
        }

        private FILE getCurrentData()
        {
            var current_row = gridView1.GetSelectedRows()[0];
            return gridView1.GetRow(current_row) as FILE;
        }
        private void F_DSFILE_Load(object sender, EventArgs e)
        {
            loadDaTaSource();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //var form = new F_CAPNHATFILE(this);
            //form.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //var data = getCurrentData();
            //var form = new F_CAPNHATFILE(this, data);
            //form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = getCurrentData();
            file.xoaFILE(data);
            loadDaTaSource();
        }
    }
}
