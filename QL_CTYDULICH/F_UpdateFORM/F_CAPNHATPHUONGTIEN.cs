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
    public partial class F_CAPNHATPHUONGTIEN : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        PHUONGTIENView oriData;
        bool isNew;
        public F_CAPNHATPHUONGTIEN()
        {
            InitializeComponent();
        }

        public F_CAPNHATPHUONGTIEN(DevExpress.XtraEditors.XtraForm parent, PHUONGTIENView data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new PHUONGTIENView();
        }

        private void F_CAPNHATPHUONGTIEN_Load(object sender, EventArgs e)
        {
            parent.Enabled = false;
            getDaTaSource();
            binhdingConTrols();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CPHUONGTIEN();
           
            if (!isNew)
            {
                kh.capnhatPHUONGTIEN(oriData);
            }
            else
            {
                var pt = new CPHUONGTIEN();
                txtDonGia.EditValue = pt.tinhDONGIAPT(oriData);
                kh.themPHUONGTIEN(oriData);
            }

            MessageBox.Show("Thao Tác Thành Công !");
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CPHUONGTIEN();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void binhdingConTrols()
        {
            txtMaPT.DataBindings.Add("EditValue", oriData, "MAPT");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            rdoRanh.DataBindings.Add("EditValue", oriData, "RANH", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDonGia.DataBindings.Add("EditValue", oriData, "DONGIAPT",true,DataSourceUpdateMode.OnPropertyChanged);
            cboTenTaiXe.DataBindings.Add("EditValue", oriData, "MATX", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTenXe.DataBindings.Add("EditValue", oriData, "MAXE", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void getDaTaSource()
        {
            CTAIXE tx = new CTAIXE();
            cboTenTaiXe.Properties.DataSource = tx.layDSTAIXE();
            cboTenTaiXe.Properties.ValueMember = "MATX";
            cboTenTaiXe.Properties.DisplayMember = "TENTX";

            CXE xe = new CXE();
            cboTenXe.Properties.DataSource = xe.layDSXE();
            cboTenXe.Properties.ValueMember = "MAXE";
            cboTenXe.Properties.DisplayMember = "TENXE";

        }

        private void F_CAPNHATPHUONGTIEN_FormClosed(object sender, FormClosedEventArgs e)
        {
           parent.Enabled = true;
            if (parent is F_DSPHUONGTIEN)
            {
                ((F_DSPHUONGTIEN)parent).loadDataSource();
            }
        }

        private void cboTenXe_EditValueChanged(object sender, EventArgs e)
        {
            if (!(cboTenXe.EditValue is int))
                return;

            var maxe = (int)cboTenXe.EditValue;
            CXE xe = new CXE();
            var data = xe.layXEView(maxe);
            cboTenXe.EditValue = data.DONGIAXE;
        }

        private void cboTenTaiXe_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
