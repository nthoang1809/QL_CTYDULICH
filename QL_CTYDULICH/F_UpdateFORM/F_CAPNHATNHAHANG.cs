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
    public partial class F_CAPNHATNHAHANG : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraEditors.XtraForm parent;
        NHAHANG oriData;
        bool isNew;
        public F_CAPNHATNHAHANG()
        {
            InitializeComponent();
        }

        public F_CAPNHATNHAHANG(DevExpress.XtraEditors.XtraForm parent, NHAHANG data = null)
        {
            InitializeComponent();
            this.parent = parent;
            isNew = data == null;
            oriData = data ?? new NHAHANG();
        }
        private void F_CAPNHATNHAHANG_Load(object sender, EventArgs e)
        {
            getDaTaSource();
            bingdingConTrols();
        }

        private void bingdingConTrols()
        {
            txtmanh.DataBindings.Add("EditValue", oriData, "MANH");
            txtTenNH.DataBindings.Add("EditValue", oriData, "TENNH");
            txtGhiChu.DataBindings.Add("EditValue", oriData, "GHICHU");
            txtDiaChiNH.DataBindings.Add("EditValue", oriData, "DIACHINH");
            radioGroup1.DataBindings.Add("EditValue", oriData, "DACDIEMNH", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Value", oriData, "DONGIANH", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDiaDiem.DataBindings.Add("EditValue", oriData, "MADIADIEM", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void getDaTaSource()
        {
            CDIADIEM dd = new CDIADIEM();
            cboDiaDiem.Properties.DataSource = dd.layDSDiaDiem();
            cboDiaDiem.Properties.ValueMember = "MADIADIEM";
            cboDiaDiem.Properties.DisplayMember = "TENDIADIEM";
        }
        private void btnluunv_Click(object sender, EventArgs e)
        {
            var kh = new CNHAHANG();
            if (!isNew)
            {
                if (string.IsNullOrEmpty(txtTenNH.Text))
                {
                    dxErrorProvider1.SetError(txtTenNH, "Tên nhà hàng không được rỗng");
                    return;
                }
                else
                    if (string.IsNullOrEmpty(txtDiaChiNH.Text))
                    {
                        dxErrorProvider1.SetError(txtDiaChiNH, "Địa chỉ không được rỗng");
                        return;
                    }
                    else
                        if (numericUpDown1.Value <= 0)
                        {
                            dxErrorProvider1.SetError(numericUpDown1, "Đơn giá không được rỗng");
                            return;
                        }
                        else
                            if (cboDiaDiem.ItemIndex == -1)
                            {
                                dxErrorProvider1.SetError(cboDiaDiem, "Vui long chọn đia điểm");
                                return;
                            }
                            else
                                if (MessageBox.Show("Bạn có muốn cập nhật nhà hàng " + txtTenNH.Text + " ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    kh.capnhatNHAHANG(oriData);
                                    MessageBox.Show("Cập nhật nhà hàng "+ txtTenNH.Text +" thành công !");
                                    this.Close();
                                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenNH.Text))
                {
                    dxErrorProvider1.SetError(txtTenNH, "Tên nhà hàng không được rỗng");
                    return;
                }
                else
                    if (string.IsNullOrEmpty(txtDiaChiNH.Text))
                    {
                        dxErrorProvider1.SetError(txtDiaChiNH, "Địa chỉ không được rỗng");
                        return;
                    }
                    else
                        if (numericUpDown1.Value <= 0)
                        {
                            dxErrorProvider1.SetError(numericUpDown1, "Đơn giá không được rỗng");
                            return;
                        }
                        else
                            if (cboDiaDiem.ItemIndex == -1)
                            {
                                dxErrorProvider1.SetError(cboDiaDiem, "Vui lòng chọn địa điểm");
                                return;
                            }
                            else
                                if (MessageBox.Show("Bạn có muốn cập nhật nhà hàng " + txtTenNH.Text + " ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    kh.themNHAHANG(oriData);
                                    MessageBox.Show("Thêm nhà hàng " + txtTenNH.Text + " thành công !");
                                    this.Close();
                                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!isNew)
                {
                    var nh = new CNHAHANG();
                    nh.Refresh(oriData);
                }
                this.Close();
            }
        }

        private void F_CAPNHATNHAHANG_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            if (parent is F_DSNHAHANG)
            {
                ((F_DSNHAHANG)parent).loadDaTaSource();
            }
        }
    }
}
