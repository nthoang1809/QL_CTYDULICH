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
    public partial class cboTour : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        HOADONView oriData;
        bool isNew;
        public cboTour()
        {
            InitializeComponent();
        }
        public cboTour(DevExpress.XtraEditors.XtraForm parent, HOADONView data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new HOADONView();
        }

        private void getDaTaSource()
        {
            CKHACHHANG kh = new CKHACHHANG();
            cboKH.Properties.DataSource = kh.layDSKhachHang();
            cboKH.Properties.ValueMember = "MAKH";
            cboKH.Properties.DisplayMember = "TENKH";

            CTOUR tour = new CTOUR();
            lookUpEdit2.Properties.DataSource = tour.layDSTOUR();
            lookUpEdit2.Properties.ValueMember = "MATOUR";
            lookUpEdit2.Properties.DisplayMember = "TEMTOUR";

            CNHANVIEN pt = new CNHANVIEN();
            cboNV.Properties.DataSource = pt.layDSNhanVien();
            cboNV.Properties.ValueMember = "MANV";
            cboNV.Properties.DisplayMember = "TENNV";

        }

        private void F_DANGKYTOUR_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
            getDaTaSource();
            
        }
        private void bingdingConTrols()
        {
            
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            
        }

        
        private void F_DANGKYTOUR_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSDATTOUR)
            {
                ((F_DSDATTOUR)parent).loadDaTaSource();
            }
        }

        private void cboTour_EditValueChanged(object sender, EventArgs e)
        {
            ////if (!(cboTour.EditValue is int))
            ////    return;

            ////var matour = (int)cboTour.EditValue;
            ////CTOUR tour = new CTOUR();
            ////var data = tour.layTourView(matour);
            ////txtKS.EditValue = data.TENKS;
            ////txtNH.EditValue = data.TENNH;
            ////txtPT.EditValue = data.TENPT;

            //txtKS.DataBindings.Add("EditValue", oriData, "MAKS");
            //txtNH.DataBindings.Add("EditValue", oriData, "MANH");
            //var madd = (int)cboTour.EditValue;

            //CTOUR nh = new CTOUR();
            //cboNhahang.Properties.DataSource = nh.layTourView(matour);
            //cboNhahang.Properties.ValueMember = "MANH";
            //cboNhahang.Properties.DisplayMember = "TENNH";

            //CTOUR ks = new CTOUR();
            //cboKhachSan.Properties.DataSource = ks.layTourView(matour);
            //cboKhachSan.Properties.ValueMember = "MAKS";
            //cboKhachSan.Properties.DisplayMember = "TENKS";
        }
    }
}