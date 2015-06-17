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
    public partial class F_CAPNHATKHACHSAN : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        KHACHSAN oriData;
        bool isNew;
        public F_CAPNHATKHACHSAN()
        {
            InitializeComponent();
        }

        public F_CAPNHATKHACHSAN(DevExpress.XtraEditors.XtraForm parent, KHACHSAN data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new KHACHSAN();
        }

        private void F_CAPNHATKHACHSAN_Load(object sender, EventArgs e)
        {
            bingdingConTrols();
            getDaTaSource();
        }

        private void bingdingConTrols()
        {
            txtMaKS.DataBindings.Add("EditValue", oriData, "MAKS");
            txtTenKS.DataBindings.Add("EditValue", oriData, "TENKS");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            txtDiaChiKS.DataBindings.Add("EditValue", oriData, "DIACHIKS");
            radKS.DataBindings.Add("EditValue", oriData, "DACDIEMKS");
            numericUpDown1.DataBindings.Add("Value", oriData, "DONGIAKS", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDiaDiem.DataBindings.Add("EditValue", oriData, "MADIADIEM", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void getDaTaSource()
        {
            CDIADIEM dd = new CDIADIEM();
            cboDiaDiem.Properties.DataSource = dd.layDSDiaDiem();
            cboDiaDiem.Properties.ValueMember = "MADIADIEM";
            cboDiaDiem.Properties.DisplayMember = "TENDIADIEM";

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var kh = new CKHACHSAN();
            if (!isNew)
            {
                if (cboDiaDiem.ItemIndex == -1)
                {
                    dxErrorProvider1.SetError(cboDiaDiem, "Địa điểm không được rỗng");
                    return;
                }
                else
                    if (string.IsNullOrEmpty(txtTenKS.Text))
                    {
                        dxErrorProvider1.SetError(txtTenKS, "TÊN khách sạn rỗng !");
                        return;
                    }
                    else
                        if (string.IsNullOrEmpty(txtDiaChiKS.Text))
                        {
                            dxErrorProvider1.SetError(txtDiaChiKS, "ĐỊA CHỈ khách sạn rỗng !");
                            return;
                        }
                        else
                            if (MessageBox.Show("Bạn muốn cập nhật khách sạn " + txtTenKS.Text + " không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                kh.capnhatKHACHSAN(oriData);
                                MessageBox.Show("Cập nhật khách sạn " + txtTenKS.Text + " thành công !!!");
                                this.Close();
                            }
            }
            else
            {
                if (cboDiaDiem.ItemIndex == -1)
                {
                    dxErrorProvider1.SetError(cboDiaDiem, "Địa điểm không được rỗng");
                    return;
                }
                else
                    if (string.IsNullOrEmpty(txtTenKS.Text))
                    {
                        dxErrorProvider1.SetError(txtTenKS, "TÊN khách sạn rỗng !");
                        return;
                    }
                    else
                        if (string.IsNullOrEmpty(txtDiaChiKS.Text))
                        {
                            dxErrorProvider1.SetError(txtDiaChiKS, "ĐỊA CHỈ khách sạn rỗng !");
                            return;
                        }
                        else
                            if (MessageBox.Show("Bạn muốn thêm khách sạn " + txtTenKS.Text + " không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                kh.themKHACHSAN(oriData);
                                MessageBox.Show("Thêm khách sạn " + txtTenKS.Text + " thành công !!!");
                                this.Close();
                            }
                        }
                    }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!isNew)
                {
                    var nh = new CKHACHSAN();
                    nh.Refresh(oriData);
                }
                this.Close();
            }
        }

        private void F_CAPNHATKHACHSAN_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSKHACHSAN)
            {
                ((F_DSKHACHSAN)parent).loadDaTaSource();
            }
        }
    }
}
