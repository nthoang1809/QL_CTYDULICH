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
using QL_CTYDULICH.F_ListFORM;

namespace QL_CTYDULICH
{
    public partial class F_CAPNHATNHANVIEN : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        NHANVIEN oriData;
        bool isNew;

        public F_CAPNHATNHANVIEN()
        {
            InitializeComponent();
        }
        public F_CAPNHATNHANVIEN(DevExpress.XtraEditors.XtraForm parent, NHANVIEN nv = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = nv == null;
            oriData = nv ?? new NHANVIEN();
        }

        private void F_CAPNHATNHANVIEN_Load(object sender, EventArgs e)
        {
            parent.Enabled = false;
            getDataSources();
            bingdingConTrols();
           
        }

        private void bingdingConTrols()
        {
            txtmanv.DataBindings.Add("Text", oriData, "MANV");
            cboChucVu.DataBindings.Add("EditValue", oriData, "MACV",true ,DataSourceUpdateMode.OnPropertyChanged);
            txtTenNV.DataBindings.Add("Text", oriData, "TENNV");
            txtcmndnv.DataBindings.Add("Text", oriData, "CMNDNV");
            dteNgaySinh.DataBindings.Add("EditValue", oriData, "NGAYSINHNV");
            radGT.DataBindings.Add("EditValue", oriData, "GIOITINHNV");
            txtdiachinv.DataBindings.Add("Text", oriData, "DIACHINV");
            txtDT.DataBindings.Add("EditValue", oriData, "DIENTHOAINV");
            txtEmail.DataBindings.Add("Text", oriData, "EMAILNV");
            dtengaynhanchuc.DataBindings.Add("EditValue", oriData, "NGAYNHANCHUC");
            txtTenDN.DataBindings.Add("EditValue", oriData, "TENDANGNHAP");
            txtMK.DataBindings.Add("Text", oriData, "PASSWORD");
            txtGhiChu.DataBindings.Add("Text", oriData, "GHICHU");
        }
        private void F_CAPNHATNHANVIEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSNHANVIEN)
            {
                ((F_DSNHANVIEN)parent).loadDataSource();
            }
        }

        private void btnluunv_Click(object sender, EventArgs e)
        {
            var nv = new CNHANVIEN();
            if (!isNew)
            {
                nv.capnhatNhanVien(oriData);
            }
            else
            {
                nv.themNhanVien(oriData);
            }

            MessageBox.Show("OK !");
            this.Close();
        }

        private void getDataSources()
        {
            CCHUCVU chucvu = new CCHUCVU();
            cboChucVu.Properties.DataSource = chucvu.layDSChucVu();
            cboChucVu.Properties.ValueMember = "MACV";
            cboChucVu.Properties.DisplayMember = "TENCV";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                var nh = new CKHACHHANG();
                nh.Refresh(oriData);
            }
            this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkpass.Checked)
            { 
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}