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
    public partial class F_CAPNHATTOUR : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        TOURView oriData;
        bool isNew;
        public F_CAPNHATTOUR()
        {
            InitializeComponent();
        }

        public F_CAPNHATTOUR(DevExpress.XtraEditors.XtraForm parent, TOURView data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new TOURView();
        }
        private void F_CAPNHATTOUR_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
            getDaTaSource();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          var kh = new CTOUR();
            if (!isNew)
            {
                kh.capnhatTOUR(oriData);
            }
            else
            {
                kh.themTOUR(oriData);
            }
            MessageBox.Show("Thao Tác Thành Công !");
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CTOUR();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void bingdingConTrols()
        {
            txtMaTour.DataBindings.Add("EditValue", oriData, "MATOUR");
            txtTenTour.DataBindings.Add("EditValue", oriData, "TENTOUR");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            radLoaiTour.DataBindings.Add("EditValue", oriData, "LOAITOUR");
            txtThoiGian.DataBindings.Add("EditValue", oriData, "THOIGIAN", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDiaDiem.DataBindings.Add("EditValue", oriData, "MADIADIEM", true, DataSourceUpdateMode.OnPropertyChanged);
            cboKhachSan.DataBindings.Add("EditValue", oriData, "MAKS", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNhaHang.DataBindings.Add("EditValue", oriData, "MANH", true, DataSourceUpdateMode.OnPropertyChanged);
            cboPhuongTien.DataBindings.Add("EditValue", oriData, "MAPT", true, DataSourceUpdateMode.OnPropertyChanged);
            //cboKH.DataBindings.Add("EditValue", oriData, "MAKH", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void getDaTaSource()
        {
            CPHUONGTIEN pt = new CPHUONGTIEN();
            cboPhuongTien.Properties.DataSource = pt.layDSPHUONGTIENView();
            cboPhuongTien.Properties.ValueMember = "MAPT";
            cboPhuongTien.Properties.DisplayMember = "TENPT";

            CDIADIEM dd = new CDIADIEM();
            cboDiaDiem.Properties.DataSource = dd.layDSDiaDiem();
            cboDiaDiem.Properties.ValueMember = "MADIADIEM";
            cboDiaDiem.Properties.DisplayMember = "TENDIADIEM";

            //CKHACHHANG kh = new CKHACHHANG();
            //cboKH.Properties.DataSource = kh.layDSKhachHang();
            //cboKH.Properties.ValueMember = "MAKH";
            //cboKH.Properties.DisplayMember = "TENKH";
        }

        private void F_CAPNHATTOUR_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSTOUR)
            {
                ((F_DSTOUR)parent).loadDaTaSource();
            }
        }

        private void cboDiaDiem_EditValueChanged(object sender, EventArgs e)
        {
            if (!(cboDiaDiem.EditValue is int))
                return;

            var madd = (int)cboDiaDiem.EditValue;

            CNHAHANG nh = new CNHAHANG();
            cboNhaHang.Properties.DataSource = nh.layDSNHAHANG_DIADIEM(madd);
            cboNhaHang.Properties.ValueMember = "MANH";
            cboNhaHang.Properties.DisplayMember = "TENNH";

            CKHACHSAN ks = new CKHACHSAN();
            cboKhachSan.Properties.DataSource = ks.layDSKHACHSAN_DIADIEM(madd);
            cboKhachSan.Properties.ValueMember = "MAKS";
            cboKhachSan.Properties.DisplayMember = "TENKS";
        }
    }
}
