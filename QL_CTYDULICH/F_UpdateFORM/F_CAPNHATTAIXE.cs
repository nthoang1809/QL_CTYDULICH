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
    public partial class F_CAPNHATTAIXE : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        TAIXE oriData;
        bool isNew;
        public F_CAPNHATTAIXE()
        {
            InitializeComponent();
        }

        public F_CAPNHATTAIXE(DevExpress.XtraEditors.XtraForm parent, TAIXE data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new TAIXE();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CTAIXE();
            if (!isNew)
            {
                kh.capnhatTAIXE(oriData);
            }
            else
            {
                kh.themTAIXE(oriData);
            }

            MessageBox.Show("Thao Tác Thành Công !");
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CTAIXE();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void F_CAPNHATTAIXE_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
        }

        private void bingdingConTrols()
        {
            txtMaTX.DataBindings.Add("EditValue", oriData, "MATX");
            txtTenTX.DataBindings.Add("EditValue", oriData, "TENTX");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            txtDiaChiTX.DataBindings.Add("EditValue", oriData, "DIACHITX");
            numericUpDown1.DataBindings.Add("Value", oriData, "DONGIATX", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDTTX.DataBindings.Add("EditValue", oriData, "DTTX");
            txtCMD.DataBindings.Add("EditValue", oriData, "CMNDTX");
        }

        private void F_CAPNHATTAIXE_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSTAIXE)
            {
                ((F_DSTAIXE)parent).loadDataSource();
            }
        }
    }
}
