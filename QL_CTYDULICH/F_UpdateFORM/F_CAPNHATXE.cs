using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_CTYDULICHDAL;
using QL_CTYDULICHBAL;
using QL_CTYDULICH.F_ListFORM;

namespace QL_CTYDULICH.F_UpdateFORM
{
    public partial class F_CAPNHATXE : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        XE oriData;
        bool isNew;
        public F_CAPNHATXE()
        {
            InitializeComponent();
        }

        public F_CAPNHATXE(DevExpress.XtraEditors.XtraForm parent, XE data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new XE();
        }
        private void F_CAPNHATXE_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
        }

        private void bingdingConTrols()
        {
            txtMaXe.DataBindings.Add("EditValue", oriData, "MAXE");
            txtTenXe.DataBindings.Add("EditValue", oriData, "TENXE");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            numericSCN.DataBindings.Add("Value", oriData, "SOCHONGOI", true, DataSourceUpdateMode.OnPropertyChanged);
            numericDONGIA.DataBindings.Add("Value", oriData, "DONGIAXE", true, DataSourceUpdateMode.OnPropertyChanged);
            numericSL.DataBindings.Add("Value", oriData, "SOLUONGXE", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CXE();
            if (!isNew)
            {
                kh.capnhatXE(oriData);
            }
            else
            {
                kh.themXE(oriData);
            }

            MessageBox.Show("Thao Tác Thành Công !");
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CXE();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void F_CAPNHATXE_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSXE)
            {
                ((F_DSXE)parent).loadDataSource();
            }
        }
    }
}
