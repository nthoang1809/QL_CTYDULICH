using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QL_CTYDULICHDAL;
using QL_CTYDULICHBAL;
using QL_CTYDULICH.F_ListFORM;

namespace QL_CTYDULICH.F_UpdateFORM
{
    public partial class F_DATTOUR : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        HOADONView oriData;
        bool isNew;
       
        public F_DATTOUR()
        {
            InitializeComponent();
        }
       
        public F_DATTOUR(DevExpress.XtraEditors.XtraForm parent, HOADONView data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new HOADONView();
        }
       
        private void F_DATTOUR_Load(object sender, EventArgs e)
        {
            getDaTaSource();
            bindingConTrols();
        }
       
        private void getDaTaSource()
        {
            CKHACHHANG kh = new CKHACHHANG();
            cboKH.Properties.DataSource = kh.layDSKhachHang();
            cboKH.Properties.ValueMember = "MAKH";
            cboKH.Properties.DisplayMember = "TENKH";

            CTOUR tour = new CTOUR();
            cboTour.Properties.DataSource = tour.layDSTOUR();
            cboTour.Properties.ValueMember = "MATOUR";
            cboTour.Properties.DisplayMember = "TENTOUR";

            CNHANVIEN pt = new CNHANVIEN();
            cboNV.Properties.DataSource = pt.layDSNhanVien();
            cboNV.Properties.ValueMember = "MANV";
            cboNV.Properties.DisplayMember = "TENNV";

            CKHACHSAN ks = new CKHACHSAN();
            cboKS.Properties.DataSource = ks.layDSKHACHSAN();
            cboKS.Properties.ValueMember = "MAKS";
            cboKS.Properties.DisplayMember = "TENKS";

            CNHAHANG nh = new CNHAHANG();
            cboNH.Properties.DataSource = nh.layDSNHAHANG();
            cboNH.Properties.ValueMember = "MANH";
            cboNH.Properties.DisplayMember = "TENNH";

            CPHUONGTIEN abc = new CPHUONGTIEN();
            cboPT.Properties.DataSource = abc.layDSPHUONGTIENView();
            cboPT.Properties.ValueMember = "MAPT";
            cboPT.Properties.DisplayMember = "TENPT";
        }
      
        private void bindingConTrols()
        {
            txtMAHD.DataBindings.Add("EditValue", oriData, "MAHD");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            cboKH.DataBindings.Add("EditValue", oriData, "MAKH", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNV.DataBindings.Add("EditValue", oriData, "MANV", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTour.DataBindings.Add("EditValue", oriData, "MATOUR", true, DataSourceUpdateMode.OnPropertyChanged);
            cboKS.DataBindings.Add("EditValue", oriData, "MAKS", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNH.DataBindings.Add("EditValue", oriData, "MANH", true, DataSourceUpdateMode.OnPropertyChanged);
            cboPT.DataBindings.Add("EditValue", oriData, "MAPT", true, DataSourceUpdateMode.OnPropertyChanged);
        }
      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CHOADON();
            if (!isNew)
            {
                kh.capnhatHOADON(oriData);
            }
            else
            {
                kh.themHOADON(oriData);
            }
            MessageBox.Show("Thao Tác Thành Công !");
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CHOADON();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void cboKS_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

        }

        private void F_DATTOUR_FormClosed(object sender, FormClosedEventArgs e)
        {

            parent.Enabled = true;
            if (parent is F_DSDATTOUR)
            {
                ((F_DSDATTOUR)parent).loadDaTaSource();
            }
        }

        private void cboTour_EditValueChanged(object sender, EventArgs e)
        {
            if (!(cboTour.EditValue is int /*&& (int)cboTour.EditValue != 0)*/))
                return;

            var matour = (int)cboTour.EditValue;
            var tour = new CTOUR();
            var data = tour.layTourView(matour);
            cboNH.EditValue = data.MANH;
            cboKS.EditValue = data.MAKS;
            cboPT.EditValue = data.MAPT;
        }
    }
}